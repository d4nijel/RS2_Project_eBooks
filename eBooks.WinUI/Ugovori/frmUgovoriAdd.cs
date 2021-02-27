using eBooks.WinUI.Izdavaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Ugovori
{
    public partial class frmUgovoriAdd : Form
    {
        private readonly APIService _ugovorService = new APIService("ugovori");
        private Model.Requests.UgovoriUpsertRequest ugovor = new Model.Requests.UgovoriUpsertRequest();

        public frmUgovoriAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void frmUgovoriAdd_Load(object sender, EventArgs e)
        {
            txtBrojUgovora.Text = await LoadBrojUgovora();
        }

        private async Task<string> LoadBrojUgovora()
        {
            var list = await _ugovorService.Get<List<Model.Ugovori>>(null);

            var brojUgovora = list.Where(w => w.DatumPotpisivanja.Month == DateTime.Now.Month).Count() + 1;

            string p0 = brojUgovora.ToString();

            if (brojUgovora < 99)
            {
                if (brojUgovora < 10)
                {
                    p0 = "00" + p0;
                }
                else
                {
                    p0 = "0" + p0;
                }
            }

            var p1 = DateTime.Now.ToString("MM");
            var p2 = DateTime.Now.ToString("yy");

            return p0 + "-" + p1 + "-" + p2;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                ugovor.BrojUgovora = txtBrojUgovora.Text;
                ugovor.DatumPotpisivanja = dtpDatumPotpisivanja.Value;
                ugovor.TrajanjeUgovora = Convert.ToInt32(txtTrajanjeUgovora.Text);
                ugovor.ProcenatOdProdaje = Convert.ToDecimal(txtProcenat.Text);
                ugovor.KorisnikId = Global.prijavljeniKorisnik.KorisnikId;

                await _ugovorService.Insert<Model.Ugovori>(ugovor);

                MessageBox.Show("Operacija uspješna!");
                this.Close();
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

        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string ext = Path.GetExtension(fileName);

                if (ext == ".pdf")
                {
                    txtUgovor.Text = fileName;
                    ugovor.Ugovor = UcitajVratiDokument(fileName);
                }
            }
        }

        private void btnPretragaIzdavaci_Click(object sender, EventArgs e)
        {
            frmIzdavaciPretraga frm = new frmIzdavaciPretraga();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNazivIzdavaca.Text = frm.odabraniIzdavac.Naziv;
                ugovor.IzdavacId = frm.odabraniIzdavac.IzdavacId;
            }
        }

        #region Validacija
        private void txtBrojUgovora_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojUgovora.Text))
            {
                errorProvider.SetError(txtBrojUgovora, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtBrojUgovora.TextLength > 15)
                {
                    errorProvider.SetError(txtBrojUgovora, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtBrojUgovora, null);
                }
            }
        }

        private void txtTrajanjeUgovora_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrajanjeUgovora.Text))
            {
                errorProvider.SetError(txtTrajanjeUgovora, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (Convert.ToInt32(txtTrajanjeUgovora.Text) > 120 || Convert.ToInt32(txtTrajanjeUgovora.Text) < 1)
                {
                    errorProvider.SetError(txtTrajanjeUgovora, Properties.Resources.Validation_IzdanjeRange);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtTrajanjeUgovora, null);
                }
            }
        }

        private void txtProcenat_Validating(object sender, CancelEventArgs e)
        {
            if (txtProcenat.Text == "   ,")
            {
                errorProvider.SetError(txtProcenat, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (Convert.ToDecimal(txtProcenat.Text) > 100)
                {
                    errorProvider.SetError(txtProcenat, Properties.Resources.Validation_IzdanjeRange);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtProcenat, null);
                }
            }

        }

        private void txtUgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUgovor.Text))
            {
                errorProvider.SetError(txtUgovor, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUgovor, null);
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
        #endregion
    }
}
