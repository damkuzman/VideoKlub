using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotekaKlasa;


namespace KlijentForme
{
    public partial class PocetnaForma : Form
    {
        BibliotekaKlasa.Zaposleni z;
        
        public PocetnaForma(BibliotekaKlasa.Zaposleni z)
        {
            this.z = z;
            InitializeComponent();

        }
        Clan.ClanUnos cu = new Clan.ClanUnos();
        Clan.Pregled cp = new Clan.Pregled();
        private void unosClanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cu.ShowDialog();
        }
        
        private void pregledIIzmenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cp.ShowDialog();
        }
        Film.FilmUnos fu = new Film.FilmUnos();
        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fu.ShowDialog();
        }
        Film.FilmPrikaz fp = new Film.FilmPrikaz();
        private void pregledIIzmenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fp.ShowDialog();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = "Dobro dosli na posao " + z.Imeiprezime;
        }

        private void unosZaduzenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaduzenje.ZaduzenjeUnos zu = new Zaduzenje.ZaduzenjeUnos(z);
            zu.ShowDialog();
        }

        Zaduzenje.ZaduzenjePrikaz zp = new Zaduzenje.ZaduzenjePrikaz();
        private void pregledZaduzenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zp.ShowDialog();
        }
    }
}
