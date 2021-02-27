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
    public partial class frmKupci : Form
    {
        private readonly APIService _kupciService = new APIService("kupci");
        public frmKupci()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.KupciSearchRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text
                };

                try
                {
                    var result = await _kupciService.Get<List<Model.Kupci>>(search);

                    dgvKupci.AutoGenerateColumns = false;
                    dgvKupci.DataSource = result;

                    dgvKupci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgvKupci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgvKupci.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvKupci.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKupci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvKupci.CurrentRow != null)
            {
                var id = dgvKupci.SelectedRows[0].Cells[0].Value.ToString();

                frmKupciDetalji frm = new frmKupciDetalji(int.Parse(id));
                frm.Show();
            }
        }

        #region Validacija 
        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.TextLength > 50)
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrezime.TextLength > 50)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtKorisnickoIme.TextLength > 50)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
        #endregion
    }
}
