using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XF_Text_to_Speech1
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        } 

         void Speek_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TextToSpeechPage());
        }

        void Barometer_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BarometerPage());
        }
        void DetectShake_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DetectShakePage());
        }
        void Geocoding_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GeocodingPage());
        }

        void Gyroscope_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GyroscopePage());
        }

        void Magnetometer_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MagnetometerPage());
        }
        void SMS_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SMSPage());
        }
       
        void FlashLight_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FlashLightPage());
        }
        void Units_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UnitsPage());
        }

        void Vibrate_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VibratePage());
        }

        void Compass_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CompassPage());
        }
        void Kiblah_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new KiblahPage());
        }
        void Battery_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BatteryPage());
        }
        void Accelerometer_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AccelerometerPage());
        }
        void GeoLocation_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GeoLocationPage());
        }
        void Weather_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new WeatherPage());
        }
        void MySqlDB_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MySqlDBPage());
        }
        void SqlDB_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SqlDBPage());
        }
    }
}
