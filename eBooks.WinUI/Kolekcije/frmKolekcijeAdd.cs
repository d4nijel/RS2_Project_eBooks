using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Kolekcije
{
    public partial class frmKolekcijeAdd : Form
    {
        private readonly APIService _kolekcija = new APIService("kolekcije");

        public frmKolekcijeAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new Model.Requests.KolekcijeUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    OriginalniNaziv = txtOriginalniNaziv.Text,
                    Opis = txtOpis.Text
                };

                await _kolekcija.Insert<Model.Kolekcije>(request);

                MessageBox.Show("Operacija uspješna!");
                this.Close();
            }
        }

        #region Validacija
        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtNaziv.TextLength > 100)
                {
                    errorProvider.SetError(txtNaziv, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtNaziv, null);
                }
            }
        }

        private void txtOriginalniNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOriginalniNaziv.Text))
            {
                errorProvider.SetError(txtOriginalniNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtOriginalniNaziv.TextLength > 100)
                {
                    errorProvider.SetError(txtOriginalniNaziv, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtOriginalniNaziv, null);
                }
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtOpis.TextLength > 2000)
                {
                    errorProvider.SetError(txtOpis, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtOpis, null);
                }
            }
        }
        #endregion

    }
}
