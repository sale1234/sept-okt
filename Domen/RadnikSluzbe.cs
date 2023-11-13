using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class RadnikSluzbe
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }


        public override string ToString()
        {
            return Ime + " " + Prezime;
        }


        public override bool Equals(object obj)
        {
            return ((RadnikSluzbe)obj).Email == Email;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
