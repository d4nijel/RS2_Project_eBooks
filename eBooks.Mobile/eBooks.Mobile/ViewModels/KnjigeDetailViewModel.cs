using eBooks.Mobile.Util;
using eBooks.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBooks.Mobile.ViewModels
{
    public class KnjigeDetailViewModel : BaseViewModel
    {
        public Model.Knjige Knjiga { get; set; }

        decimal _kolicina = 1;

        public KnjigeDetailViewModel()
        {
            NaruciCommand = new Command(Naruci);
        }

        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand NaruciCommand { get; set; }

        private void Naruci()
        {
            if (CartService.Cart.ContainsKey(Knjiga.KnjigaId))
            {
                CartService.Cart.Remove(Knjiga.KnjigaId);
            }

            CartService.Cart.Add(Knjiga.KnjigaId, this);

            Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste dodali proizvod u korpu!", "OK");
        }
    }
}
