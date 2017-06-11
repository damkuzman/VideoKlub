using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerI;
using BibliotekaKlasa;

namespace KlijentForme.Clan
{
    public partial class ClanUnos : Form
    {
        public ClanUnos()
        {
            InitializeComponent();
        }

        ClanKI ci = new ClanKI();

        private void ClanUnos_Load(object sender, EventArgs e)
        {
            ci.poveziSeSaServerom();

            pocetak();

        }

        private void pocetak() 
        {
            txtAdresa.Clear();
            txtID.Clear();
            txtIme.Clear();
            txtLK.Clear();
            txtMob.Clear();
            txtPrezime.Clear();
            txtIme.Focus();
            ci.kreirajClana(txtID);
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            TransferKlasa tk = ci.zapamtiClana(txtID, txtIme, txtPrezime,txtAdresa, txtMob, txtLK);
            if (tk != null)
            {
                MessageBox.Show("Clan je uspesno ubacen");
                pocetak();
                
            }
            else MessageBox.Show("Clan nije ubacen");
        }

       
    }
}
