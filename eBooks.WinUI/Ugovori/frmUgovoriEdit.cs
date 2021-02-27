using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Ugovori
{
    public partial class frmUgovoriEdit : Form
    {
        private readonly APIService _ugovorService = new APIService("ugovori");
        private readonly APIService _izdavacService = new APIService("izdavaci");
        private readonly APIService _korisnikService = new APIService("korisnici");
        private int? _id;
        public frmUgovoriEdit(int? ugovorId = null)
        {
            InitializeComponent();
            _id = ugovorId;
        }

        private async void frmUgovoriEdit_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var ugovor = await _ugovorService.GetById<Model.Ugovori>(_id);

                txtBrojUgovora.Text = ugovor.BrojUgovora;
                txtDatumPotpisivanja.Text = ugovor.DatumPotpisivanja.ToString("dd.MM.yyyy");
                txtTrajanjeUgovora.Text = ugovor.TrajanjeUgovora.ToString();
                txtProcenat.Text = ugovor.ProcenatOdProdaje.ToString();

                var izdavac = await _izdavacService.GetById<Model.Izdavaci>(ugovor.IzdavacId);
                var korisnik = await _korisnikService.GetById<Model.Korisnici>(ugovor.KorisnikId);

                txtNazivIzdavaca.Text = izdavac.Naziv;
                txtKorisnik.Text = korisnik.Ime + " " + korisnik.Prezime;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPogledajUgovor_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                frmUgovorViewer frm = new frmUgovorViewer(_id);
                frm.Show();
            }
        }
    }
}
