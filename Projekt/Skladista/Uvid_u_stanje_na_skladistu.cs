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
    public partial class Uvid_u_stanje_na_skladistu : Form
    {
        public Uvid_u_stanje_na_skladistu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABCKlasifikacija form = new ABCKlasifikacija();
            form.ShowDialog();
        }
    }
}
