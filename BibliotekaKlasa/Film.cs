using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BibliotekaKlasa
{
    [Serializable]
    public class Film:OpstiDomenskiObjekat
    {
        int filmID;
        string naziv;
        string zanr;

        public string Zanr
        {
            get { return zanr; }
            set { zanr = value; }
        }
        string reziser;
        int trajanje;
        int kolicina;
        double cena;
        int izdavackakucaID;

        public int IzdavackakucaID
        {
            get { return izdavackakucaID; }
            set { izdavackakucaID = value; }
        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public int Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }

        public string Reziser
        {
            get { return reziser; }
            set { reziser = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public int FilmID
        {
            get { return filmID; }
            set { filmID = value; }
        }


        #region OpstiDomenskiObjekat Members

        string OpstiDomenskiObjekat.ime
        {
            get { return "Film"; }
        }

        string OpstiDomenskiObjekat.kljuc
        {
            get { return "FilmID"; }
        }

        string OpstiDomenskiObjekat.uslovJedan
        {
            get { return "FilmID=" + filmID; }
        }

        string OpstiDomenskiObjekat.uslovVise
        {
            get { return null; }
        }

        string OpstiDomenskiObjekat.vrednostiZaAzuriranje
        {
            get
            {
                return "FilmID = " + filmID + " , Zanr='" + zanr + "',Naziv='" + naziv + "', Reziser='" + reziser + "',Trajanje=" + trajanje + ",Kolicina=" + kolicina + ", Cena ="+cena+"";
            }
        }

        string OpstiDomenskiObjekat.vrednostiZaUbacivanje
        {
            get { return "(" + filmID + ",'" + zanr + "','" + naziv + "','" + reziser + "'," + trajanje + "," + kolicina + ","+cena+")"; }
        }

        OpstiDomenskiObjekat OpstiDomenskiObjekat.napuni(DataRow red)
        {
            Film f = new Film();
            f.filmID = Convert.ToInt32(red["FilmID"]);
            f.zanr =  (red["Zanr"]).ToString();
            f.naziv = (red["Naziv"]).ToString();
            f.reziser = (red["Reziser"]).ToString();
            f.trajanje = Convert.ToInt32(red["Trajanje"]);
            f.kolicina = Convert.ToInt32(red["Kolicina"]);
            f.cena = Convert.ToInt32(red["Cena"]);

            return f;

        }
        #endregion
    }
}
