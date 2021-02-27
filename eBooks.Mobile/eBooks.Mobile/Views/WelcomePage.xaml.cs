using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBooks.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void Button_Registracija(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registracija());
        }

        private async void Button_Prijava(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}