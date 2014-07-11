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
    public partial class IzvjestajEksterniPrikaz : Form
    {
        public IzvjestajEksterniPrikaz()
        {
            InitializeComponent();
        }
        private eksterniDokument prikaz;
        public IzvjestajEksterniPrikaz(eksterniDokument str)
        {
            InitializeComponent();
            prikaz = str;
        }

        private void IzvjestajEksterniPrikaz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PISkladiste2DataSet.eksterniIzvjestaj' table. You can move, or remove it, as needed.
            this.eksterniIzvjestajTableAdapter.FilleksterniID(this.PISkladiste2DataSet.eksterniIzvjestaj,prikaz.id_dokumenta);
            // TODO: This line of code loads data into the 'PISkladiste2DataSet.eksterniStavke' table. You can move, or remove it, as needed.
            this.eksterniStavkeTableAdapter.FilleksterniStavke(this.PISkladiste2DataSet.eksterniStavke, prikaz.id_dokumenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
