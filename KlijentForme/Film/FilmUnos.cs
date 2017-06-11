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
    public partial class FilmUnos : Form
    {
        public FilmUnos()
        {
            InitializeComponent();
        }
        KontrolerI.FilmKI fki = new KontrolerI.FilmKI();
        private void FilmUnos_Load(object sender, EventArgs e)
        {
            fki.poveziSeSaServerom();
            fki.kreirajFilm(txtFilmID);

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            TransferKlasa tk = fki.zapamtiFilm(txtFilmID, txtNaziv, cmbZanr, txtReziser, txtTrajanje, txtKolicina, txtCena);

            if (tk != null) MessageBox.Show("Uspesno ste uneli film");
            else MessageBox.Show("Film nije unesen");
        }

      
    }
}
