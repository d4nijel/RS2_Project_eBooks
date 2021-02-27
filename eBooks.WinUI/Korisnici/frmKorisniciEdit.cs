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
    public partial class frmKorisniciEdit : Form
    {
        private readonly APIService _korisniciService = new APIService("korisnici");
        private readonly APIService _ulogeService = new APIService("uloge");
        private int? _id;

        public frmKorisniciEdit(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async Task LoadUloge(List<int> uloge)
        {
            var listaUloga = await _ulogeService.Get<List<Model.Uloge>>(null);

            clbUloge.DataSource = listaUloga;
            clbUloge.DisplayMember = "Naziv";
            clbUloge.ValueMember = "UlogaID";

            for (int i = 0; i < clbUloge.Items.Count; i++)
            {
                Model.Uloge obj = (Model.Uloge)clbUloge.Items[i];
                for (int j = 0; j < uloge.Count; j++)
                {
                    if (obj.UlogaId == uloge[j])
                        clbUloge.SetItemChecked(i, true);
                }
            }
        }

        private async void frmKorisniciEdit_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _korisniciService.GetById<Model.Korisnici>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtTelefon.Text = korisnik.Telefon;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                cbStatus.Checked = korisnik.Status;

                var uloge = korisnik.KorisniciUloge.Select(s => s.UlogaId).ToList();

                await LoadUloge(uloge);
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren() && _id.HasValue)
            {
                try
                {
                    var request = new Model.Requests.KorisniciUpsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPasswordPotvrda.Text,
                        Status = cbStatus.Checked
                    };

                    await _korisniciService.Update<Model.Korisnici>(_id, request);

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
        #endregion
    }

}
