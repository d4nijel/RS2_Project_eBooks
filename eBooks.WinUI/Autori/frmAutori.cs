using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Autori
{
    public partial class frmAutori : Form
    {
        private readonly APIService _autoriService = new APIService("autori");
        public frmAutori()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.AutoriSearchRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Pseudonim = txtPseudonim.Text
                };

                var result = await _autoriService.Get<List<Model.Autori>>(search);

                dgvAutori.AutoGenerateColumns = false;
                dgvAutori.DataSource = result;

                dgvAutori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvAutori.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvAutori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAutori.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvAutori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvAutori.CurrentRow != null)
            {
                var id = dgvAutori.SelectedRows[0].Cells[0].Value.ToString();

                frmAutoriIEdit frm = new frmAutoriIEdit(int.Parse(id));
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

        private void txtPseudonim_Validating(object sender, CancelEventArgs e)
        {
            if (txtPseudonim.TextLength > 50)
            {
                errorProvider.SetError(txtPseudonim, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPseudonim, null);
            }
        }
        #endregion
    }
}
