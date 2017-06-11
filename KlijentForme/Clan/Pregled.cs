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
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();
        }

        ClanKI ci = new ClanKI();
        private void Pregled_Load(object sender, EventArgs e)
        {
            ci.poveziSeSaServerom();

            ci.napuniKombo(cmbClan);
        }

        private void cmbClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ci.popuniPolja(cmbClan, txtIme, txtPrezime, txtAdresa, txtMob, txtLK);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
           TransferKlasa tk= ci.izmeniClana(cmbClan, txtIme, txtPrezime, txtAdresa, txtMob, txtLK);

           if (tk != null) MessageBox.Show("Uspesno ste uneli izmenu!");
           else MessageBox.Show("Izmena nije unesena!");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            TransferKlasa tk = ci.obrisiClana(cmbClan);

            if (tk != null) MessageBox.Show("Uspesno ste obrisali clana!");
            else MessageBox.Show("Clan nije obrisan!");
            ci.napuniKombo(cmbClan);
        }
    }
}
