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
    public partial class frmKolekcijePretraga : Form
    {
        private readonly APIService _kolekcijeService = new APIService("kolekcije");
        public Model.Kolekcije odabranaKolekcija { get; set; }

        public frmKolekcijePretraga()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.KolekcijeSearchRequest()
                {
                    Naziv = txtNaziv.Text,
                    OriginalniNaziv = txtOriginalniNaziv.Text                  
                };

                var kolekcije = await _kolekcijeService.Get<List<Model.Kolekcije>>(search);

                dgvKolekcije.AutoGenerateColumns = false;
                dgvKolekcije.DataSource = kolekcije;

                dgvKolekcije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvKolekcije.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvKolekcije.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKolekcije.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private async void dgvKolekcije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvKolekcije.CurrentRow != null)
            {
                var id = dgvKolekcije.SelectedRows[0].Cells[0].Value.ToString();

                odabranaKolekcija = await _kolekcijeService.GetById<Model.Kolekcije>(id);

                this.DialogResult = DialogResult.OK;
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
