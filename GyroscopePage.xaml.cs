using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XF_Text_to_Speech1
{
    public partial class GyroscopePage : ContentPage
    {
        public GyroscopePage()
        {
            InitializeComponent();
            try
            {
                if (!Gyroscope.IsMonitoring)
                {
                    Gyroscope.ReadingChanged += ReadingChanged;
                    Gyroscope.Start(SensorSpeed.UI);
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
        void ReadingChanged(object sender, GyroscopeChangedEventArgs e)
        {
            var data = e.Reading;
            lblMeasure.Text = $"Reading: X: {data.AngularVelocity.X}, Y: {data.AngularVelocity.Y}, Z: {data.AngularVelocity.Z}";
        }
    }
}