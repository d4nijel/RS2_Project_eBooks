using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBooks.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("korisnici");
        Thread th;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                var request = new Model.Requests.KorisniciSearchRequest()
                {
                    KorisnickoIme = txtUsername.Text
                };

                var list = await _service.Get<List<Model.Korisnici>>(request);

                Global.prijavljeniKorisnik = list.FirstOrDefault();

                this.Close();
                th = new Thread(OpenNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception ex)
            {
            }
            this.Close();
        }

        private void OpenNewForm()
        {
            Application.Run(new frmIndex());
        }
    }
}
