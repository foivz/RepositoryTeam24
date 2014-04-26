using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programski_inženjerstvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrijavaUSustav newForm = new PrijavaUSustav();
            this.Hide();
            newForm.Show();
            this.Show();
        }

        private void prijavaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrijavaUSustav newForm = new PrijavaUSustav();
            this.Hide();
            newForm.Show();
            this.Show();
        }

        private void kreiranjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Narudzbenica newForm = new Narudzbenica();
            this.Hide();
            newForm.Show();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
