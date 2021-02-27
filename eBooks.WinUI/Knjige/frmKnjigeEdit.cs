using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Knjige
{
    public partial class frmKnjigeEdit : Form
    {
        private readonly APIService _knjigeServis = new APIService("knjige");
        private readonly APIService _autoriKnjigeServis = new APIService("autoriknjige");
        private readonly APIService _autoriServis = new APIService("autori");
        private readonly APIService _kategorijeService = new APIService("kategorije");
        private int? _id;

        public frmKnjigeEdit(int? knjigaId = null)
        {
            InitializeComponent();
            _id = knjigaId;
        }

        public async Task LoadAutori()
        {
            var list = await _autoriKnjigeServis.Get<List<Model.AutoriKnjige>>(null);
            var listaAutora = list.Where(w => w.KnjigaId == _id).Select(s => s.AutorId).ToList();
            var autori = await _autoriServis.Get<List<Model.Autori>>(null);
            List<Model.Autori> pisci = new List<Model.Autori>();
            foreach (var t in listaAutora)
            {
                pisci.Add(autori.Where(w => w.AutorId == t).FirstOrDefault());
            }

            dgvOdabraniAutori.AutoGenerateColumns = false;
            dgvOdabraniAutori.DataSource = pisci;

            dgvOdabraniAutori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvOdabraniAutori.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvOdabraniAutori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOdabraniAutori.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private async Task LoadKategorije(List<int> kategorije)
        {
            var ListaKategorija = await _kategorijeService.Get<List<Model.Kategorije>>(null);

            clbKategorije.DataSource = ListaKategorija;
            clbKategorije.DisplayMember = "Naziv";
            clbKategorije.ValueMember = "KategorijaID";

            for (int i = 0; i < clbKategorije.Items.Count; i++)
            {
                Model.Kategorije obj = (Model.Kategorije)clbKategorije.Items[i];
                for (int j = 0; j < kategorije.Count; j++)
                {
                    if (obj.KategorijaId == kategorije[j])
                        clbKategorije.SetItemChecked(i, true);
                }
            }
        }

        private async void frmKnjigeEdit_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var knjiga = await _knjigeServis.GetById<Model.Knjige>(_id);

                txtNazivKnjige.Text = knjiga.Naziv;
                txtOriginalniNazivKnjige.Text = knjiga.OriginalniNaziv;
                txtSifra.Text = knjiga.Sifra;
                txtSadrzaj.Text = knjiga.Sadrzaj;
                await LoadAutori();
                txtNazivIzdavaca.Text = knjiga.Izdavac.Naziv;
                txtISBN.Text = knjiga.Isbn;
                txtIzdanje.Text = knjiga.Izdanje.ToString();
                txtFormat.Text = knjiga.Format;
                txtBrojStrana.Text = knjiga.BrojStrana.ToString();
                txtGodinaIzdanja.Text = knjiga.GodinaIzdanja.ToString();
                txtJezik.Text = knjiga.Jezik;
                txtCijena.Text = knjiga.Cijena.ToString();
                txtNazivKolekcije.Text = knjiga.Kolekcija;
                txtOriginalniNazivKolekcije.Text = knjiga.KolekcijaOriginalniNaziv;

                var ms = new MemoryStream(knjiga.SlikaNaslovniceThumb);
                pbKnjigaNaslovna.Image = Image.FromStream(ms);

                var kategorije = knjiga.KnjigeKategorije.Select(s => s.KategorijaId).ToList();
                await LoadKategorije(kategorije);
            }
        }

        private void btnKnjiga_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                frmKnjigeViewer frm = new frmKnjigeViewer(_id);
                frm.Show();
            }
        }
    }
}
