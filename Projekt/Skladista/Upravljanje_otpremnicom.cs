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
    public partial class Upravljanje_otpremnicom : Form
    {
        public Upravljanje_otpremnicom()
        {
            InitializeComponent();
        }

        private void PrikaziOtpremnice()
        {
            BindingList<eksterniDokument> otpremnice = null;
            using (var db = new PISkladiste2Entities())
            {

                otpremnice = new BindingList<eksterniDokument>(db.eksterniDokument.ToList());

            }
            eksterniDokumentBindingSource.DataSource = otpremnice;
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

       /* private void DohvatiNaziveDokumenta()
        {
            BindingList<vrsta_eksternog_dokumenta> vrste = null;
            using (var db = new PISkladiste2Entities())
            {
                vrste = new BindingList<vrsta_eksternog_dokumenta>(db.vrsta_eksternog_dokumenta.ToList());
            }
            vrstaeksternogdokumentaBindingSource.DataSource = vrste;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            var Otpremnica = new Otpremnica();
            Otpremnica.ShowDialog();
            PrikaziOtpremnice();
           
        }

        private void Upravljanje_otpremnicom_Load(object sender, EventArgs e)
        {
            PrikaziOtpremnice();
            DohvatiZaposlenike();
            DohvatiPartnere();
        //    DohvatiNaziveDokumenta();
            dataGridView1.DataError += dataGridView1_DataError;
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            eksterniDokument selektiraniDokument = eksterniDokumentBindingSource.Current as eksterniDokument;
            if (selektiraniDokument != null)
            {
                azurirajOtpremnicu forma = new azurirajOtpremnicu(selektiraniDokument);

                forma.ShowDialog();

            }
            PrikaziOtpremnice();
        }

      

        private void Upravljanje_otpremnicom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dataGridView1.DataSource = null;
        }

       

        private void txtPretrazi_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPretrazi.Text != null)
            {
                BindingList<eksterniDokument> otpremnice = null;
                using (var db = new PISkladiste2Entities())
                {

                    IEnumerable<eksterniDokument> otpremnica = from p in db.eksterniDokument
                                                               where p.sifra.Contains(txtPretrazi.Text)
                                                               select p;
                    otpremnice = new BindingList<eksterniDokument>(otpremnica.ToList());

                }
                eksterniDokumentBindingSource.DataSource = otpremnice;

            }
            else
            {
                PrikaziOtpremnice();
                DohvatiZaposlenike();
                DohvatiPartnere();
              //  DohvatiNaziveDokumenta();
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
