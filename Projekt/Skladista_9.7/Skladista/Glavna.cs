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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            /*
            this.tsDokumenti.Enabled = false;
            this.tsArtikli.Enabled = false;
            this.tsKorisnici.Enabled = false;
            this.tsSkladiste.Enabled = false;
            this.odjavaIzbornik.Enabled = false;
            Prijava forma = new Prijava(this);   
            forma.MdiParent = this;
            forma.Show();
              */
      
        }
        

        private void prijava_u_sustav(object sender, EventArgs e)
        {
           // Prijava forma = new Prijava();
            //forma.MdiParent = this; 
            //forma.ShowDialog();
           // Prijava forma = new Prijava(this);
           
            

        }

        private void kreiranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudžbenica prozor = new Narudžbenica();
            prozor.MdiParent = this; 
            prozor.Show();
        }



        private void kreiranjeToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UpravljanjeArtiklima prozor = new UpravljanjeArtiklima();
            prozor.MdiParent = this;
            prozor.Show();
        }

        private void skladišnicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Upravljanje_skladišnicom prozor = new Upravljanje_skladišnicom();
            prozor.MdiParent = this;
            prozor.Show();
        }


        private void kreiranjeKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpravljanjeKorisnicima forma = new UpravljanjeKorisnicima();
            forma.MdiParent = this;
            forma.Show();

        }

       

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tsDokumenti.Enabled = false;
            this.tsArtikli.Enabled = false;
            this.tsKorisnici.Enabled = false;
            this.tsSkladiste.Enabled = false;
            this.odjavaIzbornik.Enabled = false;
            this.prijavaIzbornik.Enabled = true;
            this.Close();
        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prijava forma = new Prijava(this);   
            forma.ShowDialog();
            
        }


        private void odjavaIzbornik_Click(object sender, EventArgs e)
        {
            this.tsDokumenti.Enabled = false;
            this.tsArtikli.Enabled = false;
            this.tsKorisnici.Enabled = false;
            this.tsSkladiste.Enabled = false;
            this.odjavaIzbornik.Enabled = false;
            this.prijavaIzbornik.Enabled = true;
        }

        private void narudzbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upravljanje_narudzbenicom prozor = new Upravljanje_narudzbenicom();
            prozor.MdiParent = this;
            prozor.Show();
        }

        private void izdatnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upravljanje_izdatnicom prozor = new Upravljanje_izdatnicom();
            prozor.MdiParent = this;
            prozor.Show();
        }

        private void otpremnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upravljanje_otpremnicom prozor = new Upravljanje_otpremnicom();
            prozor.MdiParent = this;
            prozor.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void uvidUStanjeNaSkladištuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrafičkiPrikaz forma = new GrafičkiPrikaz(24, 100, 99, 100, 149, 200);
            forma.ShowDialog();
        }

        private void podizbornikABC_Click(object sender, EventArgs e)
        {
            ABCKlasifikacija prozor = new ABCKlasifikacija();
            prozor.MdiParent = this;
            prozor.Show();
        }

      

       
    }
}
