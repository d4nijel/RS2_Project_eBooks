using eBooks.WinUI.Autori;
using eBooks.WinUI.Izdavaci;
using eBooks.WinUI.Kolekcije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Knjige
{
    public partial class frmKnjigeAdd : Form
    {
        private readonly APIService _kategorijeServis = new APIService("kategorije");
        private readonly APIService _knjigeServis = new APIService("knjige");
        private readonly APIService _autoriKnjigeServis = new APIService("autoriknjige");
        private readonly APIService _knjigeKategorije = new APIService("knjigekategorije");

        private Model.Requests.KnjigeUpsertRequest knjiga = new Model.Requests.KnjigeUpsertRequest();
        private Model.Autori OdabraniAutor { get; set; }
        private List<Model.Autori> OdabraniAutori = new List<Model.Autori>();
        public frmKnjigeAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void frmKnjigeAdd_Load(object sender, EventArgs e)
        {
            clbKategorije.DataSource = await _kategorijeServis.Get<List<Model.Kategorije>>(null);
            clbKategorije.DisplayMember = "Naziv";
            clbKategorije.ValueMember = "KategorijaId";
            clbKategorije.ClearSelected();

            txtSifra.Text = await LoadSifraKnjige();
            LoadFormat();
            LoadJezik();
        }

        private async Task<string> LoadSifraKnjige()
        {
            var list = await _knjigeServis.Get<List<Model.Knjige>>(null);

            var id = list.Count() + 1;

            var p0 = 100000;
            var p1 = p0 + id;
            var p2 = DateTime.Now.ToString("dd");
            var p3 = DateTime.Now.ToString("MM");
            var p4 = DateTime.Now.ToString("yy");

            return p1 + p2 + p3 + p4;
        }

        private void LoadFormat()
        {
            cbFormat.Items.Add("PDF");
            cbFormat.Items.Add("EPUB");
            cbFormat.Items.Add("EPUB2");
        }

        private void LoadJezik()
        {
            cbJezik.Items.Add("Engleski");
            cbJezik.Items.Add("Bosanski");
            cbJezik.Items.Add("Hrvatski");
            cbJezik.Items.Add("Srpski");
        }

        private void btnPretragaAutori_Click(object sender, EventArgs e)
        {
            frmAutoriPretraga frm = new frmAutoriPretraga();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtImeAutora.Text = frm.odabraniAutor.Ime;
                txtPrezimeAutora.Text = frm.odabraniAutor.Prezime;
                txtPseudonimAutora.Text = frm.odabraniAutor.Pseudonim;
                OdabraniAutor = frm.odabraniAutor;
            }
        }

        private void btnPretragaIzdavaci_Click(object sender, EventArgs e)
        {
            frmIzdavaciPretraga frm = new frmIzdavaciPretraga();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNazivIzdavaca.Text = frm.odabraniIzdavac.Naziv;
                knjiga.IzdavacId = frm.odabraniIzdavac.IzdavacId;
            }
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            OdabraniAutori.Add(OdabraniAutor);
            dgvOdabraniAutori.AutoGenerateColumns = false;
            dgvOdabraniAutori.DataSource = OdabraniAutori.ToList();
        }

        private void btnPretragaKolekcije_Click(object sender, EventArgs e)
        {
            frmKolekcijePretraga frm = new frmKolekcijePretraga();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNazivKolekcije.Text = frm.odabranaKolekcija.Naziv;
                txtOriginalniNazivKolekcije.Text = frm.odabranaKolekcija.OriginalniNaziv;
                knjiga.KolekcijaId = frm.odabranaKolekcija.KolekcijaId;
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //korisniku omogucavamo da izvrsi selekciju odredjene slike
            {
                string ext = Path.GetExtension(openFileDialog1.FileName);
                if (ext == "jpeg" || ext == ".jpg" || ext == ".png")
                {
                    txtDodavanjeSlike.Text = openFileDialog1.FileName; // putanju do te slike prikazemo u textboxu

                    Image originalImage = Image.FromFile(openFileDialog1.FileName); //tu sliku ucitavamo u Image koristeci path koji je korisnik odabrao

                    Image resizedImage = Util.UIHelper.ResizeImage(originalImage, new Size(Util.UIHelper.resizedImageWidth, Util.UIHelper.resizedImageHight));

                    MemoryStream ms = new MemoryStream(); //kreiramo objekat MemoryStream
                    resizedImage.Save(ms, ImageFormat.Jpeg); //koristimo ga za spasavanje originalne slike u jpeg format unutar objekta ms
                    knjiga.SlikaNaslovnice = ms.ToArray();   //knjiga.NaslovnaSlika=ms.ToArray // iz ms sliku pretvaramo u niz byta

                    if (resizedImage.Width > Util.UIHelper.resizedImageThumbWidth)
                    {
                        Image resizedImageThumb = Util.UIHelper.ResizeImage(originalImage, new Size(Util.UIHelper.resizedImageThumbWidth, Util.UIHelper.resizedImageThumbHight));
                        ms = new MemoryStream();
                        resizedImageThumb.Save(ms, ImageFormat.Jpeg);

                        pbKnjigaNaslovna.Image = resizedImageThumb;
                        knjiga.SlikaNaslovniceThumb = ms.ToArray(); ;
                    }
                }
            }
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string ext = Path.GetExtension(fileName);

                if (ext == ".pdf")
                {
                    txtDodavanjeKnjige.Text = fileName;
                    knjiga.Knjiga = UcitajVratiDokument(fileName);
                }
            }
        }

        private void btnDodajUzorak_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string fileName = openFileDialog1.FileName;
                string ext = Path.GetExtension(fileName);

                if (ext == ".pdf")
                {
                    txtDodavanjeUzorka.Text = fileName;
                    knjiga.UzorakKnjige = UcitajVratiDokument(fileName);
                }
            }
        }

        private byte[] UcitajVratiDokument(string fileName)
        {
            byte[] file;
            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            return file;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                knjiga.Sifra = txtSifra.Text;
                knjiga.OriginalniNaziv = txtOriginalniNazivKnjige.Text;
                knjiga.Naziv = txtNazivKnjige.Text;
                knjiga.Isbn = txtISBN.Text;
                knjiga.GodinaIzdanja = Convert.ToInt32(txtGodinaIzdanja.Text);
                knjiga.BrojStrana = Convert.ToInt32(txtBrojStrana.Text);
                knjiga.Jezik = cbJezik.SelectedItem.ToString();
                knjiga.Sadrzaj = txtSadrzaj.Text;
                knjiga.Izdanje = Convert.ToInt32(txtIzdanje.Text);
                knjiga.Cijena = Convert.ToDecimal(txtCijena.Text);
                knjiga.Format = cbFormat.SelectedItem.ToString();
                knjiga.Status = true;

                var OznaceneKategorije = new List<Model.Kategorije>();

                foreach (Model.Kategorije item in clbKategorije.CheckedItems)
                {
                    OznaceneKategorije.Add(item);
                }

                var DodanaKnjiga = await _knjigeServis.Insert<Model.Knjige>(knjiga);

                var listaAutora = dgvOdabraniAutori.DataSource as List<Model.Autori>;
                var autoriKnjige = new Model.AutoriKnjige();
                foreach (var item in listaAutora)
                {
                    autoriKnjige.AutorId = item.AutorId;
                    autoriKnjige.KnjigaId = DodanaKnjiga.KnjigaId;
                    await _autoriKnjigeServis.Insert<Model.AutoriKnjige>(autoriKnjige);
                }
                var knjigeKategorije = new Model.KnjigeKategorije();
                foreach (var item in OznaceneKategorije)
                {
                    knjigeKategorije.KnjigaId = DodanaKnjiga.KnjigaId;
                    knjigeKategorije.KategorijaId = item.KategorijaId;
                    await _knjigeKategorije.Insert<Model.KnjigeKategorije>(knjigeKategorije);
                }

                MessageBox.Show("Operacija uspješna!");
                this.Close();
            }
        }

        #region Validacija
        private void txtImeAutora_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeAutora.Text) || string.IsNullOrWhiteSpace(txtPrezimeAutora.Text))
            {
                if (string.IsNullOrWhiteSpace(txtPseudonimAutora.Text))
                {
                    errorProvider.SetError(txtImeAutora, Properties.Resources.Validation_AuthorsName);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtImeAutora, null);
                }
            }
            else
            {
                errorProvider.SetError(txtImeAutora, null);
            }
        }

        private void txtNazivKnjige_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivKnjige.Text))
            {
                errorProvider.SetError(txtNazivKnjige, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtNazivKnjige.TextLength > 100)
                {
                    errorProvider.SetError(txtNazivKnjige, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtNazivKnjige, null);
                }
            }
        }

        private void txtOriginalniNazivKnjige_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOriginalniNazivKnjige.Text))
            {
                errorProvider.SetError(txtOriginalniNazivKnjige, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtOriginalniNazivKnjige.TextLength > 100)
                {
                    errorProvider.SetError(txtOriginalniNazivKnjige, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtOriginalniNazivKnjige, null);
                }
            }
        }

        private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSadrzaj.Text))
            {
                errorProvider.SetError(txtSadrzaj, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtSadrzaj.TextLength > 2000)
                {
                    errorProvider.SetError(txtSadrzaj, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtSadrzaj, null);
                }
            }
        }

        private void txtIzdanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzdanje.Text))
            {
                errorProvider.SetError(txtIzdanje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if ((Convert.ToInt32(txtIzdanje.Text)) > 100 || (Convert.ToInt32(txtIzdanje.Text)) < 1)
                {
                    errorProvider.SetError(txtIzdanje, Properties.Resources.Validation_IzdanjeRange);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtIzdanje, null);
                }
            }
        }

        private void txtGodinaIzdanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGodinaIzdanja.Text))
            {
                errorProvider.SetError(txtGodinaIzdanja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if ((Convert.ToInt32(txtGodinaIzdanja.Text)) > DateTime.Today.Year || (Convert.ToInt32(txtGodinaIzdanja.Text)) < 1)
                {
                    errorProvider.SetError(txtGodinaIzdanja, Properties.Resources.Validation_RangeUntilCurrentYearAttribute);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtGodinaIzdanja, null);
                }
            }
        }

        private void cbFormat_Validating(object sender, CancelEventArgs e)
        {
            if (cbFormat.SelectedItem == null)
            {
                errorProvider.SetError(cbFormat, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbFormat, null);
            }
        }

        private void cbJezik_Validating(object sender, CancelEventArgs e)
        {
            if (cbJezik.SelectedItem == null)
            {
                errorProvider.SetError(cbJezik, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbJezik, null);
            }
        }

        private void txtBrojStrana_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojStrana.Text))
            {
                errorProvider.SetError(txtBrojStrana, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if ((Convert.ToInt32(txtBrojStrana.Text)) > 10000 || (Convert.ToInt32(txtBrojStrana.Text)) < 1)
                {
                    errorProvider.SetError(txtBrojStrana, Properties.Resources.Validation_IzdanjeRange);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtBrojStrana, null);
                }
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (txtCijena.Text == "   ,")
            {
                errorProvider.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }

        private void txtNazivIzdavaca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivIzdavaca.Text))
            {
                errorProvider.SetError(txtNazivIzdavaca, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNazivIzdavaca, null);
            }
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                errorProvider.SetError(txtISBN, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                Regex reg = new Regex(@"^(?=[0-9X]{10}$|(?=(?:[0-9]+[- ]){3})[- 0-9X]{13}$|97[89][0-9]{10}$|(?=(?:[0-9]+[- ]){4})[- 0-9]{17}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?[0-9]+[- ]?[0-9]+[- ]?[0-9X]$");
                if (!reg.IsMatch(txtISBN.Text))
                {
                    errorProvider.SetError(txtISBN, Properties.Resources.Validation_ISBN);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtISBN, null);
                }
            }
        }

        private void clbKategorije_Validating(object sender, CancelEventArgs e)
        {
            if (clbKategorije.CheckedIndices.Count == 0)
            {
                errorProvider.SetError(clbKategorije, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(clbKategorije, null);
            }
        }

        private void txtDodavanjeSlike_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDodavanjeSlike.Text))
            {
                errorProvider.SetError(txtDodavanjeSlike, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDodavanjeSlike, null);
            }
        }

        private void txtDodavanjeKnjige_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDodavanjeKnjige.Text))
            {
                errorProvider.SetError(txtDodavanjeKnjige, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDodavanjeKnjige, null);
            }
        }

        private void txtDodavanjeUzorka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDodavanjeUzorka.Text))
            {
                errorProvider.SetError(txtDodavanjeUzorka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDodavanjeUzorka, null);
            }
        }
        #endregion
    }
}
