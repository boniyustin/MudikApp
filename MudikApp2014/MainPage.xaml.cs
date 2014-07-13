using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MudikApp2014.Resources;
using MudikApp2014.Classes;
using Microsoft.Phone.Maps.Services;
using System.Device.Location;
using System.IO.IsolatedStorage;
using Windows.Devices.Geolocation;
using System.Diagnostics;
using System.Threading;

namespace MudikApp2014
{
    public partial class MainPage : PhoneApplicationPage
    {

        public MainPage()
        {
            InitializeComponent();
            Thread.Sleep(1500);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("LocationConsent"))
            {
                // User has opted in or out of Location
                return;
            }

            MessageBoxResult result =
                MessageBox.Show("This app accesses your phone's location. Is that ok?",
                "Location",
                MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                IsolatedStorageSettings.ApplicationSettings["LocationConsent"] = true;
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings["LocationConsent"] = false;
                this.NavigationService.GoBack();
                //Terminate
            }

            IsolatedStorageSettings.ApplicationSettings.Save();

            OneShotLocation();
        }
        Geolocator geolocator;
        //Since we need to use the await operator, this method needs to be async
        private async void OneShotLocation()
        {
            //Check for the user agreement in use his position. If not, method returns.
            if ((bool)IsolatedStorageSettings.ApplicationSettings["LocationConsent"] != true)
            {
                // The user has opted out of Location.
                return;
            }
            //Declare and Inizialize a Geolocator object
            geolocator = new Geolocator();
            //Set his accuracy in Meters 
            geolocator.DesiredAccuracyInMeters = 50;

            //Let's get the position of the user. Since there is the possibility of getting an Exception, this method is called inside a try block
            try
            {
                //The await guarantee the calls  to be returned on the thread from which they were called
                //Since it is call directly from the UI thread, the code is able to access and modify the UI directly when the call returns.
                
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(20)
                    );
                
                TransitionData.current_location = new GeoCoordinate(geoposition.Coordinate.Latitude,
                                                    geoposition.Coordinate.Longitude);
                //this.LoadingIndicator.Visibility = Visibility.Collapsed;
            }
            //If an error is catch 2 are the main causes: the first is that you forgot to includ ID_CAP_LOCATION in your app manifest. 
            //The second is that the user doesn't turned on the Location Services
            catch (Exception ex)
            {
                //this.LoadingIndicator.Visibility = Visibility.Collapsed;
                if ((uint)ex.HResult == 0x80004004)
                {
                    //StatusTextBlock.Text = "Status= Location  is disabled in phone settings.";
                }
                //else
                {
                    // something else happened during the acquisition of the location
                }
            }
        }

        void geolocator_StatusChanged(Geolocator sender, StatusChangedEventArgs args)
        {
            string status = "";

            switch (args.Status)
            {
                case PositionStatus.Disabled:
                    // the application does not have the right capability or the location master switch is off
                    status = "location is disabled in phone settings";
                    break;
                case PositionStatus.Initializing:
                    // the geolocator started the tracking operation
                    status = "initializing";
                    break;
                case PositionStatus.NoData:
                    // the location service was not able to acquire the location
                    status = "no data";
                    break;
                case PositionStatus.Ready:
                    // the location service is generating geopositions as specified by the tracking parameters
                    status = "ready";
                    break;
                case PositionStatus.NotAvailable:
                    status = "not available";
                    // not used in WindowsPhone, Windows desktop uses this value to signal that there is no hardware capable to acquire location information
                    break;
                case PositionStatus.NotInitialized:
                    // the initial state of the geolocator, once the tracking operation is stopped by the user the geolocator moves back to this state

                    break;
            }
            /*This part write the status to the UI element StatusTextBlock*/
            Dispatcher.BeginInvoke(() =>
            {
                LoadingStatus.Text = status;
            });
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.IsConnected)
            {
                MessageBox.Show(App.NoInternet);
                return;
            }

            InitiateData();
        }

        private void ImageJalur_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string QueryJalur = (string)(sender as Image).Tag;
            this.NavigationService.Navigate(new Uri("/Pages/GeneralRoutePage.xaml?" + "QueryJalur=" + QueryJalur, UriKind.Relative));
        }

        private void JalurOffline_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string QueryJalur = (string)(sender as Image).Tag;
            this.NavigationService.Navigate(new Uri("/Pages/JalurOfflinePage.xaml", UriKind.Relative));
        }

        #region =================== Get Direction ======================

        private string currentAddress = "";

        private void getRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!App.IsConnected)
            {
                MessageBox.Show(App.NoInternet);
                return;
            }

            TransitionData.start_location = null;
            TransitionData.finish_location = null;
            if (CurrentLocationCheckBox.IsChecked == true)
            {
                TransitionData.start_location = TransitionData.current_location;
                getGeoCoordinate(address2TextBox.Text);
            }
            else
                getGeoCoordinate(address1TextBox.Text);
        }

        private void CurrentLocation_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)IsolatedStorageSettings.ApplicationSettings["LocationConsent"] == false)
            {
                (sender as CheckBox).IsChecked = false;
                return;
            }
            if (TransitionData.current_location == null)
            {
                OneShotLocation();
                MessageBox.Show("Getting location is still on progress. Please try again for a few seconds");
                (sender as CheckBox).IsChecked = false;
                return;
            }
            address1TextBox.Text = String.Format("{0} , {1}", 
                TransitionData.current_location.Latitude, TransitionData.current_location.Longitude);
            address1TextBox.IsReadOnly = true;
        }

        private void CurrentLocation_Unchecked(object sender, RoutedEventArgs e)
        {
            address1TextBox.Text = string.Empty;
            address1TextBox.IsReadOnly = false;
        }

        private void getGeoCoordinate(string address)
        {
            if (address == "")
            {
                MessageBox.Show("Address cannot be empty!");
                return;
            }
            GeocodeQuery query = new GeocodeQuery()
            {
                GeoCoordinate = new GeoCoordinate(0, 0),
                SearchTerm = address
            };
            currentAddress = address;
            query.QueryCompleted += geoCoordinateQuery_QueryCompleted;
            query.QueryAsync();
        }

        private void geoCoordinateQuery_QueryCompleted(object sender, QueryCompletedEventArgs<IList<MapLocation>> e)
        {
            var item = e.Result;
            if (item.Count() == 0)
            {
                MessageBox.Show(String.Format("{0}, No GeoCoordinate found!", currentAddress));
                return;
            }
            if (item.ElementAt(0).GeoCoordinate == null)
            {
                MessageBox.Show(String.Format("{0}, No GeoCoordinate found!", currentAddress));
                return;
            }
            if (TransitionData.start_location == null)
            {
                TransitionData.start_location = item.ElementAt(0).GeoCoordinate;
                getGeoCoordinate(address2TextBox.Text);
            }
            else if (TransitionData.finish_location == null)
            {
                TransitionData.finish_location = item.ElementAt(0).GeoCoordinate;
            }
            // is both geos there
            if (TransitionData.start_location != null && TransitionData.finish_location != null)
            {
                this.NavigationService.Navigate(new Uri("/Pages/GetDirectionPage.xaml",UriKind.Relative));
            }
        }
        #endregion


        #region Nearby Place
        
        private void kuliner_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (TransitionData.current_location == null)
            {
                OneShotLocation();
                MessageBox.Show("Getting location is still on progress. Please try again for a few seconds");
                return;
            }

            this.NavigationService.Navigate(new Uri("/Pages/NearbyPlacePage.xaml?category=" + PlaceCategory.Restaurant + "&Title=kuliner" , UriKind.Relative));
        }

        private void penginapan_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (TransitionData.current_location == null)
            {
                OneShotLocation();
                MessageBox.Show("Getting location is still on progress. Please try again for a few seconds");
                return;
            }

            this.NavigationService.Navigate(new Uri("/Pages/NearbyPlacePage.xaml?category=" + PlaceCategory.Hotel + "&Title=penginapan", UriKind.Relative));
        }
        
        private void transportasi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (TransitionData.current_location == null)
            {
                OneShotLocation();
                MessageBox.Show("Getting location is still on progress. Please try again for a few seconds");
                return;
            }

            this.NavigationService.Navigate(new Uri("/Pages/NearbyPlacePage.xaml?category=" + PlaceCategory.Transport + "&Title=transportasi", UriKind.Relative));
        }
        
        private void pusatperbelanjaan_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (TransitionData.current_location == null)
            {
                OneShotLocation();
                MessageBox.Show("Getting location is still on progress. Please try again for a few seconds");
                return;
            }

            this.NavigationService.Navigate(new Uri("/Pages/NearbyPlacePage.xaml?category=" + PlaceCategory.Shopping + "&Title=pusat perbelanjaan", UriKind.Relative));
        }

        #endregion

        #region Info Lalu Lintas

        public void InitiateData()
        {
            WebClient client = new WebClient();
            String username = "rttmc_client";
            String password = "rttmc_m4p5";
            string url = String.Format("http://www.rttmc-hubdat.com/client/maps/api/news/list?page={0}&rows={1}", 1, 50);

            client.Credentials = new System.Net.NetworkCredential(username, password);

            string credentials = Convert.ToBase64String(StringToAscii(username + ":" + password));

            client.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri(url, UriKind.Absolute));

        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(e.Result))
                {
                    var result = XMLHelper.Deserialize<xml>(e.Result);
                    foreach (var item in result.news)
                    {
                        item.nama_lokasi = item.nama_lokasi + ", " + item.nama_kota;
                        item.cuaca = item.cuaca + " dan " + item.arus;
                        item.cctv_view = "http://203.130.228.228/" + item.cctv_view + ".jpg";
                    }
                    NewsListBox.ItemsSource = result.news;
                }
                else
                {
                    MessageBox.Show("No Data received");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(e.Error.Message + "\n" + ex.Message);
            }
        }

        public static byte[] StringToAscii(string s)
        {
            byte[] retval = new byte[s.Length];
            for (int ix = 0; ix < s.Length; ++ix)
            {
                char ch = s[ix];
                if (ch <= 0x7f) retval[ix] = (byte)ch;
                else retval[ix] = (byte)'?';
            }
            return retval;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            InitiateData();
        }

        #endregion

        private List<string> suggestions = new List<string>();
        private string GlobalSearchTerm = string.Empty;
        private bool IsSearching = false;

        private void address1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int lng = address1TextBox.Text.Length;
            if (lng <= 5) return;

            if (IsSearching) return;
            IsSearching = true;
            GlobalSearchTerm = address1TextBox.Text.ToLower();
            SearchForTerm(address1TextBox.Text);
        }

        private void SearchForTerm(String searchTerm)
        {
            try
            {
                var MyGeocodeQuery = new GeocodeQuery();
                MyGeocodeQuery.SearchTerm = searchTerm;
                MyGeocodeQuery.GeoCoordinate = new GeoCoordinate(-6.2087630, 106.8455990);
                MyGeocodeQuery.QueryCompleted += GeocodeQuery_QueryCompleted;
                MyGeocodeQuery.QueryAsync();
            }
            catch (Exception ex)
            {
                IsSearching = false;
                //MessageBox.Show(ex.Message);
            }
        }

        private void GeocodeQuery_QueryCompleted(object sender, QueryCompletedEventArgs<IList<MapLocation>> e)
        {
            if (e.Error == null)
            {
                foreach (MapLocation item in e.Result)
                {
                    string hasil = string.Empty;

                    if (item.Information.Address.Street.ToLower().Contains(GlobalSearchTerm)) 
                        hasil = item.Information.Address.Street;
                    if (suggestions.Contains(hasil) == false && hasil != string.Empty) 
                        suggestions.Add(hasil);

                    if (item.Information.Address.District.ToLower().Contains(GlobalSearchTerm))
                        hasil = item.Information.Address.District;
                    if (suggestions.Contains(hasil) == false && hasil != string.Empty)
                        suggestions.Add(hasil);

                    if (item.Information.Address.State.ToLower().Contains(GlobalSearchTerm))
                        hasil = item.Information.Address.State;
                    if (suggestions.Contains(hasil) == false && hasil != string.Empty)
                        suggestions.Add(hasil);

                    if (item.Information.Address.City.ToLower().Contains(GlobalSearchTerm))
                        hasil = item.Information.Address.City;
                    if (suggestions.Contains(hasil) == false && hasil != string.Empty)
                        suggestions.Add(hasil);

                    if (item.Information.Address.Country.ToLower().Contains(GlobalSearchTerm))
                        hasil = item.Information.Address.Country;
                    if (suggestions.Contains(hasil) == false && hasil != string.Empty)
                        suggestions.Add(hasil);

                    if (item.Information.Address.Province.ToLower().Contains(GlobalSearchTerm))
                        hasil = item.Information.Address.Province;
                    if (suggestions.Contains(hasil) == false && hasil != string.Empty)
                        suggestions.Add(hasil);
                    
                }
                this.address1TextBox.SuggestionsSource = suggestions;
                this.address2TextBox.SuggestionsSource = suggestions;
                IsSearching = false;
                //if (e.Result.Count > 0)
                //{
                //    if (_isRouteSearch) // Query is made to locate the destination of a route
                //    {
                //    }
                //    else // Query is made to search the map for a keyword
                //    {
                //        // Add all results to MyCoordinates for drawing the map markers
                //        for (int i = 0; i < e.Result.Count; i++)
                //        {
                //            MyCoordinates.Add(e.Result[i].GeoCoordinate);
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("No match found. Narrow your search e.g. Seattle WA.");
                //}
            }
        }

        private void address2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int lng = address2TextBox.Text.Length;
            if (lng <= 5) return;

            if (IsSearching) return;
            IsSearching = true;
            GlobalSearchTerm = address2TextBox.Text.ToLower();
            SearchForTerm(address2TextBox.Text);
        }

        
    }
}