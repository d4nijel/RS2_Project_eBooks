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
    public partial class frmUgovori : Form
    {
        private readonly APIService _ugovoriService = new APIService("ugovori");
        public frmUgovori()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.UgovoriSearchRequest()
                {
                    BrojUgovora = txtBrojUgovora.Text
                };

                var ugovori = await _ugovoriService.Get<List<Model.Ugovori>>(search);

                dgvUgovori.AutoGenerateColumns = false;
                dgvUgovori.DataSource = ugovori;

                dgvUgovori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvUgovori.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvUgovori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUgovori.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvUgovori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvUgovori.CurrentRow != null)
            {
                var id = dgvUgovori.SelectedRows[0].Cells[0].Value.ToString();

                frmUgovoriEdit frm = new frmUgovoriEdit(int.Parse(id));
                frm.Show();
            }
        }

        #region Validacija 
        private void txtBrojUgovora_Validating(object sender, CancelEventArgs e)
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
        #endregion
    }
}
