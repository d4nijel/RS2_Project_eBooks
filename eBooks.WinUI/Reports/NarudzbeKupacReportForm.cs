using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Reports
{
    public partial class NarudzbeKupacReportForm : Form
    {
        private List<Model.Narudzbe> kupacNarudzbe = new List<Model.Narudzbe>();
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        private readonly APIService _narudzbeStavkeService = new APIService("narudzbastavke");
        private readonly APIService _kupciService = new APIService("kupci");

        private int? _id;
        public NarudzbeKupacReportForm(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void NarudzbeKupacReportForm_Load(object sender, EventArgs e)
        {

            var list = await _narudzbeService.Get<List<Model.Narudzbe>>(null);
            kupacNarudzbe = list.Where(w => w.KupacId == _id && w.Status == true && w.Otkazano == false).ToList();

            var list2 = await _narudzbeStavkeService.Get<List<Model.NarudzbaStavke>>(new Model.Requests.NarudzbeStavkeSearchRequest() { IsKnjigaLoadingEnabled = true });

            List<Model.NarudzbaStavkeReport> listaNarudzbi = new List<Model.NarudzbaStavkeReport>();

            foreach (var item in kupacNarudzbe)
            {
                double p = Convert.ToDouble(list2.Where(w => w.NarudzbaId == item.NarudzbaId).Sum(s => s.Kolicina * s.Knjiga.Cijena));
                double q = p * 1.17f;

                listaNarudzbi.Add(new Model.NarudzbaStavkeReport()
                {
                    BrojNarudzbe = item.BrojNarudzbe,
                    Datum = item.Datum.ToString("dd.MM.yyyy hh:mm"),
                    Iznos = p.ToString("F2"),
                    IznosSaPDV = q.ToString("F2")
                });
            }

            var kupac = await _kupciService.GetById<Model.Kupci>(_id);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsNarudzbeKupac", listaNarudzbi);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Kupac", kupac.Ime + " " + kupac.Prezime));

            this.reportViewer1.RefreshReport();
        }
    }
}
