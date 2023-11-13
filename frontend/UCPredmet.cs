using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class UCPredmet : UserControl
    {
        public UCPredmet()
        {
            InitializeComponent();
            txtKorisnik.Text = Communication.Instance.UlogovaniKorisnik.ToString();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifra.Text) || string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtEpsb.Text))
            {
                MessageBox.Show("Niste uneli sve podatke, probajte ponovo!");
                return;
            }
            if (txtSifra.Text.Length > 10)
            {
                MessageBox.Show("Sifra predmeta ne moze da bude duza od 10 karaktera, pokusajte ponovo!");
                return;
            }
            if (txtNaziv.Text.Length > 100)
            {
                MessageBox.Show("Naziv predmeta ne moze da bude duzi od 100 karaktera, pokusajte ponovo!");
                return;
            }

            int espb = Convert.ToInt32(txtEpsb.Text);
            if (espb < 2 || espb > 10)
            {
                MessageBox.Show("Broj mora biti veci od 2 i manji od 10");
                return;
            }

            Predmet p = new Predmet
            {
                Sifra = txtSifra.Text,
                Naziv = txtNaziv.Text,
                Espb = espb,
                Korisnik = txtKorisnik.Text,
            };

            Request req = new Request
            {
                Operation = Operation.DodajPredmet,
                RequestObj = p
            };

            Communication.Instance.SendRequest(req);

            Response res = Communication.Instance.GetResponse();
            if (res.isSuccessfull)
            {
                MessageBox.Show("Predmet je uspesno dodat");
            } else
            {
                MessageBox.Show(res.Message);
            }
        }
    }
}
