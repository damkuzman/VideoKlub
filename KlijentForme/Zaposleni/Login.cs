using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerI;

namespace KlijentForme.Zaposleni
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ZaposleniKI zki = new ZaposleniKI();

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            zki.povezisesaserverom();
            BibliotekaKlasa.Zaposleni z = zki.login(txtUser, txtPass);
            if (z == null) MessageBox.Show("Pogresan user ili pass");
            else 
            {
                PocetnaForma pf = new PocetnaForma(z);
                pf.ShowDialog();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
