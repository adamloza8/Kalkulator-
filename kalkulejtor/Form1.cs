using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulejtor
{
    public partial class Form1 : Form
    {
        double PierwszaLiczba;
        string Dzialanie;
        public Form1()
        {
            InitializeComponent();
        }


        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bdodaj_Click(object sender, EventArgs e)
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "+";
        }

        private void bodejmij_Click(object sender, EventArgs e)
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "-";

        }

        private void bmnoz_Click(object sender, EventArgs e)
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "*";
        }

        private void bdziel_Click(object sender, EventArgs e)
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Dzialanie = "/";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void nprzecinek_Click(object sender, EventArgs e)
        {
            char a = Convert.ToChar(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            textBox1.Text = textBox1.Text + a;
        }
        private void wynik()
        {
            double DrugaLiczba;
            double Result;

            DrugaLiczba = Convert.ToDouble(textBox1.Text);

            if (Dzialanie == "+")
            {
                Result = (PierwszaLiczba + DrugaLiczba);
                textBox1.Text = Convert.ToString(Result);
                PierwszaLiczba = Result;
            }
            if (Dzialanie == "-")
            {
                Result = (PierwszaLiczba - DrugaLiczba);
                textBox1.Text = Convert.ToString(Result);
                PierwszaLiczba = Result;
            }
            if (Dzialanie == "*")
            {
                Result = (PierwszaLiczba * DrugaLiczba);
                textBox1.Text = Convert.ToString(Result);
                PierwszaLiczba = Result;
            }
            if (Dzialanie == "/")
            {
                if (DrugaLiczba == 0)
                {
                    textBox1.Text = "Nie można dzielić przez 0!";

                }
                else
                {
                    Result = (PierwszaLiczba / DrugaLiczba);
                    textBox1.Text = Convert.ToString(Result);
                    PierwszaLiczba = Result;
                }
            }
            if (Dzialanie == "P")
            {
                Result = Math.Sqrt(PierwszaLiczba);
                textBox1.Text = Convert.ToString(Result);
                PierwszaLiczba = Result;
            }
            if (Dzialanie == "X")
            {
                Result = Math.Pow(PierwszaLiczba,2);
                textBox1.Text = Convert.ToString(Result);
                PierwszaLiczba = Result;
            }
        }

        private void nrownasie_Click(object sender, EventArgs e)
        {
            wynik();
        }

        private void bPierwiastkowanie_Click(object sender, EventArgs e)
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            Dzialanie = "P";
            wynik();
        }

        private void bPotegowanie_Click(object sender, EventArgs e)
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            Dzialanie = "X";
            wynik();
        }

        

        private void bCzysc_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            int i = textBox1.Text.Length;
            textBox1.Text = textBox1.Text.Substring(0, i - 1);
        }
    }
}