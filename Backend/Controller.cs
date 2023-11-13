using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend
{
    public class Controller
    {
        private static Controller instance;
        private Broker broker;
        public List<RadnikSluzbe> UlogovaniRadnici { get; set; } = new List<RadnikSluzbe>();
        private Controller()
        {
            broker = new Broker();
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }

                return instance;
            }
        }

        public List<RadnikSluzbe> VratiSveRadnike()
        {
            List<RadnikSluzbe> radnici = new List<RadnikSluzbe>();

            try
            {
                broker.OpenConnection();
                radnici = broker.VratiSveRadnike();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                broker.CloseConnection();
            }

            return radnici;
        }

        internal bool DodajPredmet(Predmet predmet)
        {
            try
            {
                broker.OpenConnection();
                broker.DodajPredmet(predmet);

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Predmet> VratiPredmete()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiPredmete();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void SacuvajProfesora(Profesor profesor)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                broker.SacuvajProfesora(profesor);

                foreach (Angazovanje angazovanje in profesor.ListaAngazovanja)
                {
                    angazovanje.Profesor.ProfesorId = broker.GetProfesorMaxId();
                    broker.SacuvajAngazovanje(angazovanje);
                }

                broker.CommitTransaction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                broker.Rollback();
            }
            finally { broker.CloseConnection(); }
        }

        internal List<Angazovanje> VratiAngazovanja(Predmet predmet)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiAngazovanja(predmet);
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return null;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Predmet> VratiMojePredmete(RadnikSluzbe radnik)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiMojePredmete(radnik);
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
