using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Text_to_Speech1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KiblahPage : ContentPage
    {
        // Set speed delay for monitoring changes.
        SensorSpeed speed = SensorSpeed.UI;
        public KiblahPage()
        {
            InitializeComponent();
            // Register for reading changes, be sure to unsubscribe when finished
            Compass.ReadingChanged += Compass_ReadingChanged;
        }
        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            // Process Heading Magnetic North
            Display.Text = data.HeadingMagneticNorth + "";

            if (data.HeadingMagneticNorth >= 217 && data.HeadingMagneticNorth <= 218)
            {
                try
                {
                    // Use default vibration length
                    Vibration.Vibrate();
                    Display.BackgroundColor = Color.Green;
                    // Or use specified time
                    var duration = TimeSpan.FromSeconds(1);
                    Vibration.Vibrate(duration);
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Feature not supported on device
                }
                catch (Exception ex)
                {
                    // Other error has occurred.
                }
            }
            else
                Display.BackgroundColor = Color.Red;

            
        }
        private void Kiblah_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Compass.IsMonitoring)
                    Compass.Stop();
                else
                    Compass.Start(speed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Some other exception has occurred
            }
        }
    }
}