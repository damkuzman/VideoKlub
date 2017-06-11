using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BibliotekaKlasa
{
    [Serializable]
    public class StavkaZaduzenja:OpstiDomenskiObjekat
    {
        int rBr;
        int zaduzenjeID;
        int filmID;

        public int FilmID
        {
            get { return filmID; }
            set { filmID = value; }
        }

        public int ZaduzenjeID
        {
            get { return zaduzenjeID; }
            set { zaduzenjeID = value; }
        }

        public int RBr
        {
            get { return rBr; }
            set { rBr = value; }
        }

        #region OpstiDomenskiObjekat Members

        string OpstiDomenskiObjekat.ime
        {
            get { return "StavkaZaduzenja"; }
        }

        string OpstiDomenskiObjekat.kljuc
        {
            get { return null; }
        }

        string OpstiDomenskiObjekat.uslovJedan
        {
            get { return "RBR="+rBr+" and ZaduzenjeID"+ zaduzenjeID; }
        }

        string OpstiDomenskiObjekat.uslovVise
        {
            get { return null; }
        }

        string OpstiDomenskiObjekat.vrednostiZaAzuriranje
        {
            get
            {
                return "RBR="+rBr+"ZaduzenjeID = " + zaduzenjeID + " , FilmID= " + filmID + " ";
            }
        }

        string OpstiDomenskiObjekat.vrednostiZaUbacivanje
        {
            get { return "(" + rBr + "," + zaduzenjeID + "," + filmID + ")"; }
        }

        OpstiDomenskiObjekat OpstiDomenskiObjekat.napuni(DataRow red)
        {
            StavkaZaduzenja sz = new StavkaZaduzenja();
            sz.ZaduzenjeID = Convert.ToInt32(red["ZaduzenjeID"]);
            sz.rBr = Convert.ToInt32(red["RBR"]);
            sz.filmID = Convert.ToInt32(red["FilmID"]);
          

            return sz;

        }
        #endregion
    }
}
