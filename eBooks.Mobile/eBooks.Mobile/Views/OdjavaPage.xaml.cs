using eBooks.Mobile.Util;
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
    public partial class OdjavaPage : ContentPage
    {
        public OdjavaPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Global.prijavljeniKupac = null;
            CartService.Cart.Clear();
            Global.aktivnaNarudzba = null;

            App.Current.MainPage = new NavigationPage(new WelcomePage());
        }
    }
}