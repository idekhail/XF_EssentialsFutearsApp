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
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();
        }

        private async void SpeekEn_Clicked(object sender, EventArgs e)
        {
            await SpeakNowDefaultSettingsEn();
        }

        public async Task SpeakNowDefaultSettingsEn()
        {
            await TextToSpeech.SpeakAsync(TextSpeakEn.Text);
        }
    }
}