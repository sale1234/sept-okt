using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Predmet
    {
        public int PredmetId { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public int Espb { get; set; }
        public string Korisnik { get; set; }
        public List<Angazovanje> ListaAngazovanja { get; set; }

        public override string ToString()
        {
            return Naziv;
        }

    }
}
