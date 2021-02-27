using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI.Izdavaci
{
    public partial class frmIzdavaciAdd : Form
    {
        private readonly APIService _izdavaciService = new APIService("izdavaci");
        private readonly APIService _drzaveService = new APIService("drzave");

        public frmIzdavaciAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void frmIzdavaciAdd_Load(object sender, EventArgs e)
        {
            await LoadSjedisteDrzava();
        }

        private async Task LoadSjedisteDrzava()
        {
            var result = await _drzaveService.Get<List<Model.Drzave>>(null);
            result.OrderBy(x => x.Naziv);
            result.Insert(0, new Model.Drzave());

            cbDrzava.DisplayMember = "Naziv";
            cbDrzava.ValueMember = "DrzavaID";
            cbDrzava.DataSource = result;
        }

        private async Task LoadSjedisteGrad()
        {
            int nStoreNumber = Convert.ToInt32(cbDrzava.SelectedValue);

            if (nStoreNumber > 0)
            {
                var list = await _drzaveService.GetById<Model.Drzave>(nStoreNumber);

                var result = list.Gradovi.ToList();
                result.OrderBy(x => x.Naziv);
                result.Insert(0, new Model.Gradovi());

                cbGrad.DisplayMember = "Naziv";
                cbGrad.ValueMember = "GradID";
                cbGrad.DataSource = result;
            }
            else
            {
                var r = new List<Model.Gradovi>();
                r.OrderBy(x => x.Naziv);
                r.Insert(0, new Model.Gradovi());

                cbGrad.DisplayMember = "Naziv";
                cbGrad.ValueMember = "GradID";
                cbGrad.DataSource = r;
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new Model.Requests.IzdavaciUpsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    GodinaOsnivanja = Convert.ToInt32(txtGodinaOsnivanja.Text),
                    KontaktOsoba = txtKontaktOsoba.Text,
                    KontaktTelefon = txtKontaktTelefon.Text,
                    KontaktEmail = txtKontaktEmail.Text,
                    Status = true,
                };

                var idSjediste = cbGrad.SelectedValue;

                if (int.TryParse(idSjediste.ToString(), out int GradId))
                {
                    if (GradId > 0)
                        request.GradId = GradId;
                }

                await _izdavaciService.Insert<Model.Izdavaci>(request);

                MessageBox.Show("Operacija uspješna!");
                this.Close();
            }
        }

        private async void cbDrzava_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadSjedisteGrad();
        }

        #region Validacija
        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
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
        }

        private void txtGodinaOsnivanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGodinaOsnivanja.Text))
            {
                errorProvider.SetError(txtGodinaOsnivanja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (!int.TryParse(txtGodinaOsnivanja.Text, out int parsedValue))
                {
                    errorProvider.SetError(txtGodinaOsnivanja, Properties.Resources.Validation_NumberField);
                    e.Cancel = true;
                }
                else
                {
                    if ((Convert.ToInt32(txtGodinaOsnivanja.Text)) > DateTime.Today.Year || (Convert.ToInt32(txtGodinaOsnivanja.Text)) < 1)
                    {
                        errorProvider.SetError(txtGodinaOsnivanja, Properties.Resources.Validation_RangeUntilCurrentYearAttribute);
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtGodinaOsnivanja, null);
                    }
                }
            }
        }

        private void txtKontaktOsoba_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontaktOsoba.Text))
            {
                errorProvider.SetError(txtKontaktOsoba, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtKontaktOsoba.TextLength > 100)
                {
                    errorProvider.SetError(txtKontaktOsoba, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtKontaktOsoba, null);
                }
            }
        }

        private void txtKontaktTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontaktTelefon.Text))
            {
                errorProvider.SetError(txtKontaktTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtKontaktTelefon.TextLength > 20)
                {
                    errorProvider.SetError(txtKontaktTelefon, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    Regex reg = new Regex(@"(\+[0-9]{3}) (\([0-9]{2}\)) ([0-9]{3})-([0-9]{3})");
                    if (!reg.IsMatch(txtKontaktTelefon.Text))
                    {
                        errorProvider.SetError(txtKontaktTelefon, Properties.Resources.Validation_PhoneNumberFormat);
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtKontaktTelefon, null);
                    }
                }
            }
        }

        private void txtKontaktEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontaktEmail.Text))
            {
                errorProvider.SetError(txtKontaktEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtKontaktEmail.TextLength > 100)
                {
                    errorProvider.SetError(txtKontaktEmail, Properties.Resources.Validation_StringLength);
                    e.Cancel = true;
                }
                else
                {
                    Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                    if (!reg.IsMatch(txtKontaktEmail.Text))
                    {
                        errorProvider.SetError(txtKontaktEmail, Properties.Resources.Validation_EmailFormat);
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtKontaktEmail, null);
                    }
                }
            }
        }

        private void cbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (cbGrad.SelectedIndex == -1 || cbGrad.SelectedIndex == 0)
            {
                errorProvider.SetError(cbGrad, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbGrad, null);
            }
        }
        #endregion
    }
}
