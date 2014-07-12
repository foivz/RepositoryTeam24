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
    public partial class DodajStavku_eksterni : Form
    {
        private eksterniDokument trenutniDokument;
        private stavke_eksternogDokumenta artiklZaIzmjenu;
        public DodajStavku_eksterni(eksterniDokument dokument)
        {
            InitializeComponent();
            trenutniDokument = dokument;
        }

        public DodajStavku_eksterni(stavke_eksternogDokumenta artikl, eksterniDokument dokument)
        {
            InitializeComponent();
            artiklZaIzmjenu = artikl;
            trenutniDokument = dokument;
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

   

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PISkladiste2Entities())
                {
                    int idArtikla = int.Parse(cmbSifra.SelectedValue.ToString());
                    Artikl cijena = new Artikl();
                    cijena = (from p in db.Artikl
                              where p.sifra == idArtikla
                              select p).First();
                    if (artiklZaIzmjenu == null)
                    {
                        db.eksterniDokument.Attach(trenutniDokument);
                        stavke_eksternogDokumenta stavke = new stavke_eksternogDokumenta
                        {

                            id_artikla = int.Parse(cmbSifra.SelectedValue.ToString()),
                            id_dokumenta = int.Parse(trenutniDokument.id_dokumenta.ToString()),
                            kolicina = int.Parse(cmbKolicina.Text.ToString()),
                            cijena_artikla = cijena.nabavna_cijena
                        };
                        db.stavke_eksternogDokumenta.Add(stavke);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.stavke_eksternogDokumenta.Attach(artiklZaIzmjenu);
                        artiklZaIzmjenu.id_dokumenta = int.Parse(trenutniDokument.id_dokumenta.ToString());
                        artiklZaIzmjenu.id_artikla = int.Parse(cmbSifra.SelectedValue.ToString());
                        artiklZaIzmjenu.kolicina = int.Parse(cmbKolicina.Text.ToString());
                        artiklZaIzmjenu.cijena_artikla = cijena.nabavna_cijena;
                        db.SaveChanges();

                    }


                }
                DohvatiArtikle();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Pokusajte ponovno");
            }
        }

        private void DodajStavku_eksterni_Load(object sender, EventArgs e)
        {

            DohvatiArtikle();
            if (artiklZaIzmjenu != null)
            {
                cmbSifra.Text = artiklZaIzmjenu.id_artikla.ToString();
                cmbKolicina.Text = artiklZaIzmjenu.kolicina.ToString();
                cmbSifra.Enabled = false;
                cmbNaziv.Enabled = false;
                cmbCijena.Enabled = false;
        


            }

        }

     
    }
}
