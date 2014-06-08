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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void prijava_u_sustav(object sender, EventArgs e)
        {
            Prijava forma = new Prijava();
            forma.MdiParent = this; 
            forma.Show();
            

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
            Artikli prozor = new Artikli();
            prozor.MdiParent = this;
            prozor.Show();
        }

        private void skladišnicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
            this.Close();
        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prijava forma = new Prijava();
            forma.MdiParent = this;
            forma.Show();
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
