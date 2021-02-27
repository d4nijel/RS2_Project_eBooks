using eBooks.Mobile.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBooks.Mobile.ViewModels
{
    public class NarudzbaViewModel
    {
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        public ObservableCollection<KnjigeDetailViewModel> NarudzbaList { get; set; } = new ObservableCollection<KnjigeDetailViewModel>();
        public async Task Init()
        {
            NarudzbaList.Clear();
            foreach (var cartValue in CartService.Cart.Values)
            {
                NarudzbaList.Add(cartValue);
            }

            if (Global.aktivnaNarudzba == null)
            {
                Global.aktivnaNarudzba = new Model.Narudzbe();
                Global.aktivnaNarudzba.BrojNarudzbe = await LoadBrojNarudzbe();
                Global.aktivnaNarudzba.Datum = DateTime.Now;
                Global.aktivnaNarudzba.KupacId = Global.prijavljeniKupac.KupacId;
                Global.aktivnaNarudzba.Status = false;
                Global.aktivnaNarudzba.Otkazano = false;
            }
        }

        private async Task<string> LoadBrojNarudzbe()
        {
            var list = await _narudzbeService.Get<List<Model.Narudzbe>>(null);
            var id = list.Count() + 1;

            var p0 = 1000;
            var p1 = p0 + id;
            var p2 = DateTime.Now.ToString("dd");
            var p3 = DateTime.Now.ToString("MM");
            var p4 = DateTime.Now.ToString("yy");

            return p1 + "-" + p2 + "-" + p3 + "-" + p4;
        }
    }
}
