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
    public partial class SMSPage : ContentPage
    {
        public SMSPage()
        {
            InitializeComponent();
        }

        private async void SMSButton_Clicked(object sender, EventArgs e)
        {
            await SendSms(SMSText1.Text, SMSRecipient.Text);
        }
       
        public async Task SendSms(string messageText, string recipient)
        {
            try
            {
                var message = new SmsMessage(messageText, new[] { recipient });
                await Sms.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException ex)
            {
                // DisplayAlert("Error", ex.Message , "Ok");
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}