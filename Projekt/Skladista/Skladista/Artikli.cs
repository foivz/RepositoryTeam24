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
        private void PrikaziArtikle()
        {
            BindingList<Artikl> korisnici = null;
            using (var db = new PISkladiste2Entities())
            {

                korisnici = new BindingList<Artikl>(db.Artikl.ToList());

            }
            artiklBindingSource.DataSource = korisnici;
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
            PrikaziArtikle();
            PrikaziPododjela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new PISkladiste2Entities())
            { //Kreiramo novi objekt klase Zaposlenik i popunjavamo ga podacima sa forme. 
                Artikl artikl = new Artikl
                {
                    nabavna_cijena = decimal.Parse(txtNabavnaCijena.Text),
                    naziv = txtNaziv.Text,
                  //  kolicina = int.Parse(txtKolicina.Text),
                    minimalna_kolicina = int.Parse(txtMinKolicina.Text),
                    pododjel = int.Parse(cmbPododjel.SelectedValue.ToString())

                };
                db.Artikl.Add(artikl); //Dodajemo korisnika u odgovarajuću kolekciju u kontekstu. db.SaveChanges(); //Spremamo napravljene promjene u bazu podataka. } 
                db.SaveChanges();
            }
            Close();
            MessageBox.Show("Artikl je kreiran!");
            
        }

       

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNabavnaCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char znak = e.KeyChar;

            if (znak == 46 && txtNabavnaCijena.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(znak) && znak != 8 && znak != 46)
            {

                e.Handled = true;

            }

        }
    }
}
