using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotekaKlasa;

namespace KlijentForme.Film
{
    public partial class FilmPrikaz : Form
    {
        public FilmPrikaz()
        {
            InitializeComponent();
        }
        KontrolerI.FilmKI fki = new KontrolerI.FilmKI();
        private void cmbNaziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            fki.popuniPolja(cmbNaziv,cmbZanr,txtReziser,txtTrajanje,txtKolicina,txtCena);
        }

        private void FilmPrikaz_Load(object sender, EventArgs e)
        {
            fki.poveziSeSaServerom();
            fki.napuniKombo(cmbNaziv);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            TransferKlasa tk = fki.izmeniFilm(cmbNaziv, cmbZanr, txtReziser, txtTrajanje, txtKolicina, txtCena);
            if (tk != null) MessageBox.Show("Uspesno ste izmenili film");
            else MessageBox.Show("Film nije izmenjen");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            TransferKlasa tk = fki.obrisiFilm(cmbNaziv);
            if (tk != null)
            {
                MessageBox.Show("Uspesno ste obrisali film");
                fki.napuniKombo(cmbNaziv);
            }
            else MessageBox.Show("Film nije obrisan");
        }
    }
}
