using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Racuni
{
    public partial class frmRacuni : Form
    {
        private readonly APIService _racuniService = new APIService("racuni");
        public frmRacuni()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.RacuniSearchRequest()
                {
                    BrojRacuna = txtBrojRacuna.Text
                };

                try
                {
                    var result = await _racuniService.Get<List<Model.Racuni>>(search);

                    dgvRacuni.AutoGenerateColumns = false;
                    dgvRacuni.DataSource = result;

                    dgvRacuni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgvRacuni.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                    dgvRacuni.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRacuni.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvRacuni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvRacuni.CurrentRow != null)
            {
                var id = dgvRacuni.SelectedRows[0].Cells[0].Value.ToString();

                frmRacuniDetalji frm = new frmRacuniDetalji(int.Parse(id));
                frm.Show();
            }
        }

        #region Validacija 
        private void txtBrojRacuna_Validating(object sender, CancelEventArgs e)
        {
            if (txtBrojRacuna.TextLength > 50)
            {
                errorProvider.SetError(txtBrojRacuna, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojRacuna, null);
            }
        }
        #endregion
    }
}
