using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objektno
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Vozilo
        {
            public int stKoles;
            public string imeLastnika;
            public string priimekLastnika;

            public Vozilo()
            {
                imeLastnika = "joze";
                priimekLastnika = "gaj";
                stKoles = 0;
            }

            public Vozilo(int gume)
            {
                imeLastnika = "David";
                priimekLastnika = "Škulj";
                stKoles = gume;
            }

            public Vozilo(int gume, string jme, string prijmek)
            {
                imeLastnika = jme;
                priimekLastnika = prijmek;
                stKoles = gume;
            }

            void zameji(string jme, string prijmek)
            {
                imeLastnika = jme;
                priimekLastnika = prijmek;
            }

            string Izpisi()
            {
                return imeLastnika + " " + priimekLastnika;
            }

            int vVisjoBrzino(int brzina)
            {
                return brzina = brzina + 1;
            }

            int vNizjoBrzino(int brzina)
            {
                return brzina = brzina - 1;
            }

            string potrobi(string potrobi)
            {
                return potrobi;
            }
        }

        public class Avto : Vozilo
        {
            char masina;
            int stVrat;
            int ccm, brzine;
        }

        public class Kolo : Vozilo
        {
            int brzine;
            bool blatnik;
            char spol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer tajmer = new Timer();
            tajmer.Interval = 10;
            tajmer.Tick += new EventHandler(timer_tick);
            tajmer.Start();
            uraLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_tick(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
            Invalidate();
        }
    }
}