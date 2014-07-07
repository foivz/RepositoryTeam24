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
    public partial class Upravljanje_izdatnicom : Form
    {
        public Upravljanje_izdatnicom()
        {
            InitializeComponent();
        }

        private void PrikaziIzdatnice()
        {
            BindingList<interniDokument> izdatnice = null;
            using (var db = new PISkladiste2Entities())
            {

                izdatnice = new BindingList<interniDokument>(db.interniDokument.ToList());

            }
            interniDokumentBindingSource.DataSource = izdatnice;
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
            Izdatnica prozor = new Izdatnica();

            prozor.ShowDialog();
            PrikaziIzdatnice();
        }

        private void Upravljanje_izdatnicom_Load(object sender, EventArgs e)
        {
            PrikaziIzdatnice();
            DohvatiZaposlenike();
            DohvatiNaziveDokumenta();
            dataGridView1.DataError += dataGridView1_DataError;
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            interniDokument selektiraniDokument = interniDokumentBindingSource.Current as interniDokument;
            if (selektiraniDokument != null)
            {
                azurirajIzdatnicu forma = new azurirajIzdatnicu(selektiraniDokument);

                forma.ShowDialog();

            }
            PrikaziIzdatnice();
      
        }

        private void Upravljanje_izdatnicom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dataGridView1.DataSource = null;
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtPretrazi.Text != null)
            {
                BindingList<interniDokument> izdatnice = null;
                using (var db = new PISkladiste2Entities())
                {

                    IEnumerable<interniDokument> izdatnica = from p in db.interniDokument
                                                               where p.sifra.Contains(txtPretrazi.Text)
                                                               select p;
                    izdatnice = new BindingList<interniDokument>(izdatnica.ToList());

                }
                interniDokumentBindingSource.DataSource = izdatnice;

            }
            else
            {
                PrikaziIzdatnice();
                DohvatiZaposlenike();
                DohvatiNaziveDokumenta();
            }
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
