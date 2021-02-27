using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Knjige
{
    public partial class frmKnjige : Form
    {
        private readonly APIService _knjigeService = new APIService("knjige");
        public frmKnjige()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.KnjigeSearchRequest()
                {
                    Naziv = txtNaziv.Text,
                    OriginalniNaziv = txtOriginalniNaziv.Text
                };

                var knjige = await _knjigeService.Get<List<Model.Knjige>>(search);

                dgvKnjige.AutoGenerateColumns = false;
                dgvKnjige.DataSource = knjige;

                dgvKnjige.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvKnjige.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvKnjige.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKnjige.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void dgvKnjige_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvKnjige.CurrentRow != null)
            {
                var id = dgvKnjige.SelectedRows[0].Cells[0].Value.ToString();

                frmKnjigeEdit frm = new frmKnjigeEdit(int.Parse(id));
                frm.Show();
            }
        }

        #region Validacija
        private void txtNaziv_Validating(object sender, CancelEventArgs e)
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

        private void txtOriginalniNaziv_Validating(object sender, CancelEventArgs e)
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
        #endregion
    }
}
