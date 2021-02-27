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
    public partial class Registracija : ContentPage
    {
        private readonly APIService _kupciService = new APIService("kupci");
        public Registracija()
        {
            InitializeComponent();
        }
        private async void RegistracijaButton_Clicked(object sender, EventArgs e)
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
                    loadingLabel.IsVisible = true;

                    var kupac = new Model.Requests.KupciUpsertRequest()
                    {
                        Ime = imeInput.Text,
                        Prezime = prezimeInput.Text,
                        Email = emailInput.Text,
                        KorisnickoIme = korisnickoImeInput.Text,
                        Password = lozinkaInput.Text,
                        Status = true,
                        DatumRegistracije = DateTime.Now
                    };

                    var entity = await _kupciService.Insert<Model.Kupci>(kupac);

                    loadingLabel.IsVisible = false;

                    if (entity != null)
                    {
                        await DisplayAlert("Uspjeh", "Uspješno ste se registrovali!", "OK");
                        await this.Navigation.PopAsync();
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