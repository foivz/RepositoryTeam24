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
                        RoditeljForma.toolStripDropDownButton4.Enabled = true;
                        RoditeljForma.toolStripDropDownButton3.Enabled = true;
                        RoditeljForma.toolStripDropDownButton2.Enabled = true;
                        RoditeljForma.toolStripDropDownButton1.Enabled = true;
                    }
                    else if (korisnik.uloga== 2) 
                    {
                        RoditeljForma.toolStripDropDownButton4.Enabled = true;
                    }
                    else if (korisnik.uloga == 3)
                    {
                        RoditeljForma.toolStripDropDownButton2.Enabled = true;
                        RoditeljForma.toolStripDropDownButton1.Enabled = true;
                        RoditeljForma.narudzbenicaToolStripMenuItem.Enabled = false;
                        RoditeljForma.otpremnicaToolStripMenuItem.Enabled = true;
                        RoditeljForma.skladišnicaToolStripMenuItem1.Enabled =  true;
                        RoditeljForma.izdatnicaToolStripMenuItem.Enabled = true;
                    }
                    else if (korisnik.uloga == 4)
                    {
                        RoditeljForma.toolStripDropDownButton1.Enabled = true;
                        RoditeljForma.narudzbenicaToolStripMenuItem.Enabled = true;
                        RoditeljForma.otpremnicaToolStripMenuItem.Enabled = false;
                        RoditeljForma.skladišnicaToolStripMenuItem1.Enabled = false;
                        RoditeljForma.izdatnicaToolStripMenuItem.Enabled = false;
                        
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
