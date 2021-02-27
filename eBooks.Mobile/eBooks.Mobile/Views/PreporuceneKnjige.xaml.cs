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
    public partial class PreporuceneKnjige : ContentPage
    {
        private PreporuceneKnjigeViewModel model = null;
        public PreporuceneKnjige()
        {
            InitializeComponent();
            BindingContext = model = new PreporuceneKnjigeViewModel();
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
    }
}