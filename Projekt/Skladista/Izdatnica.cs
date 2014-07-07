using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladista
{
    public partial class Izdatnica : Form
    {
        public Izdatnica()
        {
            InitializeComponent();
        }

        private void generirajSifru()
        {
            List<interniDokument> dokumenti = null;
            using (var db = new PISkladiste2Entities())
            {
                dokumenti = new List<interniDokument>(db.interniDokument.ToList());
            }
            int brojac = 1;
            foreach (var izdatnica in dokumenti)
            {
                if (izdatnica.vrsta == 2)
                {
                    brojac++;
                }
            }

            string mjesec = DateTime.Now.ToString("MM");
            string dan = DateTime.Now.ToString("dd");
            string godina = DateTime.Now.ToString("yyyy");
            string sifraDokumenta = "IZD/0" + brojac + "-" + mjesec + "/" + dan + "/" + godina;
            txtSifraNar.Text = sifraDokumenta;

        }

        private void DohvatiArtikle()
        {
            BindingList<Artikl> artikli = null;
            artikli = new BindingList<Artikl>(db.Artikl.ToList());
            artiklBindingSource.DataSource = artikli;
        }
        private void DohvatiZaposlenike()
        {
            BindingList<Zaposlenik> korisnici = null;
            korisnici = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());
            zaposlenikBindingSource.DataSource = korisnici;
        }
        private PISkladiste2Entities _db;
        private PISkladiste2Entities db
        {
            get
            {
                if (_db == null)
                    _db = new PISkladiste2Entities();
                return _db;
            }

            set
            {
                _db = value;
            }
        }


        private void Izdatnica_Load(object sender, EventArgs e)
        {
            this.artiklTableAdapter.Fill(this.pISkladiste2DataSet.Artikl);
            DohvatiZaposlenike();
            DohvatiArtikle();
            generirajSifru();
          
          //  this.dataGridView1.Columns[4].DefaultCellStyle = stil;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kolicina;
            if (textBox3.Text == "")
            {
                kolicina = 0;
            }
            else
            {
                kolicina = int.Parse(textBox3.Text);
            }
            float ukupno = kolicina * float.Parse(nabavna_cijenaComboBox.Text);
            dataGridView1.Rows.Add(sifraComboBox.Text, nazivComboBox.Text, textBox3.Text,nabavna_cijenaComboBox.Text, ukupno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datumIzdatnice = dateTimePicker1.Value;
            this.Text = datumIzdatnice.ToString();
            int idIzdatnice;

            using (var db = new PISkladiste2Entities())
            {
                interniDokument izdatnica = new interniDokument
                {

                    datum = datumIzdatnice,
                    sifra = txtSifraNar.Text,
                    vrsta = 2,
                    izradio = int.Parse(prezimeComboBox.SelectedValue.ToString())

                };
                db.interniDokument.Add(izdatnica);

                db.SaveChanges();
                idIzdatnice = izdatnica.id_dokumenta;




            }
            int artiklID = 0;
            int kolicinaArtikla = 0;
            decimal cijena = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {



                if (row.Cells[0].Value == null || row.Cells[0].Value.Equals(""))
                {
                    continue;
                }

                else
                {
                    artiklID = int.Parse(row.Cells[0].Value.ToString());
                    kolicinaArtikla = int.Parse(row.Cells[2].Value.ToString());
                    cijena = decimal.Parse(row.Cells[3].Value.ToString());
                    using (var db1 = new PISkladiste2Entities())
                    {


                        stavke_internogDokumenta stavke = new stavke_internogDokumenta
                        {

                            id_artikla = artiklID,
                            id_dokumenta = idIzdatnice,
                            kolicina = kolicinaArtikla,
                            cijena_artikla = cijena
                        };
                        db1.stavke_internogDokumenta.Add(stavke);
                        db1.SaveChanges();


                    }

                }

            }
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void imeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prezimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
