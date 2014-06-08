using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladista
{
    public partial class Prijava : Form
    {
             
        public Prijava()
        {
            InitializeComponent();
        }
     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Zaposlenik> korisnici = null;
            using (var db = new PISkladiste2Entities())
            {
                korisnici = new List<Zaposlenik>(db.Zaposlenik.ToList());
            }
            foreach (var korisnik in korisnici)
            {

                if (korisnik.korisnicko_ime == txtKorisnickoIme.Text && korisnik.lozinka == txtLozinka.Text)
                {

                    MessageBox.Show("Uspješno ste logirani!");
                    Glavna MyForm2 = new Glavna();  
                    return;
                }
                
            }
            MessageBox.Show("Pokušajte ponovno!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }
    }
}
