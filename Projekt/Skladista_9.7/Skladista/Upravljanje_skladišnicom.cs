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
    public partial class Upravljanje_skladišnicom : Form
    {
        public Upravljanje_skladišnicom()
        {
            InitializeComponent();
        }
        private void PrikaziSkladisnice()
        {
            int vrstaDokumenta = 1; // U bazi 1 pretstavlja skladišnicu
            using (var db = new PISkladiste2Entities())
            {
                List<interniDokument> skladisnica = (from t in db.interniDokument
                                                     where t.vrsta == vrstaDokumenta
                                                     select t).ToList();



                interniDokumentBindingSource.DataSource = skladisnica;
            }
        }
        private void DohvatiZaposlenike()
        {
            BindingList<Zaposlenik> korisnici = null;
            using (var db = new PISkladiste2Entities())
            {
                korisnici = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());
            }
            zaposlenikBindingSource.DataSource = korisnici;
        }
        private void DohvatiNaziveDokumenta()
        {
            BindingList<vrsta_internog_dokumenta> vrste = null;
            using (var db = new PISkladiste2Entities())
            {
                vrste = new BindingList<vrsta_internog_dokumenta>(db.vrsta_internog_dokumenta.ToList());
            }
            vrstainternogdokumentaBindingSource.DataSource = vrste;
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
           
            Skladišnica prozor = new Skladišnica();

            prozor.ShowDialog();
            PrikaziSkladisnice();

   
        }

        private void Upravljanje_skladišnicom_Load(object sender, EventArgs e)
        {
            PrikaziSkladisnice();
            DohvatiZaposlenike();
            DohvatiNaziveDokumenta();
            dgvPrikazSkladisnica.DataError += dgvPrikazSkladisnica_DataError;

        }
        void dgvPrikazSkladisnica_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            interniDokument selektiraniDokument = interniDokumentBindingSource.Current as interniDokument;
            if (selektiraniDokument != null)
            {
                azurirajSkladisnicu forma = new azurirajSkladisnicu(selektiraniDokument);
                
                forma.ShowDialog();
                
            }
            PrikaziSkladisnice();
      
            
        }

        private void Upravljanje_skladišnicom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dgvPrikazSkladisnica.DataSource = null;
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtPretrazi.Text != null)
            {
                BindingList<interniDokument> skladisnice = null;
                using (var db = new PISkladiste2Entities())
                    
                {

                    IEnumerable<interniDokument> skladisnica = from p in db.interniDokument
                                                            where p.sifra.Contains(txtPretrazi.Text)
                                                  select p;
                    skladisnice = new BindingList<interniDokument>(skladisnica.ToList());

                }
                interniDokumentBindingSource.DataSource = skladisnice;
               
            }
            else {
                PrikaziSkladisnice();
                DohvatiZaposlenike();
                DohvatiNaziveDokumenta();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            interniDokument selektiraniDokument = interniDokumentBindingSource.Current as interniDokument;
            if (selektiraniDokument != null)
            {
                IzvjestajInterniPrikaz forma = new IzvjestajInterniPrikaz(selektiraniDokument);

                forma.ShowDialog();

            }
            

        }

       

     
    }
}
