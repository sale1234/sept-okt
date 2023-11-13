using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Response
    {
        public object ResponseObj { get; set; }
        public bool isSuccessfull { get; set; }
        public string Message { get; set; }
    }
}
