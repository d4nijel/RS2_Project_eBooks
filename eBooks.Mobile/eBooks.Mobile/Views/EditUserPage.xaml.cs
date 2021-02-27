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
    public partial class EditUserPage : ContentPage
    {
        private readonly APIService _kupciService = new APIService("kupci");
        public EditUserPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            imeInput.Text = Global.prijavljeniKupac.Ime;
            prezimeInput.Text = Global.prijavljeniKupac.Prezime;
            datumRegistracijeInput.Text = Global.prijavljeniKupac.DatumRegistracije.ToString("dd.MM.yyyy");
            datumRegistracijeInput.IsEnabled = false;
            emailInput.Text = Global.prijavljeniKupac.Email;
            korisnickoImeInput.Text = Global.prijavljeniKupac.KorisnickoIme;
            korisnickoImeInput.IsEnabled = false;
        }

        private async void SnimiButton_Clicked(object sender, EventArgs e)
        {
            ValidatingControl[] arr;

            arr = new ValidatingControl[]
            {
                new ValidatingControl(imeInput, "Ime ne smije biti prazno!"),
                new ValidatingControl(prezimeInput, "Prezime ne smije biti prazno!"),
                new ValidatingControl(emailInput, "Email mora biti u validnom formatu!"),
                new ValidatingControl(korisnickoImeInput, "Korisničko ime ne smije biti prazno!"),
                new ValidatingControl(lozinkaInput, "Lozinka ne smije biti prazna!")
            };

            var errMsgs = ValidatorHelper.Validacija(arr, PageValidating.Registracija);

            if (string.IsNullOrEmpty(errMsgs))
            {
                try
                {
                    var kupac = new Model.Requests.KupciUpsertRequest()
                    {
                        Ime = imeInput.Text,
                        Prezime = prezimeInput.Text,
                        Email = emailInput.Text,
                        KorisnickoIme = Global.prijavljeniKupac.KorisnickoIme,
                        Password = lozinkaInput.Text,
                        Status = Global.prijavljeniKupac.Status,
                        DatumRegistracije = Global.prijavljeniKupac.DatumRegistracije
                    };

                    var entity = await _kupciService.Update<Model.Kupci>(Global.prijavljeniKupac.KupacId, kupac);

                    if (entity != null)
                    {
                        Global.prijavljeniKupac = entity;
                        await DisplayAlert("Uspjeh", "Uspješno ste se izmijenili podatke!", "OK");
                        await this.Navigation.PushModalAsync(new MyPage());
                    }
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