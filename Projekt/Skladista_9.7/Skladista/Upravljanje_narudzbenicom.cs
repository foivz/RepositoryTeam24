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
    public partial class Upravljanje_narudzbenicom : Form
    {
        public Upravljanje_narudzbenicom()
        {
            InitializeComponent();
        }

        private void PrikaziNarudzbenice()
        {
            int vrstaDokumenta = 1; // U bazi 1 pretstavlja narudžbenicu
            using (var db = new PISkladiste2Entities())
            {
                List<eksterniDokument> narudzbenica = (from t in db.eksterniDokument
                                                     where t.vrsta == vrstaDokumenta
                                                     select t).ToList();



                eksterniDokumentBindingSource.DataSource = narudzbenica;
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

        private void DohvatiPartnere()
        {
            BindingList<poslovniPartner> partneri = null;
            using (var db = new PISkladiste2Entities())
            {
                partneri = new BindingList<poslovniPartner>(db.poslovniPartner.ToList());
            }
            poslovniPartnerBindingSource.DataSource = partneri;
        }

        private void DohvatiNaziveDokumenta()
        {
            BindingList<vrsta_eksternog_dokumenta> vrste = null;
            using (var db = new PISkladiste2Entities())
            {
                vrste = new BindingList<vrsta_eksternog_dokumenta>(db.vrsta_eksternog_dokumenta.ToList());
            }
            vrstaeksternogdokumentaBindingSource.DataSource = vrste;
        }

        private void Upravljanje_narudzbenicom_Load(object sender, EventArgs e)
        {
            PrikaziNarudzbenice();
            DohvatiZaposlenike();
            DohvatiPartnere();
            DohvatiNaziveDokumenta();
            dgvPrikaz.DataError += dataGridView1_DataError;
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Narudžbenica = new Narudžbenica();
            Narudžbenica.ShowDialog();
            PrikaziNarudzbenice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eksterniDokument selektiraniDokument = eksterniDokumentBindingSource.Current as eksterniDokument;
            if (selektiraniDokument != null)
            {
                azurirajNarudzbenicu forma = new azurirajNarudzbenicu(selektiraniDokument);

                forma.ShowDialog();

            }
            PrikaziNarudzbenice();
        }

        private void Upravljanje_otpremnicom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dgvPrikaz.DataSource = null;
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtPretrazi.Text != null)
            {
                BindingList<eksterniDokument> narudzbenice = null;
                using (var db = new PISkladiste2Entities())
                {

                    IEnumerable<eksterniDokument> narudzbenica = from p in db.eksterniDokument
                                                               where p.sifra.Contains(txtPretrazi.Text)
                                                               select p;
                    narudzbenice = new BindingList<eksterniDokument>(narudzbenice.ToList());

                }
                eksterniDokumentBindingSource.DataSource = narudzbenice;

            }
            else
            {
                PrikaziNarudzbenice();
                DohvatiZaposlenike();
                DohvatiPartnere();
                DohvatiNaziveDokumenta();
            }
       
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eksterniDokument selektiraniDokument = eksterniDokumentBindingSource.Current as eksterniDokument;
            if (selektiraniDokument != null)
            {
                IzvjestajEksterniPrikaz forma = new IzvjestajEksterniPrikaz(selektiraniDokument);

                forma.ShowDialog();

            }
        }

    }
}
