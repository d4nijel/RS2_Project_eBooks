using eBooks.Mobile.Util;
using eBooks.Model;
using eBooks.Model.Requests;
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
    class PreporuceneKnjigeViewModel
    {
        private readonly APIService _knjigeService = new APIService("knjige");
        private readonly APIService _knjigeKategorijeService = new APIService("knjigekategorije");
        private readonly APIService _kategorijeService = new APIService("kategorije");
        private readonly APIService _autoriKnjigeService = new APIService("autoriknjige");
        private readonly APIService _autoriService = new APIService("autori");

        public PreporuceneKnjigeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Knjige> KnjigeList { get; set; } = new ObservableCollection<Knjige>();
        public ICommand InitCommand { get; set; }

        private async Task LoadKategorijeAutore(List<Knjige> list)
        {
            var listaSvihKategorija = await _knjigeKategorijeService.Get<List<Model.KnjigeKategorije>>(null);
            var listaSvihAutora = await _autoriKnjigeService.Get<List<Model.AutoriKnjige>>(null);

            foreach (var item in list)
            {
                var knjigeKategorije = listaSvihKategorija.Where(w => w.KnjigaId == item.KnjigaId).ToList();
                var autoriKnjiga = listaSvihAutora.Where(w => w.KnjigaId == item.KnjigaId).ToList();

                foreach (var x in knjigeKategorije)
                {
                    item.KategorijeID.Add(x.KategorijaId);
                }
                foreach (var x in autoriKnjiga)
                {
                    item.AutoriID.Add(x.AutorId);
                }
                foreach (var y in item.KategorijeID)
                {
                    var k = await _kategorijeService.GetById<Model.Kategorije>(y);
                    item.Kategorije.Add(k.Naziv);
                }
                foreach (var y in item.AutoriID)
                {
                    var a = await _autoriService.GetById<Model.Autori>(y);
                    item.Autori.Add(a.Ime + " " + a.Prezime);
                }
            }
        }

        public async Task Init()
        {
            List<Model.Knjige> list;

            list = await _knjigeService.RecommendProduct<List<Model.Knjige>>(Global.prijavljeniKupac.KupacId);

            await LoadKategorijeAutore(list);

            KnjigeList.Clear();

            foreach (var knjiga in list)
            {
                KnjigeList.Add(knjiga);
            }
        }
    }
}
