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

namespace KlijentForme.Zaduzenje
{
    public partial class ZaduzenjeUnos : Form
    {
        BibliotekaKlasa.Zaposleni z;
        public ZaduzenjeUnos(BibliotekaKlasa.Zaposleni z)
        {
            this.z = z;
            InitializeComponent();
        }
        ZaduzenjeKI zki = new ZaduzenjeKI();
        private void ZaduzenjeUnos_Load(object sender, EventArgs e)
        {
            zki.povezisesaserverom();
            dtpZaduzenje.Value = DateTime.Now;
            zki.kreirajZaduzenje(txtSifra);
            
            zki.postaviZaglavlje(dgUnosStavke);
            txtUkIznos.Text = "0";

            zki.popuniKombo(cmbClan);

        }



        private void dgUnosStavke_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int trenutniRed = this.dgUnosStavke.RowCount - 1;
            this.dgUnosStavke.Rows[trenutniRed].Cells["rbrDG"].Value = trenutniRed + 1;
        }

        private void ukupanIznos(object sender, DataGridViewCellEventArgs e) 
        {
            if (dgUnosStavke.Rows[dgUnosStavke.RowCount - 2].Cells["filmDG"].Value!=null) 
            {
                zki.izracunajZaduzenje(dgUnosStavke.Rows[dgUnosStavke.RowCount - 2].Cells["filmDG"], txtUkIznos);
            }
        }
        List<StavkaZaduzenja> listaStavki = new List<StavkaZaduzenja>();
        private void btnUnesiStavku_Click(object sender, EventArgs e)
        {
            zki.sacuvajZaduzenje(txtSifra, txtUkIznos, dtpZaduzenje, dtpRazduzenje, dgUnosStavke,cmbClan);


            
            
        }

        private void dtpZaduzenje_ValueChanged(object sender, EventArgs e)
        {
            dtpRazduzenje.Value = dtpZaduzenje.Value.AddDays(15);
        }
    }
}
