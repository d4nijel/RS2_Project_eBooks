using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Kupci
{
    public partial class frmKupciDetalji : Form
    {
        private readonly APIService _kupciService = new APIService("kupci");
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        private int? _id;
        public frmKupciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }
        private async void frmKupciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var kupac = await _kupciService.GetById<Model.Kupci>(_id);
                var list = await _narudzbeService.Get<List<Model.Narudzbe>>(null);
                var kupacNarudzbe = list.Where(w => w.KupacId == _id && w.Status == true && w.Otkazano == false).ToList();

                txtNarudzbe.Text = kupacNarudzbe.Count().ToString();
                txtOtkazaneNarudzbe.Text = kupacNarudzbe.Where(w => w.Otkazano == true).Count().ToString();

                txtIme.Text = kupac.Ime;
                txtPrezime.Text = kupac.Prezime;
                txtDatumRegistracije.Text = kupac.DatumRegistracije.ToString("dd.MM.yyyy");
                txtEmail.Text = kupac.Email;
                txtKorisnickoIme.Text = kupac.KorisnickoIme;
                cbStatus.Checked = kupac.Status;
            }
        }

        private void btnNarudbe_Click(object sender, EventArgs e)
        {
            Reports.NarudzbeKupacReportForm frm = new Reports.NarudzbeKupacReportForm(_id);
            frm.Show();
        }
    }
}
