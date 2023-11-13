using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<Angazovanje> ListaAngazovanja { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
