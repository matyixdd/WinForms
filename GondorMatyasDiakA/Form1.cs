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
        int kezdoX = 15;
        int kezdoY = 15;
        int chkYKoz = 25;
        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }
        private void GombBeallitas(bool aktiv)
        {
            btnAdatBe.Enabled = !aktiv;
            btnKivalasztas.Enabled = aktiv;
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
                    FelrakDiakok();
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

            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }
        private void FelrakDiakok()
        {
            CheckBox chkBox;

            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chkYKoz);
                chkBox.Text = diakok[i].ToString();

                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnKivalasztas_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott)
            {
                MessageBox.Show("Senkit sem választott", "Hiba");

            }
            else
            {
                MinKeres();
            }
        }
        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int min = (lstKivalasztottak.Items[0] as Diak).Ev;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.Ev < min)
                {
                    min = diak.Ev;
                }
                
            }
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.Ev == min)
                {
                    lstLegidosebbek.Items.Add(diak);
                }
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null)
            {
                lblKivalasztott.Text = diak + ". születési éve:" + diak.Ev;
            }
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            Adatbevitel();
        }
    }
}
