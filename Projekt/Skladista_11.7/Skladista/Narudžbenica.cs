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
    public partial class Narudžbenica : Form
    {
        public Narudžbenica()
        {
            InitializeComponent();
            
        }

        private void generirajSifru()
        {
            List<eksterniDokument> dokumenti = null;
            using (var db = new PISkladiste2Entities())
            {
                dokumenti = new List<eksterniDokument>(db.eksterniDokument.ToList());
            }
            int brojac = 1;
            foreach (var narudzbenica in dokumenti)
            {
                if (narudzbenica.vrsta == 1)
                {
                    brojac++;
                }
            }
            string mjesec = DateTime.Now.ToString("MM");
            string dan = DateTime.Now.ToString("dd");
            string godina = DateTime.Now.ToString("yyyy");
            string sifraDokumenta = "NAR/0" + brojac + "-" + mjesec + "/" + dan + "/" + godina;
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

        private void DohvatiPartnere()
        {
            BindingList<poslovniPartner> partner = null;
            partner = new BindingList<poslovniPartner>(db.poslovniPartner.ToList());
            poslovniPartnerBindingSource.DataSource = partner;
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
    
        private void btnZatvoriNar_Click(object sender, EventArgs e)
        {
            this.Close();
            db.Dispose();
            db = null;
        }

        private void Narudžbenica_Load(object sender, EventArgs e)
        {
            this.artiklTableAdapter.Fill(this.pISkladiste2DataSet.Artikl);
            DohvatiZaposlenike();
            DohvatiPartnere();
            DohvatiArtikle();
            generirajSifru();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dgvPrikaz.Columns[3].DefaultCellStyle = stil;
            this.dgvPrikaz.Columns[4].DefaultCellStyle = stil;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kolicina;
                if (cmbKolicina.Text == "")
                {
                    kolicina = 0;
                }
                else
                {
                    kolicina = int.Parse(cmbKolicina.Text);
                }
                float ukupno = kolicina * float.Parse(cmbCijena.Text);
                dgvPrikaz.Rows.Add(cmbSifra.Text, cmbNaziv.Text, kolicina, float.Parse(cmbCijena.Text), ukupno);
            }
            catch
            {
                MessageBox.Show("Stavka nije dodana!");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datumNarudzbenice = dtpKreiranje.Value;
            this.Text = datumNarudzbenice.ToString();
            int idNarudzbenice;
            try
            {

                using (var db = new PISkladiste2Entities())
                {
                    eksterniDokument narudzbenica = new eksterniDokument
                    {
                        datum = datumNarudzbenice,
                        sifra = txtSifraNar.Text,
                        vrsta = 1,
                        izradio = int.Parse(imeComboBox.SelectedValue.ToString()),
                        poslovni_partner = int.Parse(cmbNazivPartner.SelectedValue.ToString())

                    };
                    db.eksterniDokument.Add(narudzbenica);

                    db.SaveChanges();
                    idNarudzbenice = narudzbenica.id_dokumenta;

                }
                int artiklID = 0;
                int kolicinaArtikla = 0;
                decimal cijena = 0;
                foreach (DataGridViewRow row in this.dgvPrikaz.Rows)
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
                            stavke_eksternogDokumenta stavke = new stavke_eksternogDokumenta
                            {
                                id_artikla = artiklID,
                                id_dokumenta = idNarudzbenice,
                                kolicina = kolicinaArtikla,
                                cijena_artikla = cijena
                            };
                            db1.stavke_eksternogDokumenta.Add(stavke);
                            db1.SaveChanges();

                        }
                    }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Spremanje nije uspijelo!");
            }
        }


        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in this.dgvPrikaz.SelectedRows)
            {
                dgvPrikaz.Rows.RemoveAt(red.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
