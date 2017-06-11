using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BibliotekaKlasa
{
    [Serializable]
     public class Zaposleni:OpstiDomenskiObjekat
    {
        int zaposleniID;

        public int ZaposleniID
        {
            get { return zaposleniID; }
            set { zaposleniID = value; }
        }

       

        
        string imeiprezime;

        public string Imeiprezime
        {
            get { return imeiprezime; }
            set { imeiprezime = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        #region OpstiDomenskiObjekat Members

        string OpstiDomenskiObjekat.ime
        {
            get { return "Zaposleni"; }
        }

        string OpstiDomenskiObjekat.kljuc
        {
            get { return "ZaposleniID"; }
        }

        string OpstiDomenskiObjekat.uslovJedan
        {
            get { return "ZaposleniID=" + zaposleniID; }
        }

        string OpstiDomenskiObjekat.uslovVise
        {
            get { return "Username='" +username+ "' and Password='"+pass+"'"; }
        }

        string OpstiDomenskiObjekat.vrednostiZaAzuriranje
        {
            get
            {
                return "ZaposleniID = " + zaposleniID + " , ImePrezime='" + imeiprezime + "',Username ='" + username + "',Password ='" + pass + "'";
            }
        }

        string OpstiDomenskiObjekat.vrednostiZaUbacivanje
        {
            get { return "(" + zaposleniID + ",'" + imeiprezime + "','" + username + "','" + pass + "')"; }
        }

        OpstiDomenskiObjekat OpstiDomenskiObjekat.napuni(DataRow red)
        {
            Zaposleni z = new Zaposleni();
            z.zaposleniID = Convert.ToInt32(red["ZaposleniID"]);
            z.imeiprezime = (red["ImePrezime"]).ToString();
            z.username = (red["Username"]).ToString();
            z.pass = (red["Password"]).ToString();
           
            return z;
        }
        #endregion
    }
}
