using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XF_Text_to_Speech1
{
    public partial class DetectShakePage : ContentPage
    {
        public DetectShakePage()
        {
            InitializeComponent();

            try
            {
                if (!Accelerometer.IsMonitoring)
                {
                    Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
                    Accelerometer.Start(SensorSpeed.UI);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                lblMeasure.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                lblMeasure.Text = ex.Message;
            }
        }
        void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            DisplayAlert("Shake detected", "You just shaked that thing", "ok");
        }

    }
}