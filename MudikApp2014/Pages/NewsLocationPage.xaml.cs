using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MudikApp2014.Classes;
using System.Device.Location;
using System.Windows.Input;
using Microsoft.Phone.Maps.Controls;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;

namespace MudikApp2014.Pages
{
    public partial class NewsLocationPage : PhoneApplicationPage
    {
        private xml ListResultOfDataNews;
        private RootObjectLaluLintas ListResultOfLocationNews;
        private List<GeoCoordinate> ListLocations;

        public NewsLocationPage()
        {
            ListResultOfDataNews = new xml();
            ListResultOfLocationNews = new RootObjectLaluLintas();
            ListLocations = new List<GeoCoordinate>();

            InitializeComponent();
            InitiateData();
            //GettingLocation();
        }

        #region Info Lalu Lintas

        public void InitiateData()
        {
            if (!App.IsConnected)
            {
                MessageBox.Show(App.NoInternet);
                return;
            }

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

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(e.Result))
                {
                    ListResultOfDataNews = XMLHelper.Deserialize<xml>(e.Result);
                    foreach (var item in ListResultOfDataNews.news)
                    {
                        item.nama_lokasi = item.nama_lokasi + ", " + item.nama_kota;
                        item.cuaca = item.cuaca + " dan " + item.arus;
                        item.cctv_view = "http://203.130.228.228/" + item.cctv_view + ".jpg";
                    }
                    GettingLocation();
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

        public void GettingLocation()
        {
            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            var uri = new Uri("http://www.rttmc-hubdat.com/webgis/places/json_client_cctv", UriKind.Absolute);

            System.Text.StringBuilder postData = new System.Text.StringBuilder();
            postData.AppendFormat("{0}={1}", "token", "r77mch0bd0t?");

            webClient.Headers[HttpRequestHeader.ContentLength] = postData.Length.ToString();
            webClient.UploadStringCompleted += new UploadStringCompletedEventHandler(webClient_UploadStringCompleted);
            webClient.UploadStringAsync(uri, "POST", postData.ToString());
        }

        void webClient_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            GeoCoordinate geo;
            double lat, lng;
            try
            {
                if (!String.IsNullOrEmpty(e.Result))
                {
                    ListResultOfLocationNews = JsonConvert.DeserializeObject<RootObjectLaluLintas>(e.Result);
                    for(int i=0;i<ListResultOfLocationNews.cctv.Count();i++)
                    {
                        var item = ListResultOfLocationNews.cctv[i];
                        lat = double.Parse(item.latitude, CultureInfo.InvariantCulture);//Convert.ToDouble(item.latitude.ToString());
                        lng = double.Parse(item.longitude, CultureInfo.InvariantCulture);

                        if ((lat < 90 && lat > -90) && (lng < 180 && lng> -180))
                        {
                            geo = new GeoCoordinate(lat, lng);
                            ListLocations.Add(geo);
                            AddMapLayer(geo, Colors.Blue);
                        }
                        
                    }                 
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message.Contains("NotFound")) 
                    MessageBox.Show("Tidak bisa terhubung dengan server. Cobalah beberapa saat lagi");
                else
                    MessageBox.Show("Tidak bisa mendapatkan lokasi dari info lalu lintas");
                this.NavigationService.GoBack();
                //MessageBox.Show(e.Error.Message + "\n" + ex.Message);
            }
        }

        #endregion

        private void Map_OnTap(object sender, GestureEventArgs e)
        {
            Point p1 = e.GetPosition(sender as Map);
            GeoCoordinate gc = (sender as Map).ConvertViewportPointToGeoCoordinate(p1);

            int indx = -1;
            double LatDiff = 0.1;
            double LongDiff = 0.0;
            for (int i = 0; i < ListLocations.Count; i++)
            {
                double currLatDiff = Math.Abs(ListLocations[i].Latitude - gc.Latitude);
                double currLongDiff = Math.Abs(ListLocations[i].Longitude - gc.Longitude);
                if (currLatDiff + currLongDiff < LatDiff + LongDiff)
                {
                    LatDiff = currLatDiff;
                    LongDiff = currLongDiff;
                    indx = i;
                }
            }

            SetPopUp(indx);
        }

        private void SetPopUp(int index)
        {
            if (index != -1)
            {
                var selected = ListResultOfLocationNews.cctv[index];
                xmlItem source = null;
                for (int i = 0; i < ListResultOfDataNews.news.Count(); i++)
                {
                    if (Convert.ToInt32(selected.id_api) == ListResultOfDataNews.news[i].id)
                    {
                        source = ListResultOfDataNews.news[i];
                        break;
                    }
                }

                if (source != null)
                {
                    PopUpNewsLocation.Visibility = Visibility.Visible;
                    puLocation.Text = source.nama_lokasi;
                    puCondition.Text = source.cuaca;
                    puTime.Text = source.last_update;

                    Uri uri = new Uri(source.cctv_view, UriKind.Absolute);
                    ImageSource imgSource = new BitmapImage(uri);
                    puImage.Source = imgSource;
                }
            }
        }

        private void AddMapLayer(GeoCoordinate geo, Color color)
        {
            map1.Layers.Add(new MapLayer()
            {
                new MapOverlay()
                {
                    GeoCoordinate = geo,
                    PositionOrigin = new Point(0.5,0.5),
                    Content = new Ellipse
                    {
                        Fill = new SolidColorBrush(color),
                        Stroke = new SolidColorBrush(Colors.Red),
                        StrokeThickness = 3,
                        Width = 20,
                        Height = 30
                    }
                }
            });
        }

        private void PopupClose_Click(object sender, RoutedEventArgs e)
        {
            this.PopUpNewsLocation.Visibility = Visibility.Collapsed;
        }


    }
}