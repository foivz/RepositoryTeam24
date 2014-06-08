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
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
        }
        private void PrikaziKorisnike() { 
            BindingList<Zaposlenik> korisnici = null;
            using (var db = new PISkladiste2Entities()) 
            { 

                korisnici= new BindingList<Zaposlenik>(db.Zaposlenik.ToList()); 

            }
            zaposlenikBindingSource.DataSource = korisnici; 
        }
        private void PrikaziUloge()
        {
            BindingList<Uloga> uloge = null;
            using (var db = new PISkladiste2Entities())
            {

                uloge = new BindingList<Uloga>(db.Uloga.ToList());

            }
            ulogaBindingSource.DataSource = uloge;
        }
        private void txtPrezimeKor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new PISkladiste2Entities())
            { //Kreiramo novi objekt klase Zaposlenik i popunjavamo ga podacima sa forme. 
                Zaposlenik korisnik = new Zaposlenik
                {
                    ime = txtImeKor.Text,
                    prezime = txtPrezimeKor.Text,
                    korisnicko_ime = txtKorImeKor.Text,
                    lozinka = txtLozinkaKor.Text,
                    uloga = int.Parse(cmbUloga.SelectedValue.ToString())
                };
                db.Zaposlenik.Add(korisnik); //Dodajemo korisnika u odgovarajuću kolekciju u kontekstu. db.SaveChanges(); //Spremamo napravljene promjene u bazu podataka. } 
                
                db.SaveChanges();
                
            }
            Close();
            MessageBox.Show("Korisnik je kreiran");
            
        }

        private void Korisnici_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
            PrikaziUloge();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
