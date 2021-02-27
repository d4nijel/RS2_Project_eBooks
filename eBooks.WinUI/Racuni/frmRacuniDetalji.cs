using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Racuni
{
    public partial class frmRacuniDetalji : Form
    {
        private readonly APIService _racuniService = new APIService("racuni");
        private readonly APIService _racunStavkeService = new APIService("racunstavke");
        private int? _id;
        public frmRacuniDetalji(int? racunId = null)
        {
            InitializeComponent();
            _id = racunId;
        }

        private async void frmRacuniDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var racun = await _racuniService.GetById<Model.Racuni>(_id);

                txtBrojRacuna.Text = racun.BrojRacuna;
                txtDatumRacuna.Text = racun.Datum.ToString("dd.MM.yyyy");

                var stavke = await _racunStavkeService.Get<List<Model.RacunStavke>>((new Model.Requests.RacunStavkeSearchRequest() { IsKnjigaLoadingEnabled = true }));
                var racunStavke = stavke.Where(w => w.RacunId == _id).ToList();

                List<Model.NarudzbeStavkePregled> listaStavki = new List<Model.NarudzbeStavkePregled>();

                foreach (var item in racunStavke)
                {
                    listaStavki.Add(new Model.NarudzbeStavkePregled()
                    {
                        Naziv = item.Knjiga.Naziv,
                        Isbn = item.Knjiga.Isbn,
                        Cijena = item.Knjiga.Cijena
                    });
                }

                dgvRacunStavke.AutoGenerateColumns = false;
                dgvRacunStavke.DataSource = listaStavki;

                dgvRacunStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvRacunStavke.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvRacunStavke.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRacunStavke.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                double p = Convert.ToDouble(racunStavke.Where(w => w.RacunId == _id).Sum(s => s.Kolicina * s.Cijena));
                double q = p * 1.17f;

                txtIznos.Text = p.ToString("F2");
                txtIznosPDV.Text = q.ToString("F2");
            }
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            Reports.RacuniReportForm frm = new Reports.RacuniReportForm(_id);
            frm.Show();
        }
    }
}
