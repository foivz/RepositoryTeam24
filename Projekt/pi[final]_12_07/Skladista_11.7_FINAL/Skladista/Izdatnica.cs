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

        //Metoda za generiranje šifre izdatnice koja, nakon što izgenerira šifru, istu prikazuje u polju šifre dokumenta u formi.
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
            txtSifraIzd.Text = sifraDokumenta;

        }

        private void DohvatiArtikle()
        {
            BindingList<Artikl> artikli = null;
            artikli = new BindingList<Artikl>(db.Artikl.ToList());
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
           /* BindingList<Zaposlenik> korisnici = null;
            korisnici = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());
            zaposlenikBindingSource.DataSource = korisnici;*/
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
            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            stil.Format = "C2";
            this.dgvPrikaz.Columns[2].DefaultCellStyle = stil;
            this.dgvPrikaz.Columns[3].DefaultCellStyle = stil;


        }

   

        //Zatvaranje forme
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metoda za brisanje podataka o artiklu u odabranom retku
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in this.dgvPrikaz.SelectedRows)
            {
                dgvPrikaz.Rows.RemoveAt(red.Index);
            }
        }
        //Metoda za pohranu izdatnice
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DateTime datumIzdatnice = dtpIzdatnica.Value;
            this.Text = datumIzdatnice.ToString();
            int idIzdatnice;

            try
            {
                //Kreiramo novi objekt klase interniDokument i popunjavamo ga sa podacima iz forme
                using (var db = new PISkladiste2Entities())
                {
                    interniDokument izdatnica = new interniDokument
                    {

                        datum = datumIzdatnice,
                        sifra = txtSifraIzd.Text,
                        vrsta = 2,
                        izradio = int.Parse(cmbPrezime.SelectedValue.ToString())

                    };
                    db.interniDokument.Add(izdatnica);//dodajemo izdatnicu u odgovarajuću kolekciju

                    db.SaveChanges();
                    idIzdatnice = izdatnica.id_dokumenta;
                }

                //

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

                            stavke_internogDokumenta stavke = new stavke_internogDokumenta
                            {

                                id_artikla = artiklID,
                                id_dokumenta = idIzdatnice,
                                kolicina = kolicinaArtikla,
                                cijena_artikla = cijena
                            };

                            //Dohvaćanje artikla koji se nalazi na stavki izdatnice
                            //Kreiranjem izdatnice smanjiva se količina na skladištu
                            Artikl artikl = (from t in db1.Artikl
                                             where t.sifra == artiklID
                                             select t).First<Artikl>();
                            int kolicinaArtiklaSkladiste = (int)artikl.kolicina;
                            kolicinaArtiklaSkladiste -= kolicinaArtikla;

                            //Ukoliko je količina veća od 0 dodaju se stavke i artikl 
                            if (kolicinaArtiklaSkladiste >= 0)
                            {
                                db1.stavke_internogDokumenta.Add(stavke);
                                db1.SaveChanges();
                                db1.Artikl.Attach(artikl);
                                artikl.kolicina = kolicinaArtiklaSkladiste;
                                db1.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Nema dovoljne količine na skladištu kod artikla:" + artikl.naziv + ". Ažurirajte izdatnicu!.");

                            }
                        }
                    }
                }

                this.Close();
            }
            catch
            {
                MessageBox.Show("Spremanje nije uspijelo");
            }
        }
        //Metoda za dodavanje unesenih informacija o artiklu u datagridview
    
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int kolicina;
                //Ukoliko količina nije unesena, upisat će se 0, a ako je, onda se upisiva uneseni broj
                if (txtKolicina.Text == "")
                {
                    kolicina = 0;
                }
                else
                {
                    kolicina = int.Parse(txtKolicina.Text);
                }
                //Množimo količinu u cijenu  i dodajemo informacije u datagridview
                float ukupno = kolicina * float.Parse(cmbCijena.Text);
                dgvPrikaz.Rows.Add(cmbSifra.Text, cmbNaziv.Text, kolicina, float.Parse(cmbCijena.Text), ukupno);
            }
            catch
            {
                MessageBox.Show("Dodavanje nije uspijelo!");
            }
        }

       
    }
}
