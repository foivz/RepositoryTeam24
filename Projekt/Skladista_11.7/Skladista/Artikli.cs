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
    public partial class Artikli : Form
    {
        public Artikli()
        {
            InitializeComponent();

        }
        private Artikl azurirajArtikla = null;
        
        public Artikli(Artikl str)
        {
            InitializeComponent();
            azurirajArtikla = str;
        }
        
        //Metoda za dohvaćanje pododjela iz baze podataka i prikazivanje pododjela u padajućem izborniku "Mjerna jedinica"
        private void PrikaziPododjela()
        {
            BindingList<Pododjel> pododjeli = null;
            using (var db = new PISkladiste2Entities())
            {

                pododjeli = new BindingList<Pododjel>(db.Pododjel.ToList());

            }
            pododjelBindingSource.DataSource = pododjeli;
        }
       
        private void Artikli_Load(object sender, EventArgs e)
        {           
            this.pododjelTableAdapter.Fill(this.pISkladiste2DataSet.Pododjel);
            if (azurirajArtikla != null){
                txtSifraArt.Text = azurirajArtikla.sifra.ToString();
                txtMinKolicina.Text = azurirajArtikla.kolicina.ToString();
                txtNaziv.Text = azurirajArtikla.naziv;
                txtMinKolicina.Text = azurirajArtikla.minimalna_kolicina.ToString();
                txtCijena.Text = String.Format("{0:0,0.00}", azurirajArtikla.nabavna_cijena);
                }

               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idArtikla;
            try
            {
                if (azurirajArtikla == null)
                {
                    using (var db = new PISkladiste2Entities())
                    {
                        Artikl artikl = new Artikl
                        {
                            nabavna_cijena = decimal.Parse(txtCijena.Text),
                            naziv = txtNaziv.Text,
                            minimalna_kolicina = int.Parse(txtMinKolicina.Text),
                            pododjel = int.Parse(cmbPododjel.SelectedValue.ToString()),
                            kolicina = 0
                        };
                        db.Artikl.Add(artikl);
                        db.SaveChanges();
                        idArtikla = artikl.sifra;
                    }

                    Close();
                    MessageBox.Show("Artikl je kreiran!");
                }
                else if (azurirajArtikla != null)
                {
                    idArtikla = azurirajArtikla.sifra;
                    using (var db = new PISkladiste2Entities())
                    {
                        db.Artikl.Attach(azurirajArtikla);
                        azurirajArtikla.nabavna_cijena = decimal.Parse(txtCijena.Text);
                        azurirajArtikla.naziv = txtNaziv.Text;
                     //   azurirajArtikla.kolicina = int.Parse(txtKolicina.Text);
                        azurirajArtikla.minimalna_kolicina = int.Parse(txtMinKolicina.Text);
                        azurirajArtikla.pododjel = int.Parse(cmbPododjel.SelectedValue.ToString());
                        db.SaveChanges();

                    }

                    Close();
                    MessageBox.Show("Artikl je ažuriran!");

                }
            }
            catch {
                MessageBox.Show("Javila se greška!");
            }
        }

       

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
