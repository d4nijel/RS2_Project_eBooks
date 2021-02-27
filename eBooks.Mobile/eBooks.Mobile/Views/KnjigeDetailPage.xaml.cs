using eBooks.Mobile.Util;
using eBooks.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBooks.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigeDetailPage : ContentPage
    {
        private readonly APIService _ocjeneService = new APIService("ocjene");

        public List<int> ocjene = new List<int> { 1, 2, 3, 4, 5 };

        private KnjigeDetailViewModel model = null;

        private bool t = false;
        public KnjigeDetailPage(Model.Knjige knjiga)
        {
            InitializeComponent();
            BindingContext = model = new KnjigeDetailViewModel()
            {
                Knjiga = knjiga
            };
        }

        protected async override void OnAppearing()
        {
            string kategorije = "";
            string autori = "";

            foreach (var item in model.Knjiga.Kategorije)
            {
                kategorije += item + ", ";
            }

            foreach (var item in model.Knjiga.Autori)
            {
                autori += item + ", ";
            }

            if (kategorije.Length > 2 && autori.Length > 2)
            {
                kategorije = kategorije.Remove(kategorije.Length - 2);
                autori = autori.Remove(autori.Length - 2);
            }

            kategorijeLabel.Text = String.Format("Kategorija: {0}", kategorije);
            Autori.Text = autori;

            foreach (int x in ocjene)
            {
                ocjenePicker.Items.Add(x.ToString());
            }

            var search = new Model.Requests.OcjeneSearchRequest()
            {
                KupacId = Global.prijavljeniKupac.KupacId,
                KnjigaId = model.Knjiga.KnjigaId
            };

            var o = await _ocjeneService.Get<List<Model.Ocjene>>(search);

            if (o.Count() > 0)
            {
                posljednjaOcjenaLabel.Text = "Vaša ocjena: " + o.Select(s => s.Ocjena).FirstOrDefault().ToString();
            }
            else
            {
                posljednjaOcjenaLabel.Text = "Niste ocijenili knjigu.";
            }

            base.OnAppearing();
        }

        private async void OcjenePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ocjenePicker.SelectedIndex != -1)
            {
                string ocjena = ocjenePicker.Items[ocjenePicker.SelectedIndex];
                var ocjenaKnjige = new Model.Requests.OcjeneUpsertRequest()
                {
                    Datum = DateTime.Now,
                    Ocjena = ocjene[int.Parse(ocjena) - 1],
                    KnjigaId = model.Knjiga.KnjigaId,
                    KupacId = Global.prijavljeniKupac.KupacId
                };
                await _ocjeneService.Insert<Model.Ocjene>(ocjenaKnjige);
                ocjenePicker.IsEnabled = false;
            }
        }

        private void FreePrimjerakButton_Clicked(object sender, EventArgs e)
        {
            int caseSwitch = model.Knjiga.KnjigaId;

            switch (caseSwitch)
            {
                case 1:
                    var url1 = "https://drive.google.com/uc?export=download&id=1Pw-BA7h0FranxIdLr7RvEG70zvMaZMeE";
                    Device.OpenUri(new Uri(url1));
                    break;
                case 2:
                    var url2 = "https://drive.google.com/uc?export=download&id=1lJ1eXLJP3vyLM6xKubJErJOXv0hEf78O";
                    Device.OpenUri(new Uri(url2));
                    break;
                case 3:
                    var url3 = "https://drive.google.com/uc?export=download&id=1KYFht343fKnjuXP3sIk74zja0ksr9Pn3";
                    Device.OpenUri(new Uri(url3));
                    break;
                case 4:
                    var url4 = "https://drive.google.com/uc?export=download&id=1O9atgsJpdX20SjnO4I9lJdAmwGWTzxp8";
                    Device.OpenUri(new Uri(url4));
                    break;
                case 5:
                    var url5 = "https://drive.google.com/uc?export=download&id=1PnM56D1wZjY9vwwQneY7cMd77XAmG--H";
                    Device.OpenUri(new Uri(url5));
                    break;
                case 6:
                    var url6 = "https://drive.google.com/uc?export=download&id=1B9A7or_tqQzqyDRt-A9LWgwo7s_fYzle";
                    Device.OpenUri(new Uri(url6));
                    break;
                case 7:
                    var url7 = "https://drive.google.com/uc?export=download&id=1Q9yLMGR0Y_IzxFqgT74ruOAShnP9mIUK";
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
                    var url = "https://drive.google.com/uc?export=download&id=1Pw-BA7h0FranxIdLr7RvEG70zvMaZMeE";
                    Device.OpenUri(new Uri(url));
                    break;
            }
        }

        private void PrikaziViseBtn_Clicked(object sender, EventArgs e)
        {
            if (!t)
            {
                prikaziViseBtn.Text = "PRIKAŽI MANJE";

                Sadrzaj.ClearValue(Label.LineBreakModeProperty);
                Sadrzaj.ClearValue(Label.MaxLinesProperty);

                t = true;
            }
            else
            {
                prikaziViseBtn.Text = "PRIKAŽI VIŠE";

                Sadrzaj.LineBreakMode = LineBreakMode.WordWrap;
                Sadrzaj.MaxLines = 4;
                t = false;
            }
        }
    }
}