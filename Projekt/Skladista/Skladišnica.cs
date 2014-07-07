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
        private void generirajSifru(){
            List<interniDokument> dokumenti = null;
            using (var db = new PISkladiste2Entities())
            {
                dokumenti = new List<interniDokument>(db.interniDokument.ToList());
            }
            int brojac = 1;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Skladišnica_Load(object sender, EventArgs e)
        {
            
            this.artiklTableAdapter.Fill(this.pISkladiste2DataSet.Artikl);
            DohvatiZaposlenike();
            DohvatiArtikle();
            generirajSifru();
            
          
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int kolicina;
            if (textBox3.Text == "")
            {
                 kolicina = 0;
            }
            else {
                 kolicina = int.Parse(textBox3.Text);
            }
            float ukupno = kolicina * float.Parse(comboBox3.Text);
            dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, textBox3.Text, comboBox3.Text,ukupno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datumSkladisnice = dateTimePicker1.Value;
            this.Text = datumSkladisnice.ToString();
            int idSkladisnice;
            

                using (var db = new PISkladiste2Entities())
                {
                    interniDokument skladisnica = new interniDokument
                    {

                        datum = datumSkladisnice,
                        sifra = txtSifraNar.Text,
                        vrsta = 1,
                        izradio = int.Parse(izradioDokument.SelectedValue.ToString())

                    };
                    db.interniDokument.Add(skladisnica);

                    db.SaveChanges();
                    idSkladisnice = skladisnica.id_dokumenta;




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
                                id_dokumenta = idSkladisnice,
                                kolicina = kolicinaArtikla,
                                cijena_artikla = cijena
                            };
                            db1.stavke_internogDokumenta.Add(stavke);
                            db1.SaveChanges();
                            //Dohvaćanje artikla koji se nalazi na stavki skladišnice
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

        

        private void txtSifraNar_TextChanged(object sender, EventArgs e)
        {

        }

        private void izradioDokument_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

      
       
    }
}
