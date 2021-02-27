using eBooks.Model.Requests;
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
    public partial class frmAutoriAdd : Form
    {
        private readonly APIService _autoriService = new APIService("autori");
        private readonly APIService _drzaveService = new APIService("drzave");

        public frmAutoriAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void frmAutoriAdd_Load(object sender, EventArgs e)
        {
            await LoadDrzavaRodjenja();
            await LoadDrzavaSmrti();
        }

        private async Task LoadDrzavaRodjenja()
        {
            var result = await _drzaveService.Get<List<Model.Drzave>>(null);
            result.OrderBy(x => x.Naziv);
            result.Insert(0, new Model.Drzave());

            cbDrzavaRodjenja.DisplayMember = "Naziv";
            cbDrzavaRodjenja.ValueMember = "DrzavaID";
            cbDrzavaRodjenja.DataSource = result;
        }

        private async Task LoadDrzavaSmrti()
        {
            var result = await _drzaveService.Get<List<Model.Drzave>>(null);
            result.OrderBy(x => x.Naziv);
            result.Insert(0, new Model.Drzave());

            cbDrzavaSmrti.DisplayMember = "Naziv";
            cbDrzavaSmrti.ValueMember = "DrzavaID";
            cbDrzavaSmrti.DataSource = result;
        }

        private async Task LoadGradRodjenja()
        {

            int nStoreNumber = Convert.ToInt32(cbDrzavaRodjenja.SelectedValue);

            if (nStoreNumber > 0)
            {
                var list = await _drzaveService.GetById<Model.Drzave>(nStoreNumber);

                var result = list.Gradovi.ToList();
                result.OrderBy(x => x.Naziv);
                result.Insert(0, new Model.Gradovi());

                cbMjestoRodjenja.DisplayMember = "Naziv";
                cbMjestoRodjenja.ValueMember = "GradID";
                cbMjestoRodjenja.DataSource = result;
            }
            else
            {
                var r = new List<Model.Gradovi>();
                r.OrderBy(x => x.Naziv);
                r.Insert(0, new Model.Gradovi());

                cbMjestoRodjenja.DisplayMember = "Naziv";
                cbMjestoRodjenja.ValueMember = "GradID";
                cbMjestoRodjenja.DataSource = r;
            }
        }

        private async Task LoadGradSmrti()
        {
            int nStoreNumber = Convert.ToInt32(cbDrzavaSmrti.SelectedValue);

            if (nStoreNumber > 0)
            {
                var list = await _drzaveService.GetById<Model.Drzave>(nStoreNumber);

                var result = list.Gradovi.ToList();
                result.OrderBy(x => x.Naziv);
                result.Insert(0, new Model.Gradovi());

                cbMjestoSmrti.DisplayMember = "Naziv";
                cbMjestoSmrti.ValueMember = "GradID";
                cbMjestoSmrti.DataSource = result;
            }
            else
            {
                var r = new List<Model.Gradovi>();
                r.OrderBy(x => x.Naziv);
                r.Insert(0, new Model.Gradovi());

                cbMjestoSmrti.DisplayMember = "Naziv";
                cbMjestoSmrti.ValueMember = "GradID";
                cbMjestoSmrti.DataSource = r;
            }
        }

        private void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumRodjenja.Format = DateTimePickerFormat.Short;
        }

        private void dtpDatumSmrti_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumSmrti.Format = DateTimePickerFormat.Short;
        }

        private async void cbDrzavaRodjenja_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadGradRodjenja();
        }

        private async void cbDrzavaSmrti_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadGradSmrti();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new Model.Requests.AutoriUpsertRequest()
                {
                    Ime = string.IsNullOrEmpty(txtIme.Text) ? null : txtIme.Text,
                    Prezime = string.IsNullOrEmpty(txtPrezime.Text) ? null : txtPrezime.Text,
                    Pseudonim = string.IsNullOrEmpty(txtPseudonim.Text) ? null : txtPseudonim.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    DatumSmrti = dtpDatumSmrti.Value,
                    KratkaBiografija = rtbBiografija.Text,
                    Status = true
                };

                if (dtpDatumRodjenja.Format == DateTimePickerFormat.Custom || dtpDatumRodjenja.Checked == false)
                {
                    request.DatumRodjenja = null;
                }

                if (dtpDatumSmrti.Format == DateTimePickerFormat.Custom || dtpDatumSmrti.Checked == false)
                {
                    request.DatumSmrti = null;
                }

                var idMjestoRodjenja = cbMjestoRodjenja.SelectedValue;

                if (idMjestoRodjenja != null)
                {
                    if (int.TryParse(idMjestoRodjenja.ToString(), out int IdGradRodjenja))
                    {
                        if (IdGradRodjenja > 0)
                            request.MjestoRodjenja = IdGradRodjenja;
                    }
                    else
                    {
                        request.MjestoRodjenja = null;
                    }
                }

                var idMjestoSmrti = cbMjestoSmrti.SelectedValue;

                if (idMjestoSmrti != null)
                {
                    if (int.TryParse(idMjestoSmrti.ToString(), out int IdGradSmrti))
                    {
                        if (IdGradSmrti > 0)
                            request.MjestoSmrti = IdGradSmrti;
                    }
                    else
                    {
                        request.MjestoSmrti = null;
                    }
                }

                await _autoriService.Insert<Model.Autori>(request);

                MessageBox.Show("Operacija uspješna!");
                this.Close();
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
                if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
                {
                    if (string.IsNullOrWhiteSpace(txtPseudonim.Text))
                    {
                        errorProvider.SetError(txtIme, Properties.Resources.Validation_AuthorsName);
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtIme, null);
                    }
                }
                else
                {
                    errorProvider.SetError(txtIme, null);
                }
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

        private void rtbBiografija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbBiografija.Text))
            {
                errorProvider.SetError(rtbBiografija, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (rtbBiografija.TextLength > 2000)
                {
                    errorProvider.SetError(rtbBiografija, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(rtbBiografija, null);
                }
            }
        }
        #endregion
    }
}
