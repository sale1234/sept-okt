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
    public partial class UCSpisakPredmeta : UserControl
    {
        public UCSpisakPredmeta()
        {
            InitializeComponent();

            Communication.Instance.SendRequest(new Request
            {
                Operation = Operation.VratiPredmete
            });
            
            Response res = Communication.Instance.GetResponse();

            dgvSviPredmeti.DataSource = (List<Predmet>)res.ResponseObj;
        }

        private void btnPrikaziMojePredmete_Click(object sender, EventArgs e)
        {
            Communication.Instance.SendRequest(new Request
            {
                Operation = Operation.VratiMojePredmete,
                RequestObj = Communication.Instance.UlogovaniKorisnik
            });

            Response res = Communication.Instance.GetResponse();

            dgvMojiPredmeti.DataSource = null;
            dgvMojiPredmeti.DataSource = (List<Predmet>)res.ResponseObj;
        }
    }
}
