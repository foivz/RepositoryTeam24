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
        private Zaposlenik SelektiraniKorisnik= null;
        public Korisnici(Zaposlenik str)
        {
            SelektiraniKorisnik = str;
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

        private void Korisnici_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
            PrikaziUloge();
            if (SelektiraniKorisnik != null)
            {
                txtSifraKor.Text = SelektiraniKorisnik.sifra.ToString();
                txtPrezimeKor.Text = SelektiraniKorisnik.prezime.ToString();
                txtImeKor.Text = SelektiraniKorisnik.ime.ToString();
                txtKorImeKor.Text = SelektiraniKorisnik.korisnicko_ime.ToString();
                txtLozinkaKor.Text = SelektiraniKorisnik.lozinka.ToString();
                cmbUloga.SelectedValue = (int)SelektiraniKorisnik.uloga;
            }
            
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (SelektiraniKorisnik == null)
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
            else
            {
                using (var db = new PISkladiste2Entities())
                {
                    db.Zaposlenik.Attach(SelektiraniKorisnik);
                    SelektiraniKorisnik.ime = txtImeKor.Text;
                    SelektiraniKorisnik.prezime = txtPrezimeKor.Text;
                    SelektiraniKorisnik.korisnicko_ime = txtKorImeKor.Text;
                    SelektiraniKorisnik.lozinka = txtLozinkaKor.Text;
                    SelektiraniKorisnik.uloga = int.Parse(cmbUloga.SelectedValue.ToString());
                    db.SaveChanges();
                }

                Close();
                MessageBox.Show("Korisnik je ažuriran!");
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
