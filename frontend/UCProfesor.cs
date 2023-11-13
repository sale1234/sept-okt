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
    public partial class UCProfesor : UserControl
    {
        List<Angazovanje> angazovanja = new List<Angazovanje>();
        public UCProfesor()
        {
            InitializeComponent();
            Communication.Instance.SendRequest(new Request
            {
                Operation = Operation.VratiPredmete
            });
            Response res = Communication.Instance.GetResponse();

            List<Predmet> predmeti = (List<Predmet>)res.ResponseObj;
            cmbPredmeti.DataSource = predmeti;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodajAngazovanje_Click(object sender, EventArgs e)
        {
            angazovanja.Add(new Angazovanje
            {
                Predmet = (Predmet)cmbPredmeti.SelectedItem,
                TipAngazovanja = txtTipNastave.Text
            });

            dgvAngazovanja.DataSource = null;
            dgvAngazovanja.DataSource = angazovanja;

            dgvAngazovanja.Columns[1].Visible = false;
        }

        //sacuvaj profesora i angazovanje

        private void btnSacuvajAngazovanja_Click(object sender, EventArgs e)
        {
            Profesor p = new Profesor
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
            };

            foreach (Angazovanje angazovanje in angazovanja)
            {
                angazovanje.Profesor = p;
            }

            p.ListaAngazovanja = angazovanja;

            Communication.Instance.SendRequest(new Request
            {
                RequestObj = p,
                Operation = Operation.SacuvajProfesora
            });

            MessageBox.Show("Profesor je dodat");
        }
    }
}
