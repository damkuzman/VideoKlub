using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BibliotekaKlasa
{
    public interface OpstiDomenskiObjekat
    {
        string ime
        {
            get;
        }

        string kljuc
        {
            get;
        }

        string uslovJedan
        {
            get;
        }

        string uslovVise
        {
            get;
        }

        string vrednostiZaAzuriranje
        {
            get;
        }

        string vrednostiZaUbacivanje
        {
            get;
        }

        OpstiDomenskiObjekat napuni(DataRow red);
    }
}
