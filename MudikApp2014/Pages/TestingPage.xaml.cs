using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Services;
using System.Device.Location;

namespace MudikApp2014.Pages
{
    public partial class TestingPage : PhoneApplicationPage
    {
        public TestingPage()
        {
            InitializeComponent();
            InitiateData();
        }
        private void SearchForTerm(String searchTerm)
        {
            var MyGeocodeQuery = new GeocodeQuery();
            MyGeocodeQuery.SearchTerm = searchTerm;
            MyGeocodeQuery.GeoCoordinate = new GeoCoordinate(-6.9148640, 107.6082420);
            MyGeocodeQuery.QueryCompleted += GeocodeQuery_QueryCompleted;
            MyGeocodeQuery.QueryAsync();
        }

        private void GeocodeQuery_QueryCompleted(object sender, QueryCompletedEventArgs<IList<MapLocation>> e)
        {
            if (e.Error == null)
            {
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

        public void InitiateData()
        {
             WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            var uri = new Uri("http://www.rttmc-hubdat.com/webgis/places/json_client_cctv", UriKind.Absolute);

            System.Text.StringBuilder postData = new System.Text.StringBuilder();
            postData.AppendFormat("{0}={1}", "token", "r77mch0bd0t?");

            webClient.Headers[HttpRequestHeader.ContentLength] = postData.Length.ToString();
            webClient.UploadStringCompleted += new UploadStringCompletedEventHandler(webClient_UploadStringCompleted);
            //webClient.UploadProgressChanged += webClient_UploadProgressChanged;
            webClient.UploadStringAsync(uri, "POST", postData.ToString());

        }

        void webClient_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            string res = e.Result;
        }
    }
}