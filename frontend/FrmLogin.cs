using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class FrmLogin : Form
    {
        private int brojac = 0;
        public FrmLogin()
        {
            InitializeComponent();

            //povezi se se serverom
            try
            {
                Communication.Instance.Connect();
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom");
            }

            txtEmail.Text = "pera@gmail.com";
            txtPassword.Text = "pera";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Popunite sva polja");
                return;
            }

            RadnikSluzbe radnikSluzbe = new RadnikSluzbe
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            Request request = new Request()
            {
                RequestObj = radnikSluzbe,
                Operation = Operation.Login
            };

            Communication.Instance.SendRequest(request);
            Response response = Communication.Instance.GetResponse();

            if (response?.isSuccessfull == true)
            {
                radnikSluzbe = (RadnikSluzbe)response.ResponseObj;
                MessageBox.Show($"Weclome {radnikSluzbe.Ime} {radnikSluzbe.Prezime}");
                Communication.Instance.UlogovaniKorisnik = radnikSluzbe;
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (++brojac == 3)
                {
                    MessageBox.Show("Iskoristili ste sva 3 pokusaja");
                    Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show($"{response.Message}, preostalo vam je jos {3 - brojac} pokusaja");
                }
            }
        }
    }
}
