using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backend
{
    public class Server
    {
        private Socket serverSocket;

        public void Start()
        {
            if (serverSocket == null)
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                serverSocket.Listen(5);
            }
        }

        public void HandleClients()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                ClientHandler clientHandler = new ClientHandler(clientSocket);
                Thread clientThread = new Thread(clientHandler.handleClientRequest);
                clientThread.Start();
            }
        }
    }
}
