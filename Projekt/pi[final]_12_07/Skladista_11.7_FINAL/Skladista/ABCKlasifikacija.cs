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
            DataGridViewCellStyle stil1 = new DataGridViewCellStyle();
            stil1.Format = "C2";
            this.dgvABC.Columns[1].DefaultCellStyle = stil1;
            this.dgvABC.Columns[3].DefaultCellStyle = stil1;
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "N2";
            this.dgvABC.Columns[4].DefaultCellStyle = stil;
            this.dgvABC.Columns[5].DefaultCellStyle = stil;
            this.dgvABC.Columns[6].DefaultCellStyle = stil;

            List<Artikl> artikli = null;
            using (var db = new PISkladiste2Entities())
            {
                artikli = new List<Artikl>(db.Artikl.ToList());
            }

            Artikl artikl = null;
            float ukupno = 0;
            float ukupnoSuma = 0;
            float postotak = 0;
            int velicina = (int)artikli.Count;
            for (int i = 0; i <= artikli.Count - 1; i++)
            {
                artikl = artikli[i];
                ukupno = (float)artikl.nabavna_cijena * (float)artikl.kolicina;
                ukupnoSuma += ukupno;
                this.dgvABC.Rows.Add();
                this.dgvABC.Rows[i].Cells[0].Value = artikl.naziv.ToString();
                this.dgvABC.Rows[i].Cells[1].ValueType = typeof(float);
                this.dgvABC.Rows[i].Cells[1].Value = artikl.nabavna_cijena;
                this.dgvABC.Rows[i].Cells[2].Value = artikl.kolicina.ToString();
                this.dgvABC.Rows[i].Cells[3].ValueType = typeof(float);
                this.dgvABC.Rows[i].Cells[3].Value = ukupno;
            }

            this.dgvABC.Sort(dgvABC.Columns[3], ListSortDirection.Descending);
            float[] polje = new float[velicina];
            for (int i = 0; i <= artikli.Count - 1; i++)
            {
                float ukupnaCijena = (float)this.dgvABC.Rows[i].Cells[3].Value;
                postotak = (ukupnaCijena / ukupnoSuma) * 100;
                this.dgvABC.Rows[i].Cells[4].ValueType = typeof(float);
                this.dgvABC.Rows[i].Cells[4].Value = postotak;
                polje[i] = postotak;
            }
            float suma = 0;
            for (int i = 0; i <= artikli.Count - 1; i++)
            {
                if (i == 0)
                {
                    suma += polje[i];
                    this.dgvABC.Rows[i].Cells[5].ValueType = typeof(float);
                    this.dgvABC.Rows[i].Cells[5].Value = polje[i];
                }
                else
                {
                    suma += polje[i];
                    if (suma > 100)
                    {
                        suma = 100;
                    }
                    this.dgvABC.Rows[i].Cells[5].ValueType = typeof(float);
                    this.dgvABC.Rows[i].Cells[5].Value = suma;

                }
                if (suma <= 75)
                {
                    this.dgvABC.Rows[i].Cells[6].Value = "A";
                    this.dgvABC.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;

                }
                else if (suma >= 75 && suma <= 90)
                {
                    this.dgvABC.Rows[i].Cells[6].Value = "B";
                    this.dgvABC.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    this.dgvABC.Rows[i].Cells[6].Value = "C";
                    this.dgvABC.Rows[i].DefaultCellStyle.BackColor = Color.MediumSlateBlue;
                }
            }
        }
    }
}
