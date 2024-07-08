using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GondorMatyasPizza
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            lathato = false;
            LathatosagBeallitasa(lathato);

        }
        private int meretKicsi = 32, meretNagy = 45;

        private bool lathato;

        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>();
        private List<RadioButton> rdBntNagyArak = new List<RadioButton>();
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();

        private int bal = 20, fent = 10;
        private int kozY = 40;
        private int meretY = 20;
        private int panelX = 200;
        private int meretChk = 120;
        private int meretAr = 50;
        private int meretFt = 40;
        private int meretDb = 50;
        private int koz = 3;

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev =openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBeolvasas(sr);
                    ValasztekFeltoltes();
                    lathato=true;
                    AdatBevitel();
                    btnAdatBe.Visible = false;
                    this.BackgroundImage = null;
                    LathatosagBeallitasa(lathato);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hiba");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
        }
        private void AdatBevitel()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBeolvasas(sr);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Adatbeviteli hiba", "Hiba");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
        }
        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            RadioButton radioButton;
            Panel panel;
            TextBox textBox;

            for (int i = 0; i < pizzak.Count; i++)
            {
                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozY);
                checkBox.Size = new Size(meretChk, meretY);

                jeloloNegyzetek.Add(checkBox);

                pnlKozponti.Controls.Add(checkBox);

                panel = new Panel();
                panel.Size = new Size(panelX, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozY);

                pnlKozponti.Controls.Add(panel);

                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArKicsi.ToString();
                radioButton.Location = new Point(0, 0);
                rdBtnKicsiArak.Add(radioButton);

                panel.Controls.Add(radioButton);

                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = "Ft";
                label.Location = new Point(meretAr + koz, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);

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
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));
        }
        private void ElemekMegjelenitese()
        {
            lblKicsi.Text = meretKicsi + "cm";
            lblNagy.Text = meretKicsi + "cm";

            checkBox1.Text = pizzak[0].Nev;
            rdBtn1Kicsi.Text = pizzak[0].ArKicsi + "Ft";
            rdBtn1Nagy.Text = pizzak[0].ArNagy + "Ft";

            checkBox2.Text = pizzak[1].Nev;
            rdBtn2Kicsi.Text = pizzak[1].ArKicsi + "Ft";
            rdBtn2Nagy.Text = pizzak[1].ArNagy + "Ft";
        }


        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                int osszeg = 0, ar = 0, db = 0;
                if (checkBox1.Checked)
                {
                    if (rdBtn1Kicsi.Checked) ar = pizzak[0].ArKicsi;
                    else if (rdBtn1Nagy.Checked) ar = pizzak[0].ArNagy;
                    else throw new MissingFieldException("Válasszon méretet");
                    db = int.Parse(txtDb1.Text);
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;
                }

                if (checkBox2.Checked)
                {
                    if (rdBtn2Kicsi.Checked) ar = pizzak[1].ArKicsi;
                    else if (rdBtn2Nagy.Checked) ar = pizzak[1].ArNagy;
                    else throw new MissingFieldException("Válasszon méretet");
                    db = int.Parse(txtDb2.Text);
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;
                }

                if (!checkBox1.Checked && !checkBox2.Checked) throw new MissingFieldException();
                txtFizetendo.Text = osszeg + " Ft";
            }
            catch (FormatException)
            {
                MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
            }
            catch (ArgumentOutOfRangeException aox)
            {
                MessageBox.Show(aox.Message, "Hiba");
            }
            catch (MissingFieldException mex)
            {
                MessageBox.Show(mex.Message, "Hiba");
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item.HasChildren)
                {
                    foreach (Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton)
                        {
                            (gyerek as RadioButton).Checked = false;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LathatosagBeallitasa(false);
        }


        private void LathatosagBeallitasa(bool lathatoE)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }


        class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNagy { get; set; }

            public Pizza(string nev, int arKicsi, int arNagy)
            {
                this.Nev = nev;
                this.ArKicsi = arKicsi;
                this.ArNagy = arNagy;
            }
            public override string ToString()
            {
                return this.Nev;
            }
        }


        
    }
}
