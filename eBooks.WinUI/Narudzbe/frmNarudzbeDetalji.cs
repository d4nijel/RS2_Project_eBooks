using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Narudzbe
{
    public partial class frmNarudzbeDetalji : Form
    {
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        private readonly APIService _narudzbaStavkeService = new APIService("narudzbastavke");
        private int? _id;
        public frmNarudzbeDetalji(int? narudzbaId = null)
        {
            InitializeComponent();
            _id = narudzbaId;
        }

        private async void frmNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var narudzba = await _narudzbeService.GetById<Model.Narudzbe>(_id);

                txtBrojNarudzbe.Text = narudzba.BrojNarudzbe;
                txtDatumNarudzbe.Text = narudzba.Datum.ToString("dd.MM.yyyy");
                cbStatus.Checked = narudzba.Status;
                if (narudzba.Otkazano != null)
                    cbOtkazano.Checked = narudzba.Otkazano.Value;
                else
                    cbOtkazano.Checked = false;

                var stavke = await _narudzbaStavkeService.Get<List<Model.NarudzbaStavke>>((new Model.Requests.NarudzbeStavkeSearchRequest() { IsKnjigaLoadingEnabled = true }));
                var narudzbaStavke = stavke.Where(w => w.NarudzbaId == _id).ToList();

                List<Model.NarudzbeStavkePregled> listaStavki = new List<Model.NarudzbeStavkePregled>();

                foreach (var item in narudzbaStavke)
                {
                    listaStavki.Add(new Model.NarudzbeStavkePregled()
                    {
                        Naziv = item.Knjiga.Naziv,
                        Isbn = item.Knjiga.Isbn,
                        Cijena = item.Knjiga.Cijena
                    });
                }

                dgvNarudzbeStavke.AutoGenerateColumns = false;
                dgvNarudzbeStavke.DataSource = listaStavki;

                dgvNarudzbeStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvNarudzbeStavke.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvNarudzbeStavke.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvNarudzbeStavke.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                double p = Convert.ToDouble(narudzbaStavke.Where(w => w.NarudzbaId == _id).Sum(s => s.Kolicina * s.Knjiga.Cijena));
                double q = p * 1.17f;

                txtIznos.Text = p.ToString("F2");
                txtIznosPDV.Text = q.ToString("F2");
            }
        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            Reports.NarudzbeReportForm frm = new Reports.NarudzbeReportForm(_id);
            frm.Show();
        }
    }
}
