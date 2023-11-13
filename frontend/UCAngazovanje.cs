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
    public partial class UCAngazovanje : UserControl
    {
        public UCAngazovanje()
        {
            InitializeComponent();

            Communication.Instance.SendRequest(new Request
            {
                Operation = Operation.VratiPredmete
            });

            Response res = Communication.Instance.GetResponse();

            if (res.isSuccessfull)
            {
                cmbPredmeti.DataSource = (List<Predmet>)res.ResponseObj;
            }
            else
            {
                MessageBox.Show("Greska pri vracanju predmeta");
            }
        }

        private void btnPrikaziAngazovanja_Click(object sender, EventArgs e)
        {
            Communication.Instance.SendRequest(new Request
            {
                Operation = Operation.VratiAngazovanja,
                RequestObj = (Predmet)cmbPredmeti.SelectedItem
            });

            Response res = Communication.Instance.GetResponse();

            dgvAngazovanja.DataSource = null;
            dgvAngazovanja.DataSource = (List<Angazovanje>)res.ResponseObj;
        }
    }
}
