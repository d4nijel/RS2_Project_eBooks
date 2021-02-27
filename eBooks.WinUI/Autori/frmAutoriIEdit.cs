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
    public partial class frmAutoriIEdit : Form
    {
        private readonly APIService _autoriService = new APIService("autori");
        private readonly APIService _gradoviService = new APIService("gradovi");
        private readonly APIService _drzaveService = new APIService("drzave");
        private int? _id;

        public frmAutoriIEdit(int? autorId = null)
        {
            InitializeComponent();
            _id = autorId;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void frmAutoriIEdit_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var autor = await _autoriService.GetById<Model.Autori>(_id);

                txtIme.Text = autor.Ime;
                txtPrezime.Text = autor.Prezime;
                txtPseudonim.Text = autor.Pseudonim;

                if (autor.DatumRodjenja.HasValue)
                {
                    dtpDatumRodjenja.Format = DateTimePickerFormat.Short;
                    dtpDatumRodjenja.Checked = true;
                    dtpDatumRodjenja.Value = autor.DatumRodjenja.Value;
                }

                if (autor.DatumSmrti.HasValue)
                {
                    dtpDatumSmrti.Format = DateTimePickerFormat.Short;
                    dtpDatumSmrti.Checked = true;
                    dtpDatumSmrti.Value = autor.DatumSmrti.Value;
                }

                if (autor.MjestoRodjenja.HasValue)
                {
                    Model.Gradovi mjestoRodjenja = await _gradoviService.GetById<Model.Gradovi>(autor.MjestoRodjenja);
                    Model.Drzave drzavaRodjenja = await _drzaveService.GetById<Model.Drzave>(mjestoRodjenja.DrzavaId);

                    await LoadDrzava("drzavaRodjenja", drzavaRodjenja.Naziv);
                    await LoadGrad("gradRodjenja", mjestoRodjenja.Naziv);
                }
                else
                {
                    await LoadDrzava("drzavaRodjenja");
                    await LoadGrad("gradRodjenja");
                }

                if (autor.MjestoSmrti.HasValue)
                {
                    Model.Gradovi mjestoSmrti = await _gradoviService.GetById<Model.Gradovi>(autor.MjestoSmrti);
                    Model.Drzave drzavaSmrti = await _drzaveService.GetById<Model.Drzave>(mjestoSmrti.DrzavaId);

                    await LoadDrzava("drzavaSmrti", drzavaSmrti.Naziv);
                    await LoadGrad("gradSmrti", mjestoSmrti.Naziv);
                }
                else
                {
                    await LoadDrzava("drzavaSmrti");
                    await LoadGrad("gradSmrti");
                }

                rtbBiografija.Text = autor.KratkaBiografija;
                chbStatus.Checked = autor.Status;
            }
        }

        private async Task LoadDrzava(string lokacija, string Drzava = null)
        {
            var result = await _drzaveService.Get<List<Model.Drzave>>(null);
            result.OrderBy(x => x.Naziv);
            result.Insert(0, new Model.Drzave());

            if (lokacija == "drzavaRodjenja")
            {
                cbDrzavaRodjenja.DataSource = result;
                cbDrzavaRodjenja.DisplayMember = "Naziv";
                cbDrzavaRodjenja.ValueMember = "DrzavaID";
                cbDrzavaRodjenja.SelectedItem = Drzava;

                if (Drzava != null)
                {
                    cbDrzavaRodjenja.SelectedIndex = cbDrzavaRodjenja.FindStringExact(Drzava);
                }
            }
            if (lokacija == "drzavaSmrti")
            {
                cbDrzavaSmrti.DataSource = result;
                cbDrzavaSmrti.DisplayMember = "Naziv";
                cbDrzavaSmrti.ValueMember = "DrzavaID";
                cbDrzavaSmrti.SelectedItem = Drzava;

                if (Drzava != null)
                {
                    cbDrzavaSmrti.SelectedIndex = cbDrzavaSmrti.FindStringExact(Drzava);
                }
            }
        }

        private async Task LoadGrad(string lokacija, string Grad = null)
        {
            if (lokacija == "gradRodjenja")
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

                    if (Grad != null)
                    {
                        cbMjestoRodjenja.SelectedIndex = cbMjestoRodjenja.FindStringExact(Grad);
                    }
                }
                else
                {
                    var r = new List<Model.Gradovi>();
                    r.OrderBy(x => x.Naziv);
                    r.Insert(0, new Model.Gradovi());

                    cbMjestoRodjenja.DisplayMember = "Naziv";
                    cbMjestoRodjenja.ValueMember = "GradID";
                    cbMjestoRodjenja.DataSource = r;

                    if (Grad != null)
                    {
                        cbMjestoRodjenja.SelectedIndex = cbMjestoRodjenja.FindStringExact(Grad);
                    }
                }
            }
            if (lokacija == "gradSmrti")
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

                    if (Grad != null)
                    {
                        cbMjestoSmrti.SelectedIndex = cbMjestoSmrti.FindStringExact(Grad);
                    }
                }
                else
                {
                    var r = new List<Model.Gradovi>();
                    r.OrderBy(x => x.Naziv);
                    r.Insert(0, new Model.Gradovi());

                    cbMjestoSmrti.DisplayMember = "Naziv";
                    cbMjestoSmrti.ValueMember = "GradID";
                    cbMjestoSmrti.DataSource = r;

                    if (Grad != null)
                    {
                        cbMjestoSmrti.SelectedIndex = cbMjestoSmrti.FindStringExact(Grad);
                    }
                }
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
            await LoadGrad("gradRodjenja");
        }

        private async void cbDrzavaSmrti_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadGrad("gradSmrti");
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && _id.HasValue)
            {
                var request = new Model.Requests.AutoriUpsertRequest()
                {
                    Ime = string.IsNullOrEmpty(txtIme.Text) ? null : txtIme.Text,
                    Prezime = string.IsNullOrEmpty(txtPrezime.Text) ? null : txtPrezime.Text,
                    Pseudonim = string.IsNullOrEmpty(txtPseudonim.Text) ? null : txtPseudonim.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    DatumSmrti = dtpDatumSmrti.Value,
                    KratkaBiografija = rtbBiografija.Text,
                    Status = chbStatus.Checked
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

                if (int.TryParse(idMjestoRodjenja.ToString(), out int IdGradRodjenja))
                {
                    if (IdGradRodjenja > 0)
                        request.MjestoRodjenja = IdGradRodjenja;
                }
                else
                {
                    request.MjestoRodjenja = null;
                }

                var idMjestoSmrti = cbMjestoSmrti.SelectedValue;

                if (int.TryParse(idMjestoSmrti.ToString(), out int IdGradSmrti))
                {
                    if (IdGradSmrti > 0)
                        request.MjestoSmrti = IdGradSmrti;
                }
                else
                {
                    request.MjestoSmrti = null;
                }

                await _autoriService.Update<Model.Autori>(_id, request);

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
