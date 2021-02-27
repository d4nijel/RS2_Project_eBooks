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
    public partial class frmNarudzbe : Form
    {
        private readonly APIService _narudzbeService = new APIService("narudzbe");
        public frmNarudzbe()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.NarudzbeSearchRequest()
                {
                    BrojNarudzbe = txtBrojNarudzbe.Text
                };

                try
                {
                    var result = await _narudzbeService.Get<List<Model.Narudzbe>>(search);

                    dgvNarudzbe.AutoGenerateColumns = false;
                    dgvNarudzbe.DataSource = result;

                    dgvNarudzbe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgvNarudzbe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgvNarudzbe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvNarudzbe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvNarudzbe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvNarudzbe.CurrentRow != null)
            {
                var id = dgvNarudzbe.SelectedRows[0].Cells[0].Value.ToString();

                frmNarudzbeDetalji frm = new frmNarudzbeDetalji(int.Parse(id));
                frm.Show();
            }

        }

        #region Validacija 
        private void txtBrojNarudzbe_Validating(object sender, CancelEventArgs e)
        {
            if (txtBrojNarudzbe.TextLength > 20)
            {
                errorProvider.SetError(txtBrojNarudzbe, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojNarudzbe, null);
            }
        }
        #endregion
    }
}
