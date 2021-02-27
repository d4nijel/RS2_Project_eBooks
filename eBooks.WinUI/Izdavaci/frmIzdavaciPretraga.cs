using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Izdavaci
{
    public partial class frmIzdavaciPretraga : Form
    {
        private readonly APIService _izdavaciService = new APIService("izdavaci");
        public Model.Izdavaci odabraniIzdavac { get; set; }

        public frmIzdavaciPretraga()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var search = new Model.Requests.IzdavaciSearchRequest()
                {
                    Naziv = txtNaziv.Text,
                };

                var izdavaci = await _izdavaciService.Get<List<Model.Izdavaci>>(search);

                dgvIzdavaci.AutoGenerateColumns = false;
                dgvIzdavaci.DataSource = izdavaci;

                dgvIzdavaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvIzdavaci.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvIzdavaci.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvIzdavaci.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private async void dgvIzdavaci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvIzdavaci.CurrentRow != null)
            {
                var id = dgvIzdavaci.SelectedRows[0].Cells[0].Value.ToString();

                odabraniIzdavac = await _izdavaciService.GetById<Model.Izdavaci>(id);

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
        #endregion
    }
}
