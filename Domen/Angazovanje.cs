using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Angazovanje
    {
        public Predmet Predmet { get; set; }
        public Profesor Profesor { get; set; }
        public string TipAngazovanja { get; set; }
    }
}
