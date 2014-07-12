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
    public partial class UpravljanjeArtiklima : Form
    {
        public UpravljanjeArtiklima()
        {
            InitializeComponent();
        }
        private void PrikaziArtikle()
        {
            BindingList<Artikl> artikli = null;
            using (var db = new PISkladiste2Entities())
            {

                artikli = new BindingList<Artikl>(db.Artikl.ToList());

            }
            artiklBindingSource.DataSource = artikli;
        }
        private void PrikaziPododjela()
        {
            BindingList<Pododjel> pododjeli = null;
            using (var db = new PISkladiste2Entities())
            {

                pododjeli = new BindingList<Pododjel>(db.Pododjel.ToList());

            }
            pododjelBindingSource.DataSource = pododjeli;
        }
        private void UpravljanjeArtiklima_Load(object sender, EventArgs e)
        {
            PrikaziArtikle();
            PrikaziPododjela();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dgvArtikli.Columns[2].DefaultCellStyle = stil;
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraziNaziv.Text != null)
            {
                
                BindingList<Artikl> artikli = null;
                using (var db = new PISkladiste2Entities())
                {

                    IEnumerable<Artikl> artikl = from p in db.Artikl
                                                               where p.naziv.Contains(txtPretraziNaziv.Text)
                                                               select p;
                    artikli = new BindingList<Artikl>(artikl.ToList());

                }
                artiklBindingSource.DataSource = artikli;
                

            }
            else
            {
                PrikaziArtikle();
            }
        }

   

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvArtikli.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[0].Value.Equals(""))
                {
                    continue;
                }
        
                int a = int.Parse(row.Cells[3].Value.ToString());
                int b = int.Parse(row.Cells[4].Value.ToString());
                if (a < b)
                {
                    row.Cells[3].Style.BackColor = Color.OrangeRed;
                }
                else
                {
                    row.Cells[3].Style.BackColor = Color.GreenYellow;
                }
            }
        }

 

        private void btnKreitaj_Click(object sender, EventArgs e)
        {
            Artikli prozor = new Artikli();
            prozor.ShowDialog();
            PrikaziArtikle();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Artikl selektiraniArtikl = artiklBindingSource.Current as Artikl;
            if (selektiraniArtikl != null)
            {
                Artikli forma = new Artikli(selektiraniArtikl);
                forma.ShowDialog();
                PrikaziArtikle();
            }
        }

    
    }
}
