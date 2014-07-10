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
    public partial class GrafičkiPrikaz : Form
    {

        private int postotnaKolicinaMetri;
        private int postotnaKolicinaKomadi;
        private int postotnaKolicinaKilogrami;

        public GrafičkiPrikaz(int trenutnoMetara, int maxMetara, int trenutnoKom, int maxKom, int trenutnoKg, int maxKg)
        {
            InitializeComponent();
            postotnaKolicinaMetri = (int)((float)trenutnoMetara / maxMetara * 100);
            postotnaKolicinaKomadi = (int)((float)trenutnoKom / maxKom * 100);
            postotnaKolicinaKilogrami = (int)((float)trenutnoKg / maxKg * 100);

            podskladisteKilogrami_lbl.Text = "";
            podskladisteKomadi_lbl.Text = "";
            podskladisteMetri_lbl.Text = "";

            iscrtajKolicine();
        }


        private void iscrtajKolicine()
        {
            // dodajemo skladišta i postotne količine u polja radi jednostavnije manipulacije
            List<Label> skladista = new List<Label>();
            List<int> postotneKolicine = new List<int>();

            skladista.Add(podskladisteMetri_lbl);
            skladista.Add(podskladisteKomadi_lbl);
            skladista.Add(podskladisteKilogrami_lbl);

            postotneKolicine.Add(postotnaKolicinaMetri);
            postotneKolicine.Add(postotnaKolicinaKomadi);
            postotneKolicine.Add(postotnaKolicinaKilogrami);


            // kroz for petlju obojamo sve labele i podesimo njihovu širinu (da odgovara količinskom stanju)
            for (int i = 0; i < 3; i++)
            {
                // najprije podešavamo širinu labela (koja predstavlja količinu na nekom od skladišta)
                // vrijednosti su od 1 do 100
                for (int j = 0; j < postotneKolicine[i]; j++)
                {
                    skladista[i].Text += " ";
                }


                // potom bojamo količine skladišta
                if (postotneKolicine[i] <= 25)
                    skladista[i].BackColor = Color.Red;
                else if (postotneKolicine[i] <= 50)
                    skladista[i].BackColor = Color.Orange;
                else if (postotneKolicine[i] <= 75)
                    skladista[i].BackColor = Color.Yellow;
                else
                    skladista[i].BackColor = Color.LimeGreen;
            }
        }

        private void GrafičkiPrikaz_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
