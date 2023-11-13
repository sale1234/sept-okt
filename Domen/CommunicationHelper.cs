using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class CommunicationHelper
    {
        private BinaryFormatter formatter;
        private NetworkStream stream;


        public CommunicationHelper(Socket clientSocket)
        {
            this.formatter = new BinaryFormatter();
            this.stream = new NetworkStream(clientSocket);
        }

        public T GetResponse<T>() where T: class
        {
            return (T)formatter.Deserialize(stream);
        }

        public void SendRequest<T>(T obj) where T : class
        {
            formatter.Serialize(stream, obj);
        }


    }
}
