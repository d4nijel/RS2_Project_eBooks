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
    public partial class frmKolekcijeEdit : Form
    {
        private readonly APIService _kolekcijeService = new APIService("kolekcije");
        private int? _id;

        public frmKolekcijeEdit(int? kolekcijaId = null)
        {
            InitializeComponent();
            _id = kolekcijaId;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void frmKolekcijeEdit_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var kolekcija = await _kolekcijeService.GetById<Model.Kolekcije>(_id);

                txtNaziv.Text = kolekcija.Naziv;
                txtOriginalniNaziv.Text = kolekcija.OriginalniNaziv;
                txtOpis.Text = kolekcija.Opis;
                txtBrojKnjiga.Text = kolekcija.Knjige.Count().ToString();

                dgvKnjige.AutoGenerateColumns = false;
                dgvKnjige.DataSource = kolekcija.Knjige.ToList();

                dgvKnjige.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvKnjige.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgvKnjige.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKnjige.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && _id.HasValue)
            {
                var request = new Model.Requests.KolekcijeUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    OriginalniNaziv = txtOriginalniNaziv.Text,
                    Opis = txtOpis.Text
                };

                await _kolekcijeService.Update<Model.Kolekcije>(_id, request);

                MessageBox.Show("Operacija uspješna!");
                this.Close();
            }
        }

        #region Validacija       
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
