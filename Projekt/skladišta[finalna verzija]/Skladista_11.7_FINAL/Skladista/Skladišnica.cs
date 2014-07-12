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
    public partial class Skladišnica : Form
    {
        public Skladišnica()
        {
            InitializeComponent();
        }
        private void generirajSifru(){//Generiranje šifre za skladišnicu
            List<interniDokument> dokumenti = null;
            using (var db = new PISkladiste2Entities())
            {
                dokumenti = new List<interniDokument>(db.interniDokument.ToList());
            }
            int brojac = 1; //brojač za broj skladišnica spremljenih u bazi
            foreach (var skladisnica in dokumenti)
            {
                if (skladisnica.vrsta == 1) {
                    brojac++;
                }
            }
            
            string mjesec = DateTime.Now.ToString("MM");
            string dan = DateTime.Now.ToString("dd");
            string godina = DateTime.Now.ToString("yyyy");
            string sifraDokumenta = "SKL/0" + brojac + "-" + mjesec + "/" + dan + "/" + godina ;
            txtSifraSkl.Text = sifraDokumenta;
          
        }

        private void DohvatiArtikle()
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
 
        private void Skladišnica_Load(object sender, EventArgs e)
        {
            
            this.artiklTableAdapter.Fill(this.pISkladiste2DataSet.Artikl);
            DohvatiZaposlenike();
            DohvatiArtikle();
            generirajSifru();
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dgvPrikaz.Columns[3].DefaultCellStyle = stil;
            this.dgvPrikaz.Columns[4].DefaultCellStyle = stil;
            
          
        }    
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow red in this.dgvPrikaz.SelectedRows)
                {
                    dgvPrikaz.Rows.RemoveAt(red.Index);
                }
            }
            catch
            {                             
            }

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DateTime datumSkladisnice = dtpDatumKreiranja.Value; //datum kreiranja, iz forme
            this.Text = datumSkladisnice.ToString();
            int idSkladisnice;
            //Prvo spremamo dokument
            try
            {
                using (var db = new PISkladiste2Entities())
                {
                    interniDokument skladisnica = new interniDokument
                    {

                        datum = datumSkladisnice,
                        sifra = txtSifraSkl.Text,
                        vrsta = 1,
                        izradio = int.Parse(txtIzradioIme.SelectedValue.ToString())

                    };
                    db.interniDokument.Add(skladisnica);

                    db.SaveChanges();
                    idSkladisnice = skladisnica.id_dokumenta;
                }
                int artiklID = 0;
                int kolicinaArtikla = 0;
                decimal cijena = 0;
                //prolazak dataGridom i spremanje stavki u bazu
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

                            stavke_internogDokumenta stavke = new stavke_internogDokumenta
                            {

                                id_artikla = artiklID,
                                id_dokumenta = idSkladisnice,
                                kolicina = kolicinaArtikla,
                                cijena_artikla = cijena
                            };
                            db1.stavke_internogDokumenta.Add(stavke);
                            db1.SaveChanges();
                            //Dohvaćanje artikla koji se nalazi na stavki skladišnice i povećavanje stanja na skladištu nakon spremanja skladišnice
                            Artikl artikl = (from t in db1.Artikl
                                             where t.sifra == artiklID
                                             select t).First<Artikl>();
                            int kolicinaArtiklaSkladiste = (int)artikl.kolicina;
                            kolicinaArtiklaSkladiste += kolicinaArtikla;
                            db1.Artikl.Attach(artikl);
                            artikl.kolicina = kolicinaArtiklaSkladiste;
                            db1.SaveChanges();


                        }

                    }

                }
                this.Close();
            }
            catch 
            {
            }
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kolicina;
                if (txtKolicina.Text == "")
                {
                    kolicina = 0;
                }
                else
                {
                    kolicina = int.Parse(txtKolicina.Text);
                }
                float ukupno = kolicina * float.Parse(cmbCijena.Text);
                dgvPrikaz.Rows.Add(cmbSifraArtikla.Text, cmbNazivArtikla.Text, kolicina,  float.Parse(cmbCijena.Text), ukupno);

            }
            catch 
            {
                MessageBox.Show("Stavka nije dodana!");
            }
        }

        

      
       
    }
}
