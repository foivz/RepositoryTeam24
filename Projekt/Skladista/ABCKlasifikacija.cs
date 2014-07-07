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
    public partial class ABCKlasifikacija : Form
    {
        public ABCKlasifikacija()
        {
            InitializeComponent();
        }

        private void ABCKlasifikacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PISkladiste2DataSet.Artikl' table. You can move, or remove it, as needed.
            this.ArtiklTableAdapter.Fill(this.PISkladiste2DataSet.Artikl);

            this.reportViewer1.RefreshReport();
        }
    }
}
