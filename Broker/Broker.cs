using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using BibliotekaKlasa;

namespace Broker
{

    public class Broker
    {
        OleDbConnection konekcija;
        OleDbTransaction transakcija;


        public void OtvoriKonekciju()
        {
            try
            {
                konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Adamjan\Desktop\Projekti\VideoKlub.accdb");
                konekcija.Open();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri otvaranju konekcije!");
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zatvaranju konekcije!");
            }
        }

        public void ZapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zapocinjanju transakcije!");
            }
        }

        public void PotvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri potvrdjivanju transakcije!");
            }
        }

        public void PonistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri ponistavanju transakcije!");
            }
        }

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }

        public List<OpstiDomenskiObjekat> dajSve(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT *" + " FROM " + odo.ime;
            OleDbDataReader citac = null;
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public List<OpstiDomenskiObjekat> dajSveZaUslov(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT *" + " FROM " + odo.ime + " WHERE " + odo.uslovVise;
            OleDbDataReader citac = null;
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.napuni(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public OpstiDomenskiObjekat dajZaUslov(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT *" + " FROM " + odo.ime + " WHERE " + odo.uslovJedan;
            OleDbDataReader reader = null;
            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public OpstiDomenskiObjekat dajZaUslovVise(OpstiDomenskiObjekat odo)
        {
            string upitniString = "SELECT *" + " FROM " + odo.ime + " WHERE " + odo.uslovVise;
            OleDbDataReader reader = null;
            OleDbCommand komanda = new OleDbCommand(upitniString, konekcija, transakcija);
            try
            {
                reader = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(reader);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.napuni(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public int azuriraj(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.ime + " SET " + odo.vrednostiZaAzuriranje + " WHERE " + odo.uslovJedan;
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int ubaci(OpstiDomenskiObjekat odo)
        {
            string upit = "INSERT INTO " + odo.ime + " VALUES " + odo.vrednostiZaUbacivanje;
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int obrisi(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE *" + " FROM " + odo.ime + " WHERE " + odo.uslovJedan;
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int obrisiSveZaUslov(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE *" + " FROM " + odo.ime + " WHERE " + odo.uslovVise;
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public int dajSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT SlobodnaSifra" + " FROM Sifarnik" + " WHERE NazivTabele = '" + odo.ime + "'";
            OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
            try
            {
                int slobodna = Convert.ToInt32(komanda.ExecuteScalar());
                int nova = slobodna + 1;
                upit = "UPDATE Sifarnik" + " SET SlobodnaSifra = " + nova.ToString() + " WHERE NazivTabele = '" + odo.ime + "'";
                komanda.CommandText = upit;
                komanda.ExecuteNonQuery();
                return slobodna;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

    }
}
