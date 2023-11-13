using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace frontend
{
    public class Communication
    {
        public RadnikSluzbe UlogovaniKorisnik { get; set; }

        private static Communication _instance;
        private Socket socket;
        private CommunicationHelper helper;

        private Communication()
        {

        }

        public static Communication Instance
        {
            get
            {
                if (_instance == null) {
                    _instance = new Communication(); 
                }
                return _instance;
            }
        }


        internal void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.01", 9999);

            helper = new CommunicationHelper(socket);
        }

        internal Response GetResponse()
        {
            return helper.GetResponse<Response>();
        }

        internal void SendRequest(Request request)
        {
            helper.SendRequest(request);
        }

    }
}
