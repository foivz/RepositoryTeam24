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
    public partial class UpravljanjeKorisnicima : Form
    {
        public UpravljanjeKorisnicima()
        {
            InitializeComponent();
        }
        private void DohvatiKorisnike()
        {
            BindingList<Zaposlenik> korisnici = null;
            using (var db = new PISkladiste2Entities())
            {
                korisnici = new BindingList<Zaposlenik>(db.Zaposlenik.ToList());
            }
            zaposlenikBindingSource.DataSource = korisnici;
        }
        private void DohvatiVrsteKorisnika()
        {
            BindingList<Uloga> vrste = null;
            using (var db = new PISkladiste2Entities())
            {
                vrste = new BindingList<Uloga>(db.Uloga.ToList());
            }
            ulogaBindingSource.DataSource = vrste;
        }

        private void UpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            DohvatiKorisnike();
            DohvatiVrsteKorisnika();
        }

        private void Kreiraj_Click(object sender, EventArgs e)
        {
            Korisnici prozor = new Korisnici();
            prozor.ShowDialog();
            DohvatiKorisnike();
            DohvatiVrsteKorisnika();
            
        }

        private void txtPretraziIme_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraziIme.Text != null)
            {
                BindingList<Zaposlenik> korisnici = null;
                using (var db = new PISkladiste2Entities())
                {

                    IEnumerable<Zaposlenik> korisnik = from p in db.Zaposlenik
                                                             where p.ime.Contains(txtPretraziIme.Text)
                                                             select p;
                    korisnici = new BindingList<Zaposlenik>(korisnik.ToList());

                }
                zaposlenikBindingSource.DataSource = korisnici;

            }
            else
            {
                DohvatiKorisnike();
                DohvatiVrsteKorisnika();
            }
        }

        private void txtPretraziPrezime_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraziPrezime.Text != null)
            {
                BindingList<Zaposlenik> korisnici = null;
                using (var db = new PISkladiste2Entities())
                {

                    IEnumerable<Zaposlenik> korisnik = from p in db.Zaposlenik
                                                       where p.prezime.Contains(txtPretraziPrezime.Text)
                                                       select p;
                    korisnici = new BindingList<Zaposlenik>(korisnik.ToList());

                }
                zaposlenikBindingSource.DataSource = korisnici;

            }
            else
            {
                DohvatiKorisnike();
                DohvatiVrsteKorisnika();
            }
        }

        private void Azuriraj_Click(object sender, EventArgs e)
        {

            Zaposlenik selektiraniKorisnik= zaposlenikBindingSource.Current as Zaposlenik;
            if (selektiraniKorisnik!= null)
            {
                Korisnici forma = new Korisnici(selektiraniKorisnik);

                forma.ShowDialog();

            }
            DohvatiKorisnike();
            DohvatiVrsteKorisnika();


        }
    }
}
