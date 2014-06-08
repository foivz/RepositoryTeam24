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
    public partial class Narudžbenica : Form
    {
        public Narudžbenica()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void btnZatvoriNar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
