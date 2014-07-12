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
    public partial class dodajStavku : Form
    {
        private interniDokument trenutniDokument=null;
        private stavke_internogDokumenta artiklZaIzmjenu= null;
        public dodajStavku(interniDokument dokument )
        {
            InitializeComponent();
            trenutniDokument = dokument;
        }
        public dodajStavku(stavke_internogDokumenta artikl, interniDokument dokument)
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
                    int idArtikla = int.Parse(cmbSifra.SelectedValue.ToString()); // id artikla za izmjenu
                    Artikl cijena = new Artikl();// fohvaćanje cijene artikla
                    cijena = (from p in db.Artikl
                              where p.sifra == idArtikla
                              select p).First();


                    if (artiklZaIzmjenu == null) //ako artikla za izmjenu nema, dodajemo novi artikl
                    {


                        db.interniDokument.Attach(trenutniDokument);
                        stavke_internogDokumenta stavke = new stavke_internogDokumenta
                         {

                             id_artikla = int.Parse(cmbSifra.SelectedValue.ToString()),
                             id_dokumenta = int.Parse(trenutniDokument.id_dokumenta.ToString()),
                             kolicina = int.Parse(cmbKolicina.Text.ToString()),
                             cijena_artikla = cijena.nabavna_cijena
                         };
                        db.stavke_internogDokumenta.Add(stavke);
                        db.SaveChanges();
                        int IDArtikla1 = stavke.id_artikla;
                        if (trenutniDokument.vrsta == 1) //skladišnica
                        {

                            Artikl artikl = (from t in db.Artikl
                                             where t.sifra == IDArtikla1
                                             select t).First<Artikl>();
                            int kolicinaArtiklaSkladiste = (int)artikl.kolicina;
                            kolicinaArtiklaSkladiste += int.Parse(cmbKolicina.Text.ToString());
                            db.Artikl.Attach(artikl);
                            artikl.kolicina = kolicinaArtiklaSkladiste;
                            db.SaveChanges();

                        }
                        else
                        {//izdatnica
                            Artikl artikl = (from t in db.Artikl
                                             where t.sifra == IDArtikla1
                                             select t).First<Artikl>();
                            int kolicinaArtiklaSkladiste = (int)artikl.kolicina;
                            kolicinaArtiklaSkladiste -= int.Parse(cmbKolicina.Text.ToString());
                            db.Artikl.Attach(artikl);
                            artikl.kolicina = kolicinaArtiklaSkladiste;
                            db.SaveChanges();

                        }

                    }
                    // inače ažuriramo odabrani artikl
                    else
                    {
                        int kolicinaStavke = (int)artiklZaIzmjenu.kolicina;
                        ;
                        db.stavke_internogDokumenta.Attach(artiklZaIzmjenu);
                        artiklZaIzmjenu.id_dokumenta = int.Parse(trenutniDokument.id_dokumenta.ToString());
                        artiklZaIzmjenu.id_artikla = int.Parse(cmbSifra.SelectedValue.ToString());
                        artiklZaIzmjenu.kolicina = int.Parse(cmbKolicina.Text.ToString());
                        artiklZaIzmjenu.cijena_artikla = cijena.nabavna_cijena;
                        db.SaveChanges();


                        int IDArtikla = artiklZaIzmjenu.id_artikla;
                        if (trenutniDokument.vrsta == 1) //skladišnica
                        {

                            Artikl artikl = (from t in db.Artikl
                                             where t.sifra == IDArtikla
                                             select t).First<Artikl>();

                            int novaKolicina = int.Parse(cmbKolicina.Text.ToString());
                            int kolicinaArtiklaSkladiste = (int)artikl.kolicina;
                            kolicinaArtiklaSkladiste += (novaKolicina - kolicinaStavke);
                            db.Artikl.Attach(artikl);
                            artikl.kolicina = kolicinaArtiklaSkladiste;
                            db.SaveChanges();

                        }
                        else
                        {//izdatnica
                            Artikl artikl = (from t in db.Artikl
                                             where t.sifra == IDArtikla
                                             select t).First<Artikl>();

                            int novaKolicina = int.Parse(cmbKolicina.Text.ToString());
                            int kolicinaArtiklaSkladiste = (int)artikl.kolicina;
                            kolicinaArtiklaSkladiste -= (novaKolicina - kolicinaStavke);
                            db.Artikl.Attach(artikl);
                            artikl.kolicina = kolicinaArtiklaSkladiste;
                            db.SaveChanges();


                        }


                    }

                    db.SaveChanges();

                }

                DohvatiArtikle();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Javila se pogreška");
            }
        
        }

        private void dodajStavku_Load(object sender, EventArgs e)
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
