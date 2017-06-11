using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BibliotekaKlasa
{
    [Serializable]
    public class Clan:OpstiDomenskiObjekat
    {
        int clanID;
        string ime;
        string prezime;
        string adresa;
        string brojMobilnog;
        string brojLK;

        public string BrojLK
        {
            get { return brojLK; }
            set { brojLK = value; }
        }

        public string BrojMobilnog
        {
            get { return brojMobilnog; }
            set { brojMobilnog = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public int ClanID
        {
            get { return clanID; }
            set { clanID = value; }
        }

        #region OpstiDomenskiObjekat Members

        string OpstiDomenskiObjekat.ime
        {
            get { return "Clan"; }
        }

        string OpstiDomenskiObjekat.kljuc
        {
            get { return "ClanID"; }
        }

        string OpstiDomenskiObjekat.uslovJedan
        {
            get { return "ClanID=" + clanID; }
        }

        string OpstiDomenskiObjekat.uslovVise
        {
            get { return null; }
        }

        string OpstiDomenskiObjekat.vrednostiZaAzuriranje
        {
            get
            {
                return "ClanID = " + clanID + " , Ime='" + ime + "',Prezime='" + prezime + "', Adresa='" + adresa + "',BrojMobilnog='" + brojMobilnog + "',BrojLK='"+brojLK+"'";
            }
        }

        string OpstiDomenskiObjekat.vrednostiZaUbacivanje
        {
            get { return "(" + clanID + ",'" + ime + "','" + prezime + "','" + adresa + "','" + brojMobilnog + "','"+brojLK+"')"; }
        }

        OpstiDomenskiObjekat OpstiDomenskiObjekat.napuni(DataRow red)
        {
            Clan c = new Clan();
            c.ClanID = Convert.ToInt32(red["ClanID"]);
            c.ime = (red["Ime"]).ToString();
            c.prezime = (red["Prezime"]).ToString();
            c.adresa = (red["Adresa"]).ToString();
            c.brojMobilnog = (red["BrojMobilnog"]).ToString();
            c.brojLK = (red["BrojLK"]).ToString();
            return c;
        }
        #endregion
    }
}
