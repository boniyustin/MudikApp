using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Device.Location;
using Microsoft.Phone.Maps.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using MudikApp2014.Classes;
using Microsoft.Phone.Maps.Services;
using System.Windows.Input;

namespace MudikApp2014.Pages
{
    public partial class LocationMapPage : PhoneApplicationPage
    {
        public LocationMapPage()
        {
            InitializeComponent();
            geoQ = new RouteQuery();
            geoQ.QueryCompleted += geoQ_QueryCompleted;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (this.NavigationContext.QueryString.ContainsKey("Title"))
            {
                PlaceName.Text = this.NavigationContext.QueryString["Title"];
                GetRoute(TransitionData.current_location, TransitionData.place_location);
                AddMapLayer(TransitionData.current_location, Colors.Green);
                AddMapLayer(TransitionData.place_location, Colors.Blue);
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
            

            map1.Center = geo;
        }

        #region GetRoute
        private List<GeoCoordinate> _resultOfPoint;
        private RouteQuery geoQ;
        private MapRoute LastRutte = null;

        private void GetRoute(GeoCoordinate start, GeoCoordinate finish)
        {
            _resultOfPoint = new List<GeoCoordinate>();
            _resultOfPoint.Add(start);
            _resultOfPoint.Add(finish);

            // Check
            if (geoQ.IsBusy == true)
            {
                geoQ.CancelAsync();
            }

            geoQ.RouteOptimization = RouteOptimization.MinimizeDistance;
            geoQ.TravelMode = TravelMode.Driving;
            geoQ.Waypoints = _resultOfPoint;
            geoQ.QueryAsync();
        }


        void geoQ_QueryCompleted(object sender, QueryCompletedEventArgs<Microsoft.Phone.Maps.Services.Route> e)
        {

            if (LastRutte != null)
            {
                map1.RemoveRoute(LastRutte);
                LastRutte = null;
            }

            try
            {
                Microsoft.Phone.Maps.Services.Route myRutte = e.Result;
                LastRutte = new MapRoute(myRutte);

                map1.AddRoute(LastRutte);
                map1.SetView(e.Result.BoundingBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        private void Map_OnTap(object sender, GestureEventArgs e)
        {
            //Pushpin 
            //var point = e.GetPosition(sender as Map);
            Point p1 = e.GetPosition(sender as Map);
            GeoCoordinate gc = (sender as Map).ConvertViewportPointToGeoCoordinate(p1);
            //var coordinate = Map.ConvertViewportPointToGeoCoordinate(point);

            //int elements = map1.GetMapElementsAt(p1).Count;
            //System.Diagnostics.Debug.WriteLine(string.Format("Hit {0} map element(s)", elements));
        }
        
    }
}