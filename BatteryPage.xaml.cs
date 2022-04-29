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
    public partial class BatteryPage : ContentPage
    {
        public BatteryPage()
        {
            InitializeComponent();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            var level = e.ChargeLevel;
            var state = e.State;
            var source = e.PowerSource;
            if(level > 0.7)
            {
                Bettary1.Text = level * 100 + "%";
                Bettary1.BackgroundColor = Color.Green;
            }
            else if (level > 0.3)
            {
                Bettary1.Text = level * 100 + "%";
                Bettary1.BackgroundColor = Color.Yellow;
            }           // var level = Battery.ChargeLevel; // returns 0.0 to 1.0 or 1.0 when on AC or no battery.
            else
            {
                Bettary1.Text = level * 100 + "%";
                Bettary1.BackgroundColor = Color.Red;
            }
            // var state = Battery.State;

            switch (state)
            {
                case BatteryState.Charging:
                    // Currently charging
                    break;
                case BatteryState.Full:
                    // Battery is full
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    // Currently discharging battery or not being charged
                    break;
                case BatteryState.NotPresent:
                    // Battery doesn't exist in device (desktop computer)
                    break;
                case BatteryState.Unknown:
                    // Unable to detect battery state
                    break;
            }

          //  source = Battery.PowerSource;

            switch (source)
            {
                case BatteryPowerSource.Battery:
                    // Being powered by the battery
                    break;
                case BatteryPowerSource.AC:
                    // Being powered by A/C unit
                    break;
                case BatteryPowerSource.Usb:
                    // Being powered by USB cable
                    break;
                case BatteryPowerSource.Wireless:
                    // Powered via wireless charging
                    break;
                case BatteryPowerSource.Unknown:
                    // Unable to detect power source
                    break;
            }       
        }
    }
}
