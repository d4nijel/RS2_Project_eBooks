using eBooks.Mobile.Navigation;
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
    public partial class EPlacanjePage : ContentPage
    {
        private readonly APIService _racuniService = new APIService("racuni");
        private readonly APIService _racunStavkeService = new APIService("racunstavke");
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        private readonly APIService _narudzbaStavkeService = new APIService("narudzbastavke");

        private int _narudzbaID;
        public EPlacanjePage(int narudzbaID)
        {
            InitializeComponent();
            _narudzbaID = narudzbaID;
        }

        protected async override void OnAppearing()
        {
            var search = new Model.Requests.NarudzbeStavkeSearchRequest()
            {
                IsKnjigaLoadingEnabled = true
            };

            var narudzbeStavkeSve = await _narudzbaStavkeService.Get<List<Model.NarudzbaStavke>>(search);
            var narudzbeStavke = narudzbeStavkeSve.Where(w => w.NarudzbaId == _narudzbaID).ToList();
            var naruzdbeStavkeIznos = narudzbeStavke.Sum(s => s.Kolicina * s.Knjiga.Cijena);

            pleaseWait.IsVisible = false;
            iznosTextLabel.IsVisible = true;
            iznoslabel.IsVisible = true;
            iznoslabel.Text = naruzdbeStavkeIznos.ToString("F2") + " KM";
            posaljiButton.IsVisible = true;
            visaImage.IsVisible = true;
            base.OnAppearing();
        }

        private async void PosaljiButton_Clicked(object sender, EventArgs e)
        {
            ValidatingControl[] arr;

            arr = new ValidatingControl[]
            {
                new ValidatingControl(imeInput, "Polje ime ne smije biti prazno!"),
                new ValidatingControl(prezimeInput, "Polje prezime ne smije biti prazno!"),
                new ValidatingControl(brojKarticeInput, "Polje broj kartice ne smije biti prazno!"),
                new ValidatingControl(mjesecInput, "Polje mjesec ne smije biti prazno!"),
                new ValidatingControl(godinaInput, "Polje godina ne smije biti prazno!"),
                new ValidatingControl(cvc2Input, "Polje CVC2 ne smije biti prazno!")
            };

            var errMsgs = ValidatorHelper.Validacija(arr, PageValidating.Registracija);

            if (string.IsNullOrEmpty(errMsgs))
            {
                try
                {
                    loadingLabel.IsVisible = true;

                    var list = await _racuniService.Get<List<Model.Racuni>>(null);
                    var id = list.Count() + 1;

                    var p0 = 1000;
                    var p1 = "RB";
                    var p2 = p0 + id;
                    var p3 = DateTime.Now.ToString("dd");
                    var p4 = DateTime.Now.ToString("MM");
                    var p5 = DateTime.Now.ToString("yy");

                    var p = p1 + "-" + p2 + "-" + p3 + "-" + p4 + "-" + p5;

                    var search = new Model.Requests.NarudzbeStavkeSearchRequest()
                    {
                        IsKnjigaLoadingEnabled = true
                    };

                    var narudzbeStavkeSve = await _narudzbaStavkeService.Get<List<Model.NarudzbaStavke>>(search);
                    var narudzbeStavke = narudzbeStavkeSve.Where(w => w.NarudzbaId == _narudzbaID).ToList();

                    var naruzdbeStavkeIznos = narudzbeStavke.Sum(s => s.Kolicina * s.Knjiga.Cijena);
                    var naruzdbeStavkeIznosPDV = naruzdbeStavkeIznos * 1.17M;

                    var racun = new Model.Requests.RacuniUpsertRequest()
                    {
                        BrojRacuna = p,
                        Datum = DateTime.Now,
                        IznosBezPdv = naruzdbeStavkeIznos,
                        IznosSaPdv = naruzdbeStavkeIznosPDV,
                        NarudzbaId = _narudzbaID
                    };

                    var kreiraniRacun = await _racuniService.Insert<Model.Racuni>(racun);

                    foreach (var x in narudzbeStavke)
                    {
                        var racunStavke = new Model.Requests.RacunStavkeUpsertRequest()
                        {
                            Kolicina = 1,
                            Cijena = x.Knjiga.Cijena,
                            KnjigaId = x.KnjigaId,
                            RacunId = kreiraniRacun.RacunId
                        };

                        await _racunStavkeService.Insert<Model.RacunStavke>(racunStavke);
                    }

                    var narudzba = await _narudzbeService.GetById<Model.Narudzbe>(_narudzbaID);

                    var narudzbaRequest = new Model.Requests.NarudzbeUpsertRequest()
                    {
                        BrojNarudzbe = narudzba.BrojNarudzbe,
                        Datum = narudzba.Datum,
                        Status = true,
                        Otkazano = false,
                        KupacId = narudzba.KupacId
                    };

                    await _narudzbeService.Update<Model.Narudzbe>(_narudzbaID, narudzbaRequest);

                    loadingLabel.IsVisible = false;

                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste izvršili kupovinu!", "OK");


                    var stavke = await _racunStavkeService.Get<List<Model.RacunStavke>>(null);
                    var listaStavki = stavke.Where(w => w.RacunId == kreiraniRacun.RacunId);

                    foreach (var item in listaStavki)
                    {
                        int caseSwitch = item.KnjigaId;

                        switch (caseSwitch)
                        {
                            case 1:
                                var url1 = "https://drive.google.com/uc?export=download&id=1hGOBBZT7iJMTIqFQDNv-Bcl0ucodqqYp";
                                Device.OpenUri(new Uri(url1));
                                break;
                            case 2:
                                var url2 = "https://drive.google.com/uc?export=download&id=1F-D5USE13YIj28UQCQKlubeng7ZrrZfH";
                                Device.OpenUri(new Uri(url2));
                                break;
                            case 3:
                                var url3 = "https://drive.google.com/uc?export=download&id=1lc7wf5eqwcIxafVDRCARlI0bX9C4fLmr";
                                Device.OpenUri(new Uri(url3));
                                break;
                            case 4:
                                var url4 = "https://drive.google.com/uc?export=download&id=1atLr8mD2i2lCegyMkypUq8eVs_-5jAr3";
                                Device.OpenUri(new Uri(url4));
                                break;
                            case 5:
                                var url5 = "https://drive.google.com/uc?export=download&id=1T4zscrl-CXGeJUzionhotYbcT5RBPBRB";
                                Device.OpenUri(new Uri(url5));
                                break;
                            case 6:
                                var url6 = "https://drive.google.com/uc?export=download&id=15VAtMlQ3mgw6_o0LtLBBp-TABzKbdN5W";
                                Device.OpenUri(new Uri(url6));
                                break;
                            case 7:
                                var url7 = "https://drive.google.com/uc?export=download&id=15qoUYn3edL75hs72p211RbUuzqngVy8U";
                                Device.OpenUri(new Uri(url7));
                                break;
                            case 10:
                                var url10 = "https://drive.google.com/uc?export=download&id=12CMP0KtpBSUX5BprcZEzWNrPjwfVu_hp";
                                Device.OpenUri(new Uri(url10));
                                break;
                            case 11:
                                var url11 = "https://drive.google.com/uc?export=download&id=1-5OrP6fOKzGKwtEYV_ZzvOSE7Wup22SO";
                                Device.OpenUri(new Uri(url11));
                                break;
                            default:
                                var url = "https://drive.google.com/uc?export=download&id=1hGOBBZT7iJMTIqFQDNv-Bcl0ucodqqYp	";
                                Device.OpenUri(new Uri(url));
                                break;
                        }
                    }
                    await this.Navigation.PushModalAsync(new MyPage());
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Greška", ex.Message, "OK");
                }
            }
            else
                await DisplayAlert("Greška", errMsgs, "OK");
        }
    }
}