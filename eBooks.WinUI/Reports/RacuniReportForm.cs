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
    public partial class RacuniReportForm : Form
    {
        private readonly APIService _racuniService = new APIService("racuni");
        private readonly APIService _racunStavkeService = new APIService("racunstavke");
        private int? _id;
        public RacuniReportForm(int? racunId = null)
        {
            InitializeComponent();
            _id = racunId;
        }

        private async void RacuniReportForm_Load(object sender, EventArgs e)
        {

            var racun = await _racuniService.GetById<Model.Racuni>(_id);

            var list = await _racunStavkeService.Get<List<Model.RacunStavke>>(new Model.Requests.RacunStavkeSearchRequest() { IsKnjigaLoadingEnabled = true });
            var racunStavke = list.Where(w => w.RacunId == _id).ToList();

            List<Model.Reports.NarudzbaStavkeReport> listaStavki = new List<Model.Reports.NarudzbaStavkeReport>();

            foreach (var item in racunStavke)
            {
                listaStavki.Add(new Model.Reports.NarudzbaStavkeReport()
                {
                    Kolicina = item.Kolicina,
                    Cijena = item.Cijena,
                    Naziv = item.Knjiga.Naziv,
                    Isbn = item.Knjiga.Isbn,
                    Iznos = item.Kolicina * item.Cijena,
                    IznosPDV = item.Kolicina * item.Cijena * 1.17m
                });
            }

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsRacuni", listaStavki);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojRacuna", racun.BrojRacuna));
            this.reportViewer1.RefreshReport();
        }
    }
}
