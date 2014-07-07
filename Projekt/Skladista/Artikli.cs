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
            // TODO: This line of code loads data into the 'pISkladiste2DataSet.Pododjel' table. You can move, or remove it, as needed.
            this.pododjelTableAdapter.Fill(this.pISkladiste2DataSet.Pododjel);

            if (azurirajArtikla != null){
                txtSifraKor.Text = azurirajArtikla.sifra.ToString();
                txtMinKolicina.Text = azurirajArtikla.kolicina.ToString();
                txtNaziv.Text = azurirajArtikla.naziv;
                txtMinKolicina.Text = azurirajArtikla.minimalna_kolicina.ToString();
                txtCijena.Text =azurirajArtikla.nabavna_cijena.ToString();
                }

               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idArtikla;
          
          
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
                        kolicina = int.Parse(txtKolicina.ToString())

                    };
                    db.Artikl.Add(artikl);
                    db.SaveChanges();
                    idArtikla = artikl.sifra;
                }
               

          
                Close();
                MessageBox.Show("Artikl je kreiran!");
            }
            else if (azurirajArtikla != null) {
                idArtikla = azurirajArtikla.sifra;
                using (var db = new PISkladiste2Entities())
                {
                    db.Artikl.Attach(azurirajArtikla);
                    azurirajArtikla.nabavna_cijena = decimal.Parse(txtCijena.Text);
                    azurirajArtikla.naziv = txtNaziv.Text;
                    azurirajArtikla.minimalna_kolicina = int.Parse(txtMinKolicina.Text);
                    azurirajArtikla.pododjel = int.Parse(cmbPododjel.SelectedValue.ToString());
                    azurirajArtikla.kolicina  = int.Parse(txtKolicina.Text);
                    db.SaveChanges();
                
                }
           
                Close();
                MessageBox.Show("Artikl je ažuriran!");
                
            }            
        }

       

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  char znak = e.KeyChar;

            if (znak == 46 && txtCijena.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(znak) && znak != 8 && znak != 46)
            {

                e.Handled = true;

            }*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //metoda koja dozvoljava samo upis brojeva i jedne točke
       

    }
}
