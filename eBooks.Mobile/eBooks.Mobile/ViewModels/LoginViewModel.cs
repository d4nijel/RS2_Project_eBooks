using eBooks.Mobile.Navigation;
using eBooks.Mobile.Util;
using eBooks.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBooks.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _kupacService = new APIService("kupci");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;

            try
            {
                var kupac = await _kupacService.GetByUsername<Model.Kupci>(Username);

                if (kupac != null && kupac.LozinkaHash == Util.LoginHelper.GenerateHash(kupac.LozinkaSalt, Password))
                {
                    Global.prijavljeniKupac = kupac;
                    Application.Current.MainPage = new MyPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Neispravno korisničko ime ili lozinka!", "OK");
                    Password = String.Empty;
                    IsBusy = false;
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}
