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

namespace Backend
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Server();
                server.Start();
                MessageBox.Show("Server je pokrenut");
                Thread thread = new Thread(server.HandleClients);
                thread.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Greska pri pokretanju servera");
            }
        }
    }
}
