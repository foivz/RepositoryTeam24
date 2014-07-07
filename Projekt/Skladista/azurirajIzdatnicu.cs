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
    public partial class azurirajIzdatnicu : Form
    {
        private interniDokument dokument;

        public azurirajIzdatnicu(interniDokument str)
        {
            InitializeComponent();
            dokument = str;
        }

        private void DohvatiStavkeIzdatnice(interniDokument izdatnica)
        {


            BindingList<stavke_internogDokumenta> stavke = null;
            using (var db = new PISkladiste2Entities())
            {
                db.interniDokument.Attach(izdatnica);
                stavke = new BindingList<stavke_internogDokumenta>(izdatnica.stavke_internogDokumenta.ToList());

            }
            stavkeinternogDokumentaBindingSource.DataSource = stavke;


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
            BindingList<Zaposlenik> korisnici = null;
            using (var db = new PISkladiste2Entities())
            {
                korisnici = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());
            }
            zaposlenikBindingSource.DataSource = korisnici;
        }

        private void azurirajIzdatnicu_Load(object sender, EventArgs e)
        {
            DohvatiStavkeIzdatnice(dokument);
            PrikaziArtikle();
            DohvatiZaposlenike();
            txtSifraNar.Text = dokument.sifra;
            datumIzrade.Value = (DateTime)dokument.datum;
            cmbIzradioSifra.Text = dokument.izradio.ToString();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dataGridView1.Columns[3].DefaultCellStyle = stil;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dodajStavku forma = new dodajStavku(dokument);
            forma.ShowDialog();

            DohvatiStavkeIzdatnice(dokument);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            stavke_internogDokumenta selektiraniArtikl = stavkeinternogDokumentaBindingSource.Current as stavke_internogDokumenta;
            if (selektiraniArtikl != null)
            {
                dodajStavku forma = new dodajStavku(selektiraniArtikl, dokument);
                forma.ShowDialog();
                DohvatiStavkeIzdatnice(dokument);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            stavke_internogDokumenta selektiraniArtikl = stavkeinternogDokumentaBindingSource.Current as stavke_internogDokumenta;
            if (selektiraniArtikl != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new PISkladiste2Entities())
                    {
                        db.stavke_internogDokumenta.Attach(selektiraniArtikl);
                        db.stavke_internogDokumenta.Remove(selektiraniArtikl);
                        db.SaveChanges();
                    }
                }
            }
            DohvatiStavkeIzdatnice(dokument);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DateTime datumIzdatnice = datumIzrade.Value;
            this.Text = datumIzdatnice.ToString();
            if (dokument != null)
            {
                using (var db = new PISkladiste2Entities())
                {
                    db.interniDokument.Attach(dokument);
                    dokument.izradio = int.Parse(cmbIzradioSifra.SelectedValue.ToString());
                    dokument.datum = datumIzdatnice;
                    db.SaveChanges();
                }

            }
            this.Close();
        }
    }
}
