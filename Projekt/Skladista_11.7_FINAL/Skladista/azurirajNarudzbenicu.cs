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
    public partial class azurirajNarudzbenicu : Form
    {
        private eksterniDokument dokument;

        public azurirajNarudzbenicu(eksterniDokument str)
        {
            InitializeComponent();
            dokument = str;
        }

        private void DohvatiStavkeNarudzbenice(eksterniDokument narudzbenica)
        {


            BindingList<stavke_eksternogDokumenta> stavke = null;
            using (var db = new PISkladiste2Entities())
            {
                db.eksterniDokument.Attach(narudzbenica);
                stavke = new BindingList<stavke_eksternogDokumenta>(narudzbenica.stavke_eksternogDokumenta.ToList());

            }
            stavkeeksternogDokumentaBindingSource.DataSource = stavke;


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
        private void DohvatiZaposlenike()
        {
            int vrstaKorisnika = 4; // U bazi 4 predtsavlja logističara
            using (var db = new PISkladiste2Entities())
            {
                List<Zaposlenik> korisnici = (from t in db.Zaposlenik
                                              where t.uloga == vrstaKorisnika
                                              select t).ToList();



                zaposlenikBindingSource.DataSource = korisnici;
            }
        }

        private void DohvatiPoslovnePartnere()
        {
            BindingList<poslovniPartner> partneri = null;
            using (var db = new PISkladiste2Entities())
            {
                partneri = new BindingList<poslovniPartner>(db.poslovniPartner.ToList());
            }
            poslovniPartnerBindingSource.DataSource = partneri;
        }

        private void azurirajNarudzbenicu_Load(object sender, EventArgs e)
        {
            DohvatiStavkeNarudzbenice(dokument);
            PrikaziArtikle();
            DohvatiZaposlenike();
            DohvatiPoslovnePartnere();
            txtSifraNar.Text = dokument.sifra;
            datumIzrade.Value = (DateTime)dokument.datum;
            cmbIzradioSifra.Text = dokument.izradio.ToString();
            cmbSifraPar.Text = dokument.poslovni_partner.ToString();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.tgvPrikaz.Columns[6].DefaultCellStyle = stil;
            this.tgvPrikaz.Columns[7].DefaultCellStyle = stil;
            tgvPrikaz.DataError += dataGridView1_DataError;
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
            DodajStavku_eksterni forma = new DodajStavku_eksterni(dokument);
            forma.ShowDialog();

            DohvatiStavkeNarudzbenice(dokument);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            stavke_eksternogDokumenta selektiraniArtikl = stavkeeksternogDokumentaBindingSource.Current as stavke_eksternogDokumenta;
            if (selektiraniArtikl != null)
            {
                DodajStavku_eksterni forma = new DodajStavku_eksterni(selektiraniArtikl, dokument);
                forma.ShowDialog();
                DohvatiStavkeNarudzbenice(dokument);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                stavke_eksternogDokumenta selektiraniArtikl = stavkeeksternogDokumentaBindingSource.Current as stavke_eksternogDokumenta;
                if (selektiraniArtikl != null)
                {
                    if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new PISkladiste2Entities())
                        {
                            db.stavke_eksternogDokumenta.Attach(selektiraniArtikl);
                            db.stavke_eksternogDokumenta.Remove(selektiraniArtikl);
                            db.SaveChanges();
                        }
                    }
                }
                DohvatiStavkeNarudzbenice(dokument);
            }
            catch
            {
                MessageBox.Show("Brisanje nije uspijelo");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DateTime datumNarudzbenice = datumIzrade.Value;
            this.Text = datumNarudzbenice.ToString();
            if (dokument != null)
            {
                using (var db = new PISkladiste2Entities())
                {
                    db.eksterniDokument.Attach(dokument);
                    dokument.izradio = int.Parse(cmbIzradioSifra.SelectedValue.ToString());
                    dokument.poslovni_partner = int.Parse(cmbSifraPar.SelectedValue.ToString());
                    dokument.datum = datumNarudzbenice;
                    db.SaveChanges();
                }

            }
            this.Close();
        }

     

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        
    }
}
