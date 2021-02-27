using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace eBooks.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _korisniciService = new APIService("korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.KorisniciSearchRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                };

                try
                {
                    var result = await _korisniciService.Get<List<Model.Korisnici>>(search);

                    dgvKorisnici.AutoGenerateColumns = false;
                    dgvKorisnici.DataSource = result;

                    dgvKorisnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgvKorisnici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgvKorisnici.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvKorisnici.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvKorisnici.CurrentRow != null)
            {
                var id = dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString();

                frmKorisniciEdit frm = new frmKorisniciEdit(int.Parse(id));
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
        #endregion
    }
}
