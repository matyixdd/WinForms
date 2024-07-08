using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GondorMatyasDiak
{
    public partial class Form1 : Form
    {
        class Diak
        {
            private string Nev { get; set; }
            private string tanulKod { get; set; }
            public int Ev { get; set; }


            public Diak(string nev, string tanulKod, int ev)
            {
                this.Nev = nev;
                this.tanulKod = tanulKod;
                this.Ev = ev;
            }

            public override string ToString()
            {
                return Nev + tanulKod + Ev;
            }
        }
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";

        }
        List<Diak> diakok = new List<Diak>();
        List<CheckBox> chkBoxok = new List<CheckBox>();
        StreamReader sr = new StreamReader("diakok.txt");
        List<int> evek = new List<int>();
        List<Button> btnEvek = new List<Button>();
        int kezdoX = 15;
        int kezdoY = 15;
        int chkYKoz = 25;
        int btnXKoz = 25;
        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }
        private void GombBeallitas(bool aktiv)
        {
            btnAdatBe.Enabled = !aktiv;
        }
        private void Adatbevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(sr);
                    GombBeallitas(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("hiba fajlread", "hiba");
                }
            }
        }
        private void AdatBeolvasas(StreamReader sr)
        {
            string adat;
            while (!sr.EndOfStream)
            {
                adat = sr.ReadLine();
                Feldolgoz(adat);
            }

        }
        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak;
            diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            lstDiakok.Items.Add(diak);
            if (!evek.Contains(diak.Ev))
            {
                evek.Add(diak.Ev);
            }
        }
        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();
                btn.Click += new System.EventHandler(Kivalaszt);
                pnlEvek.Controls.Add(btn);
                btnEvek.Add(btn);
            }
        }
        private void Kivalaszt(object sender, EventArgs e)
        {
            int ev = int.Parse((sender as Button).Text);

            lstEredmeny.Items.Clear();
            foreach (Diak diak in lstDiakok.Items)
            {
                if (diak.Ev == ev)
                {
                    lstEredmeny.Items.Add(diak);
                }
            }
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }
    }
}
