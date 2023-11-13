using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sept_okt_vezbanje_1;Integrated Security=True;");
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public List<RadnikSluzbe> VratiSveRadnike()
        {
            List<RadnikSluzbe> radnici = new List<RadnikSluzbe>();
            SqlCommand cmd = new SqlCommand("", connection);

            cmd.CommandText = "select * from radnik";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    RadnikSluzbe r = new RadnikSluzbe
                    {
                        Email = reader.GetString(1),
                        Password = reader.GetString(2),
                        Ime = reader.GetString(3),
                        Prezime = reader.GetString(4),
                    };
                    radnici.Add(r);
                }
            }

            return radnici;
        }

        internal void DodajPredmet(Predmet predmet)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into predmet values(@sifra, @naziv, @espb, @korisnik)";
            command.Parameters.AddWithValue("@sifra", predmet.Sifra);
            command.Parameters.AddWithValue("@naziv", predmet.Naziv);
            command.Parameters.AddWithValue("@espb", predmet.Espb);
            command.Parameters.AddWithValue("@korisnik", predmet.Korisnik);
            command.ExecuteNonQuery();
        }



        internal List<Predmet> VratiPredmete()
        {
            List<Predmet> predmeti = new List<Predmet>();
            SqlCommand cmd = new SqlCommand("", connection);

            cmd.CommandText = "select * from predmet";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    predmeti.Add(new Predmet
                    {
                        PredmetId = reader.GetInt32(0),
                        Sifra = reader.GetString(1),
                        Naziv = reader.GetString(2),
                        Espb = reader.GetInt32(3),
                        Korisnik = reader.GetString(4),
                    });
                }
            }

            return predmeti;
        }

        internal void SacuvajProfesora(Profesor profesor)
        {
            SqlCommand cmd = new SqlCommand("", connection, transaction);

            cmd.CommandText = "insert into profesor values(@ime, @prezime)";
            cmd.Parameters.AddWithValue("@ime", profesor.Ime);
            cmd.Parameters.AddWithValue("@prezime", profesor.Prezime);

            cmd.ExecuteNonQuery();
        }

        internal void SacuvajAngazovanje(Angazovanje angazovanje)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = "insert into angazovanje values (@profesorid, @predmetid, @tipangazovanja)";
            command.Parameters.AddWithValue("@profesorid", angazovanje.Profesor.ProfesorId);
            command.Parameters.AddWithValue("@predmetid", angazovanje.Predmet.PredmetId);
            command.Parameters.AddWithValue("@tipangazovanja", angazovanje.TipAngazovanja);

            command.ExecuteNonQuery();
        }

        internal int GetProfesorMaxId()
        {
            SqlCommand cmd = new SqlCommand("", connection, transaction);
            cmd.CommandText = "select max(profesorid) from profesor";
            object maxId = cmd.ExecuteScalar();

            return (int)maxId;
        }

        internal List<Angazovanje> VratiAngazovanja(Predmet predmet)
        {
            List<Angazovanje> angazovanja = new List<Angazovanje>();

            SqlCommand cmd = new SqlCommand("", connection);
            cmd.CommandText = $"select * from angazovanje a join predmet p on (a.predmetid = p.predmetid) join profesor prof on (prof.profesorid = a.profesorid) where a.predmetid = {predmet.PredmetId}";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    angazovanja.Add(new Angazovanje
                    {
                        Predmet = predmet,
                        Profesor = new Profesor
                        {
                            ProfesorId = reader.GetInt32(0),
                            Ime = reader.GetString(9),
                            Prezime = reader.GetString(9),
                        },
                        TipAngazovanja = reader.GetString(2)
                    });
                }
            }

            return angazovanja;

        }

        internal List<Predmet> VratiMojePredmete(RadnikSluzbe radnik)
        {
            List<Predmet> predmeti = new List<Predmet>();

            SqlCommand cmd = new SqlCommand("", connection);
            //string radnikCred = $"{radnik.Ime} {radnik.Prezime}";
            cmd.CommandText = $"select * from predmet where korisnik like '{radnik}'";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    predmeti.Add(new Predmet
                    {
                        PredmetId = reader.GetInt32(0),
                        Sifra = reader.GetString(1),
                        Naziv = reader.GetString(2),
                        Espb = reader.GetInt32(3),
                        Korisnik = reader.GetString(4),
                    });
                }
            }

            return predmeti;
        }
    }
}
