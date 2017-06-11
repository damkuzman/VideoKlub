using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BibliotekaKlasa
{
    [Serializable]
    public class Zaduzenje:OpstiDomenskiObjekat
    {
        int zaduzenjeID;
        int clanID;
        int ukIznos;
        bool zaduzen;

        public bool Zaduzen
        {
            get { return zaduzen; }
            set { zaduzen = value; }
        }

        public int UkIznos
        {
            get { return ukIznos; }
            set { ukIznos = value; }
        }
        DateTime datumZaduzenja;
        DateTime datumRazduzenja;
        

        

        public DateTime DatumRazduzenja
        {
            get { return datumRazduzenja; }
            set { datumRazduzenja = value; }
        }

        public DateTime DatumZaduzenja
        {
            get { return datumZaduzenja; }
            set { datumZaduzenja = value; }
        }

        

        public int ClanID
        {
            get { return clanID; }
            set { clanID = value; }
        }

        public int ZaduzenjeID
        {
            get { return zaduzenjeID; }
            set { zaduzenjeID = value; }
        }

        List<StavkaZaduzenja> listaStavki;

        public List<StavkaZaduzenja> ListaStavki
        {
            get { return listaStavki; }
            set { listaStavki = value; }
        }

        public Zaduzenje() 
        {
            listaStavki = new List<StavkaZaduzenja>();
        }

        #region OpstiDomenskiObjekat Members

        string OpstiDomenskiObjekat.ime
        {
            get { return "Zaduzenje"; }
        }

        string OpstiDomenskiObjekat.kljuc
        {
            get { return "ZaduzenjeID"; }
        }

        string OpstiDomenskiObjekat.uslovJedan
        {
            get { return "ZaduzenjeID=" + zaduzenjeID; }
        }

        string OpstiDomenskiObjekat.uslovVise
        {
            get { return "ClanID= " + clanID +" and Zaduzen= true"; }
        }

        string OpstiDomenskiObjekat.vrednostiZaAzuriranje
        {
            get
            {
                return "ZaduzenjeID = " + zaduzenjeID + " , ClanID= " + clanID + ", DatumZaduzenja =#" + datumZaduzenja + "#,DatumRazduzenja=#" + datumRazduzenja + "#,UkupanIznos="+ukIznos+",Zaduzen="+zaduzen+ "";
            }
        }

        string OpstiDomenskiObjekat.vrednostiZaUbacivanje
        {
            get { return "(" + zaduzenjeID + "," + clanID + ",#" + datumZaduzenja + "#,#" + datumRazduzenja + "#," +ukIznos + ","+zaduzen+")"; }
        }

        OpstiDomenskiObjekat OpstiDomenskiObjekat.napuni(DataRow red)
        {
            Zaduzenje z = new Zaduzenje();
            z.ZaduzenjeID = Convert.ToInt32(red["ZaduzenjeID"]);
            z.clanID = Convert.ToInt32(red["ClanID"]);
            z.datumZaduzenja = Convert.ToDateTime(red["DatumZaduzenja"]);
            z.datumRazduzenja = Convert.ToDateTime(red["DatumRazduzenja"]);
            z.ukIznos= Convert.ToInt32(red["UkupanIznos"]);
            z.zaduzen = Convert.ToBoolean(red["Zaduzen"]);

            return z;

        }
        #endregion
    }
}
