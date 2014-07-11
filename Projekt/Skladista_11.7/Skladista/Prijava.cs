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


        private static Glavna RoditeljForma= null;
        public Prijava()
        {
            InitializeComponent();
          
            
        }
        public Prijava(Glavna Roditelj): this() 
        {
            RoditeljForma = Roditelj; 
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
                    if (korisnik.uloga == 1)
                    {
                        RoditeljForma.tsSkladiste.Enabled = true;
                        RoditeljForma.tsKorisnici.Enabled = true;
                        RoditeljForma.tsArtikli.Enabled = true;
                        RoditeljForma.tsDokumenti.Enabled = true;
                    }
                    else if (korisnik.uloga== 2) 
                    {
                        RoditeljForma.tsSkladiste.Enabled = true;
                    }
                    else if (korisnik.uloga == 3)
                    {
                        RoditeljForma.tsArtikli.Enabled = true;
                        RoditeljForma.tsDokumenti.Enabled = true;
                        RoditeljForma.narudzbenicaPodizbornik.Enabled = false;
                        RoditeljForma.otpremnicaPodizbornik.Enabled = true;
                        RoditeljForma.skladišnicaPodizbornik.Enabled =  true;
                        RoditeljForma.izdatnicaPodizbornik.Enabled = true;
                    }
                    else if (korisnik.uloga == 4)
                    {
                        RoditeljForma.tsDokumenti.Enabled = true;
                        RoditeljForma.narudzbenicaPodizbornik.Enabled = true;
                        RoditeljForma.otpremnicaPodizbornik.Enabled = false;
                        RoditeljForma.skladišnicaPodizbornik.Enabled = false;
                        RoditeljForma.izdatnicaPodizbornik.Enabled = false;
                        
                    }
                    RoditeljForma.odjavaIzbornik.Enabled = true;
                    RoditeljForma.prijavaIzbornik.Enabled = false;
                    MessageBox.Show("Uspješno ste logirani!");


                    this.Close();



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
