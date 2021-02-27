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

namespace eBooks.WinUI.Korisnici
{
    public partial class frmKorisniciAdd : Form
    {
        private readonly APIService _korisniciService = new APIService("korisnici");
        private readonly APIService _ulogeService = new APIService("uloge");

        public frmKorisniciAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async Task LoadUloge()
        {
            clbUloge.DataSource = await _ulogeService.Get<List<Model.Uloge>>(null);
            clbUloge.DisplayMember = "Naziv";
            clbUloge.ValueMember = "UlogaID";
            clbUloge.ClearSelected();
        }

        private async void frmKorisniciAdd_Load(object sender, EventArgs e)
        {
            await LoadUloge();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    var uloge = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();

                    var request = new Model.Requests.KorisniciUpsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPasswordPotvrda.Text,
                        Uloge = uloge,
                        Status = true
                    };

                    await _korisniciService.Insert<Model.Korisnici>(request);

                    MessageBox.Show("Operacija uspješna!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Niste autorizovani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        #region Validacija     
        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
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
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
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
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (txtEmail.TextLength > 100)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtEmail.Text))
                {
                    errorProvider.SetError(txtEmail, Properties.Resources.Validation_EmailFormat);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtEmail, null);
                }
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefon.TextLength > 20)
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_StringLength);
                e.Cancel = true;
            }
            else
            {
                Regex reg = new Regex(@"(\+[0-9]{3}) (\([0-9]{2}\)) ([0-9]{3})-([0-9]{3})");
                if (!reg.IsMatch(txtTelefon.Text))
                {
                    errorProvider.SetError(txtTelefon, Properties.Resources.Validation_PhoneNumberFormat);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtTelefon, null);
                }
            }
        }

        private async void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            var list = await _korisniciService.Get<List<Model.Korisnici>>(null);
            bool t = new bool();

            foreach (var i in list)
            {
                if (txtKorisnickoIme.Text == i.KorisnickoIme)
                {
                    t = true;
                    break;
                }
            }

            if (t)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_Username);
                e.Cancel = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
                {
                    errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                    e.Cancel = true;
                }
                else
                {
                    if (txtKorisnickoIme.TextLength > 50)
                    {
                        errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_StringLength);
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtKorisnickoIme, null);
                    }
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtPassword.Text.Length > 50 || txtPassword.Text.Length < 4)
                {
                    errorProvider.SetError(txtPassword, Properties.Resources.Validation_PasswordLength);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtPassword, null);
                }
            }
        }

        private void txtPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordPotvrda.Text))
            {
                errorProvider.SetError(txtPasswordPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                if (txtPasswordPotvrda.Text.Length > 50 || txtPasswordPotvrda.Text.Length < 4)
                {
                    errorProvider.SetError(txtPasswordPotvrda, Properties.Resources.Validation_PasswordLength);
                    e.Cancel = true;
                }
                else
                {
                    if (txtPasswordPotvrda.Text != txtPassword.Text)
                    {
                        errorProvider.SetError(txtPasswordPotvrda, Properties.Resources.Validation_PasswordProvjera);
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtPasswordPotvrda, null);
                    }
                }
            }
        }

        private void clbUloge_Validating(object sender, CancelEventArgs e)
        {
            if (clbUloge.CheckedIndices.Count == 0)
            {
                errorProvider.SetError(clbUloge, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(clbUloge, null);
            }
        }
        #endregion
    }
}
