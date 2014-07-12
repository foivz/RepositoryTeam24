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
    public partial class azurirajOtpremnicu : Form
    {
        private eksterniDokument dokument;

        public azurirajOtpremnicu(eksterniDokument str)
        {
            InitializeComponent();
            dokument = str;
        }

        private void DohvatiStavkeOtpremnice(eksterniDokument otpremnica)
        {


            BindingList<stavke_eksternogDokumenta> stavke = null;
            using (var db = new PISkladiste2Entities())
            {
                db.eksterniDokument.Attach(otpremnica);
                stavke = new BindingList<stavke_eksternogDokumenta>(otpremnica.stavke_eksternogDokumenta.ToList());

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
            int vrstaKorisnika = 2; // U bazi 2 pretstavlja Voditelje skladišta
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

        private void azurirajOtpremnicu_Load(object sender, EventArgs e)
        {
            DohvatiStavkeOtpremnice(dokument);
            PrikaziArtikle();
            DohvatiZaposlenike();
            DohvatiPoslovnePartnere();
            txtSifraOtp.Text = dokument.sifra;
            datumIzrade.Value = (DateTime)dokument.datum;
            cmbIzradioSifra.Text = dokument.izradio.ToString();
            cmbSifraPartnera.Text = dokument.poslovni_partner.ToString();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dgvPrikaz.Columns[3].DefaultCellStyle = stil;
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
            DodajStavku_eksterni forma = new DodajStavku_eksterni(dokument);
            forma.ShowDialog();

            DohvatiStavkeOtpremnice(dokument);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            stavke_eksternogDokumenta selektiraniArtikl = stavkeeksternogDokumentaBindingSource.Current as stavke_eksternogDokumenta;
            if (selektiraniArtikl != null)
            {
                DodajStavku_eksterni forma = new DodajStavku_eksterni(selektiraniArtikl, dokument);
                forma.ShowDialog();
                DohvatiStavkeOtpremnice(dokument);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                stavke_eksternogDokumenta selektiraniArtikl = stavkeeksternogDokumentaBindingSource.Current as stavke_eksternogDokumenta;
                if (selektiraniArtikl != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new PISkladiste2Entities())
                        {
                            db.stavke_eksternogDokumenta.Attach(selektiraniArtikl);
                            db.stavke_eksternogDokumenta.Remove(selektiraniArtikl);
                            db.SaveChanges();
                        }
                    }
                }
                DohvatiStavkeOtpremnice(dokument);
            }
            catch
            {
                MessageBox.Show("Brisanje nije moguće!");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DateTime datumOtpremnice = datumIzrade.Value;
            this.Text = datumOtpremnice.ToString();
            if (dokument != null)
            {
                using (var db = new PISkladiste2Entities())
                {
                    db.eksterniDokument.Attach(dokument);
                    dokument.izradio = int.Parse(cmbIzradioSifra.SelectedValue.ToString());
                    dokument.poslovni_partner = int.Parse(cmbSifraPartnera.SelectedValue.ToString());
                    dokument.datum = datumOtpremnice;
                    db.SaveChanges();
                }

            }
            this.Close();
        }
        


       
    }
}
