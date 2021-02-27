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
    public partial class NarudzbeReportForm : Form
    {
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        private readonly APIService _narudzbeStavkeService = new APIService("narudzbastavke");
        private int? _id;
        public NarudzbeReportForm(int? narudzbaId = null)
        {
            InitializeComponent();
            _id = narudzbaId;
        }

        private async void NarudzbeReportForm_Load(object sender, EventArgs e)
        {

            var narudzba = await _narudzbeService.GetById<Model.Narudzbe>(_id);

            var list = await _narudzbeStavkeService.Get<List<Model.NarudzbaStavke>>(new Model.Requests.NarudzbeStavkeSearchRequest() { IsKnjigaLoadingEnabled = true });
            var narudzbeStavke = list.Where(w => w.NarudzbaId == _id).ToList();

            List<Model.Reports.NarudzbaStavkeReport> listaStavki = new List<Model.Reports.NarudzbaStavkeReport>();

            foreach (var item in narudzbeStavke)
            {
                listaStavki.Add(new Model.Reports.NarudzbaStavkeReport()
                {
                    Kolicina = item.Kolicina,
                    Cijena = item.Knjiga.Cijena,
                    Naziv = item.Knjiga.Naziv,
                    Isbn = item.Knjiga.Isbn,
                    Iznos = item.Kolicina * item.Knjiga.Cijena,
                    IznosPDV = item.Kolicina * item.Knjiga.Cijena * 1.17m
                });
            }

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsNarudzbe", listaStavki);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojNarudzbe", narudzba.BrojNarudzbe));
            this.reportViewer1.RefreshReport();
        }
    }
}
