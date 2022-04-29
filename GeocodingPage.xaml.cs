using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace XF_Text_to_Speech1
{
    public partial class GeocodingPage : ContentPage
    {
        public GeocodingPage()
        {
            InitializeComponent();
        }
        private async void GetAddress_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                var address = myAddress.Text;
                var locations = await Geocoding.GetLocationsAsync(address);
                var location =  locations?.FirstOrDefault();
                if (location != null)
                {
                    show1.Text = $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";


                    var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                    var cts = new CancellationTokenSource();
                    var currentlocation = await Geolocation.GetLocationAsync(request, cts.Token);

                    if (currentlocation != null)
                    {
                        double cLat = currentlocation.Latitude;
                        double cLog = currentlocation.Longitude;

                        //double buriydahLat = 26.3967;
                        //double buriydahLog = 43.942;
                        double distance = Location.CalculateDistance(location.Latitude, location.Longitude, cLat, cLog, DistanceUnits.Kilometers);

                        show2.Text = $"KM:{distance}";
                    }
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                show1.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                show1.Text = ex.Message;
            }
        }
        public async void GetPlaceMarkData(object sender, System.EventArgs e)
        {
            try
            {                
                var lat = Convert.ToDouble(latit.Text);
                var lon = Convert.ToDouble(longit.Text);
                var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    var geocodeAddress =
                        $"AdminArea:       {placemark.AdminArea}\n" +
                        $"CountryCode:     {placemark.CountryCode}\n" +
                        $"CountryName:     {placemark.CountryName}\n" +
                        $"FeatureName:     {placemark.FeatureName}\n" +
                        $"Locality:        {placemark.Locality}\n" +
                        $"PostalCode:      {placemark.PostalCode}\n" +
                        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                        $"SubLocality:     {placemark.SubLocality}\n" +
                        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                        $"Thoroughfare:    {placemark.Thoroughfare}\n";
                    show2.Text = geocodeAddress;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                show2.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                show2.Text = ex.Message;
            }
        }
    }
}