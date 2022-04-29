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
    public partial class UnitsPage : ContentPage
    {
        public UnitsPage()
        {
            InitializeComponent();
        }

        private void FehToCel_Clicked(object sender, EventArgs e)
        {
            show.Text = UnitConverters.FahrenheitToCelsius(Convert.ToDouble(input1.Text)) + "";
        }

        private void CelToFeh_Clicked(object sender, EventArgs e)
        {
            show.Text = UnitConverters.CelsiusToFahrenheit(Convert.ToDouble(input1.Text)) + "";
        }
    }
}