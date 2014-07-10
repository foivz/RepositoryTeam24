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
    public partial class azurirajSkladisnicu : Form
    {
        private interniDokument dokument;
       
        public azurirajSkladisnicu(interniDokument str)
        {
            InitializeComponent();
            dokument = str;
    
        }    

        private void DohvatiStavkeSkladisnice(interniDokument skladisnica)
        {
           

            BindingList<stavke_internogDokumenta> stavke = null;
            using (var db = new PISkladiste2Entities())
            {
                db.interniDokument.Attach(skladisnica);
                stavke = new BindingList<stavke_internogDokumenta>(skladisnica.stavke_internogDokumenta.ToList());
               
            }
            stavkeinternogDokumentaBindingSource.DataSource = stavke;
            
        
        }
        private void PrikaziArtikle()
        {
            BindingList<Artikl> korisnici = null;
            using (var db = new PISkladiste2Entities())
            {

                korisnici = new BindingList<Artikl>(db.Artikl.ToList());

            }
            artiklBindingSource.DataSource = korisnici;
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

     
        private void azurirajSkladisnicu_Load(object sender, EventArgs e)
        {
            DohvatiStavkeSkladisnice(dokument);
            PrikaziArtikle();
            DohvatiZaposlenike();
            txtSifraSkl.Text = dokument.sifra;
            datumIzrade.Value = (DateTime)dokument.datum;
            cmbIzradioSifra.Text =dokument.izradio.ToString();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dgvPrikaz.Columns[4].DefaultCellStyle = stil;
            this.dgvPrikaz.Columns[7].DefaultCellStyle = stil;
            dgvPrikaz.DataError += dataGridView1_DataError;
        }
        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
               
                     dodajStavku forma = new dodajStavku(dokument);
                     forma.ShowDialog();             
                     DohvatiStavkeSkladisnice(dokument);
                
                
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            
            stavke_internogDokumenta selektiraniArtikl = stavkeinternogDokumentaBindingSource.Current as stavke_internogDokumenta;
            if (selektiraniArtikl != null)
            {
                dodajStavku forma = new dodajStavku(selektiraniArtikl,dokument);
                forma.ShowDialog();
                DohvatiStavkeSkladisnice(dokument);
            
            }
          
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DateTime datumSkladisnice = datumIzrade.Value;
            this.Text = datumSkladisnice.ToString();
            try
            {
            if (dokument != null)
            {
                using (var db = new PISkladiste2Entities())
                {
                    db.interniDokument.Attach(dokument);
                    dokument.izradio = int.Parse(cmbIzradioSifra.SelectedValue.ToString());
                    dokument.datum = datumSkladisnice;      
                    db.SaveChanges();
                }
                
            }
            this.Close();
            }
            catch
            {
                 MessageBox.Show("Spremanje nije uspijelo!");
            }
        }

        private void btnIzbrisi_Click_1(object sender, EventArgs e)
        {
            int kolicinaSkladiste = 0;
            int kolicina = 0;
            stavke_internogDokumenta selektiraniArtikl = stavkeinternogDokumentaBindingSource.Current as stavke_internogDokumenta;
            try
            {
                if (selektiraniArtikl != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new PISkladiste2Entities())
                        {
                            db.stavke_internogDokumenta.Attach(selektiraniArtikl);
                            db.stavke_internogDokumenta.Remove(selektiraniArtikl);
                            db.SaveChanges();
                            kolicina = (int)selektiraniArtikl.kolicina;
                            Artikl artikl = (from t in db.Artikl
                                             where t.sifra == selektiraniArtikl.id_artikla
                                             select t).First<Artikl>();
                            kolicinaSkladiste = (int)artikl.kolicina;
                            kolicinaSkladiste -= kolicina;
                            db.Artikl.Attach(artikl);
                            artikl.kolicina = kolicinaSkladiste;
                            db.SaveChanges();
                        }
                    }
                }
                DohvatiStavkeSkladisnice(dokument);
            }
            catch
            {
                MessageBox.Show("Brisanje nije uspijelo!");
            }

        }
             
    }
}
