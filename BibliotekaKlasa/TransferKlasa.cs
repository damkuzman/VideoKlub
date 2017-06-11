using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotekaKlasa
{
    [Serializable]
    public class TransferKlasa
    {
        Object transferObjekat;
        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }

        Object rezultat;

        public Object Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }
        int operacija;
        public int Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
    }

    public enum Operacije
    {
        KrirajClana = 1, ZapamtiClana, VratiSveClanove,IzmeniClana, ObrisiClana, KreirajFilm,ZapamtiFilm,VratiSveFilmove,IzmeniFilm,ObrisiFilm,Login,VratiFilmove,KreirajZaduzenje, SacuvajZaduzenje, VratiZaduzenja, Razduzi
    }
}
