using eBooks.Mobile.ViewModels;
using eBooks.Model.Requests;
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
    public partial class KnjigePage : ContentPage
    {
        private KnjigeViewModel model = null;
        public KnjigePage()
        {
            InitializeComponent();
            BindingContext = model = new KnjigeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var item = e.Item as Model.Knjige;

                await Navigation.PushAsync(new KnjigeDetailPage(item));
            }
        }

        private async void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;
            var search = new KnjigeSearchRequest()
            {
                Naziv = keyword,
                IsIzdavacLoadingEnabled = true
            };
            await model.Init(false, search);
        }
    }
}