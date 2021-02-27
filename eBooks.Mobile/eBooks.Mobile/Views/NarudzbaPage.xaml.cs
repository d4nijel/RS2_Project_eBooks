using eBooks.Mobile.Util;
using eBooks.Mobile.ViewModels;
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
    public partial class NarudzbaPage : ContentPage
    {
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        private readonly APIService _narudzbaStavkeService = new APIService("narudzbastavke");

        private NarudzbaViewModel model = null;
        public NarudzbaPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

            decimal iznos = 0;
            if (CartService.Cart.Count > 0)
            {
                zakljuciButton.IsVisible = true;
                otkaziButton.IsVisible = true;

                foreach (var item in model.NarudzbaList)
                {
                    iznos += item.Knjiga.Cijena * item.Kolicina;
                }

                iznosLabel.Text = "Ukupan iznos: " + Math.Round(iznos, 2) + " KM";
            }
        }

        private async void ZakljuciButton_Clicked(object sender, EventArgs e)
        {
            Model.Requests.NarudzbeUpsertRequest request = new Model.Requests.NarudzbeUpsertRequest()
            {
                BrojNarudzbe = Global.aktivnaNarudzba.BrojNarudzbe,
                Datum = Global.aktivnaNarudzba.Datum,
                Status = Global.aktivnaNarudzba.Status,
                KupacId = Global.aktivnaNarudzba.KupacId,
                Otkazano = Global.aktivnaNarudzba.Otkazano
            };

            var narudzba = await _narudzbeService.Insert<Model.Narudzbe>(request);

            var NarudzbeStavke = new List<Model.Requests.NarudzbeStavkeUpsertRequest>();
            foreach (var x in model.NarudzbaList)
            {
                NarudzbeStavke.Add(new Model.Requests.NarudzbeStavkeUpsertRequest()
                {
                    Kolicina = 1,
                    NarudzbaId = narudzba.NarudzbaId,
                    KnjigaId = x.Knjiga.KnjigaId
                });
            }

            foreach (var x in NarudzbeStavke)
            {
                await _narudzbaStavkeService.Insert<Model.NarudzbaStavke>(x);
            }

            await Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste zaključili narudžbu!", "OK");
            CartService.Cart.Clear();
            Global.aktivnaNarudzba = null;
            model.NarudzbaList.Clear();
            zakljuciButton.IsVisible = false;
            iznosLabel.IsVisible = false;
            otkaziButton.IsVisible = false;

            await Navigation.PushAsync(new EPlacanjePage(narudzba.NarudzbaId));
        }
        private async void OtkaziButton_Clicked(object sender, EventArgs e)
        {
            Model.Requests.NarudzbeUpsertRequest request = new Model.Requests.NarudzbeUpsertRequest()
            {
                BrojNarudzbe = Global.aktivnaNarudzba.BrojNarudzbe,
                Datum = Global.aktivnaNarudzba.Datum,
                Status = Global.aktivnaNarudzba.Status,
                KupacId = Global.aktivnaNarudzba.KupacId,
                Otkazano = true
            };

            var narudzba = await _narudzbeService.Insert<Model.Narudzbe>(request);

            var NarudzbeStavke = new List<Model.Requests.NarudzbeStavkeUpsertRequest>();
            foreach (var x in model.NarudzbaList)
            {
                NarudzbeStavke.Add(new Model.Requests.NarudzbeStavkeUpsertRequest()
                {
                    Kolicina = 1,
                    NarudzbaId = narudzba.NarudzbaId,
                    KnjigaId = x.Knjiga.KnjigaId
                });
            }

            foreach (var x in NarudzbeStavke)
            {
                await _narudzbaStavkeService.Insert<Model.NarudzbaStavke>(x);
            }

            await Application.Current.MainPage.DisplayAlert("Uspjeh", "Otkazali ste narudžbu!", "OK");
            CartService.Cart.Clear();
            Global.aktivnaNarudzba = null;
            model.NarudzbaList.Clear();
            zakljuciButton.IsVisible = false;
            otkaziButton.IsVisible = false;
            iznosLabel.IsVisible = false;
        }
    }
}