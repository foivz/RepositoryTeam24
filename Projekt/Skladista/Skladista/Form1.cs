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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            forma.ShowDialog();

        }

        private void kreiranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudžbenica prozor = new Narudžbenica();
            prozor.ShowDialog();
        }

        private void kreiranjeToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void kreiranjeToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Artikli prozor = new Artikli();
            prozor.ShowDialog();
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
            forma.ShowDialog();

        }
    }
}
