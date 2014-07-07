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
    public partial class IzvjestajInterniPrikaz : Form
    {
        public IzvjestajInterniPrikaz()
        {
            InitializeComponent();
        }
        private interniDokument prikaz;
        public IzvjestajInterniPrikaz(interniDokument str)
        {
            InitializeComponent();
            prikaz = str;
        }

        private void IzvjestajInterniPrikaz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PISkladiste2DataSet.InterniIzvjestaj' table. You can move, or remove it, as needed.
            this.InterniIzvjestajTableAdapter.FillinterniID(this.PISkladiste2DataSet.InterniIzvjestaj,prikaz.id_dokumenta);
            // TODO: This line of code loads data into the 'PISkladiste2DataSet.InterniStvake' table. You can move, or remove it, as needed.
            this.InterniStvakeTableAdapter.FillStavkeID(this.PISkladiste2DataSet.InterniStvake,prikaz.id_dokumenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
