using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerI;

namespace KlijentForme.Zaduzenje
{
    public partial class ZaduzenjePrikaz : Form
    {
        public ZaduzenjePrikaz()
        {
            InitializeComponent();
        }

        ZaduzenjeKI zki = new ZaduzenjeKI();
        private void ZaduzenjePrikaz_Load(object sender, EventArgs e)
        {
            zki.povezisesaserverom();
            zki.postaviZaglavljePrikaz(dgPrikaz);
            zki.popuniKombo(cmbClan);
           
        }

        private void cmbClan_SelectedIndexChanged(object sender, EventArgs e)
        {
           zki.popuniGridPrikaz(dgPrikaz,cmbClan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zki.razduzi(dgPrikaz,cmbClan);
        }
    }
}
