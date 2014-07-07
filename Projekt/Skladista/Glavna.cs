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
            this.toolStripDropDownButton1.Enabled = true;
            this.toolStripDropDownButton2.Enabled = true;
            this.toolStripDropDownButton3.Enabled = true;
            this.toolStripDropDownButton4.Enabled = true;
            this.odjavaIzbornik.Enabled = true;
            
             
           // Prijava popup = new Prijava();
           //Prijava forma = new Prijava();
         
           // forma.MdiParent = this;
           // forma.Show();
      
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ažuriranjeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }

        public void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
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

        private void kreiranjeToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
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

        private void ažuriranjeToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void kreiranjeKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici forma = new Korisnici();
            forma.MdiParent = this;
            forma.Show();

        }

       

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton2.Enabled = false;
            this.toolStripDropDownButton3.Enabled = false;
            this.toolStripDropDownButton4.Enabled = false;
            this.odjavaIzbornik.Enabled = false;
            this.prijavaIzbornik.Enabled = true;
            this.Close();
        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prijava forma = new Prijava(this);   
            forma.ShowDialog();
            
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {

        }

        private void odjavaIzbornik_Click(object sender, EventArgs e)
        {
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton2.Enabled = false;
            this.toolStripDropDownButton3.Enabled = false;
            this.toolStripDropDownButton4.Enabled = false;
            this.odjavaIzbornik.Enabled = false;
            this.prijavaIzbornik.Enabled = true;
        }

        private void narudzbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upravljanje_narudzbenicom prozor = new Upravljanje_narudzbenicom();
            prozor.MdiParent = this;
            prozor.Show();
        }

        private void ažuriranjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ažuriranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void pregledNarudžbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void uvidUStanjeNaSkladištuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uvid_u_stanje_na_skladistu forma = new Uvid_u_stanje_na_skladistu();
            forma.ShowDialog();
        }

      

       
    }
}
