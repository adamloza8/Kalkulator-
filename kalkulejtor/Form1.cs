using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kalkulejtor
{
    public partial class Form1 : Form
    {
        double PierwszaLiczba;
        string Dzialanie;
        System.Collections.Stack st; 

        public Form1()
        {
            st = new System.Collections.Stack();
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
            PrzypiszPierwszaLiczbe();
            textBox1.Text = "0";
            Dzialanie = "+";
        }

        private void bodejmij_Click(object sender, EventArgs e)
        {
            PrzypiszPierwszaLiczbe();
            textBox1.Text = "0";
            Dzialanie = "-";

        }

        private void bmnoz_Click(object sender, EventArgs e)
        {
            PrzypiszPierwszaLiczbe();
            textBox1.Text = "0";
            Dzialanie = "*";
        }

        private void bdziel_Click(object sender, EventArgs e)
        {
            PrzypiszPierwszaLiczbe();
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
            using (StreamWriter sw = new StreamWriter("historia.txt", true))
            {
                double DrugaLiczba;
                double Result=0;
                sw.Write(PierwszaLiczba);
                bool MonoArgument = false;
                DrugaLiczba = Convert.ToDouble(textBox1.Text);



                if (Dzialanie == "+")
                {
                    sw.Write("+" + DrugaLiczba);
                    Result = (PierwszaLiczba + DrugaLiczba);
                    textBox1.Text = Convert.ToString(Result);
                    sw.WriteLine("=" + Result);
                }
                if (Dzialanie == "-")
                {
                    sw.Write("-" + DrugaLiczba);
                    Result = (PierwszaLiczba - DrugaLiczba);
                    textBox1.Text = Convert.ToString(Result);
                    sw.WriteLine("=" + Result);

                }
                if (Dzialanie == "*")
                {
                    sw.Write("*" + DrugaLiczba);
                    Result = (PierwszaLiczba * DrugaLiczba);
                    textBox1.Text = Convert.ToString(Result);
                    sw.WriteLine("=" + Result);

                }
                if (Dzialanie == "/")
                {
                    sw.Write("/" + DrugaLiczba);

                    if (DrugaLiczba == 0)
                    {
                        textBox1.Text = "Nie można dzielić przez 0!";

                    }
                    else
                    {
                        Result = (PierwszaLiczba / DrugaLiczba);
                        textBox1.Text = Convert.ToString(Result);
                        sw.WriteLine("=" + Result);

                    }
                }

                String label = "";
                if (Dzialanie == "P")
                {
                    sw.Write("P" + DrugaLiczba);
                    label = "Pierwiastek z {0}";
                    Result = Math.Sqrt(PierwszaLiczba);
                    textBox1.Text = Convert.ToString(Result);
                    sw.WriteLine("=" + Result);
                    MonoArgument = true;
                }
                if (Dzialanie == "X")
                {
                    sw.Write("X" + DrugaLiczba);                       
                    label = "Potęga (liczby{0}, stopnia 2)";
                    Result = Math.Pow(PierwszaLiczba, 2);
                    textBox1.Text = Convert.ToString(Result);
                    sw.WriteLine("=" + Result);
                    MonoArgument = true;
                }
                
                button21.Visible = true;
                if(MonoArgument) richTextBox1.AppendText("\n"+String.Format(label, PierwszaLiczba) + " = " + Result); 
                else richTextBox1.AppendText("\n" + PierwszaLiczba + " " + Dzialanie + " " + DrugaLiczba + " = " + Result);
                PierwszaLiczba = Result;
                
                st.Push(Result);
            }
            
        }
        private void nrownasie_Click(object sender, EventArgs e)
        {
            wynik();
        }

        private void bPierwiastkowanie_Click(object sender, EventArgs e)
        {
            PrzypiszPierwszaLiczbe();
            Dzialanie = "P";
            wynik();
        }

        private void bPotegowanie_Click(object sender, EventArgs e)
        {
            PrzypiszPierwszaLiczbe();
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

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Brak poprzednich działań";
            }
            richTextBox1.Visible = false;
            richTextBox1.ScrollBars = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (st.Count > 1)
            {
                st.Pop();
                textBox1.Text = Convert.ToString(st.Peek());
                var i = richTextBox1.Text.LastIndexOf("\n");
                if (i > -1)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = richTextBox1.Text.Length - i + 1;
                    richTextBox1.SelectedText = "";
                }
            }
            else
            {
                textBox1.Text = Convert.ToString(0);
            }
            

        }
        private void PrzypiszPierwszaLiczbe()
        {
            PierwszaLiczba = Convert.ToDouble(textBox1.Text);
            st.Push(PierwszaLiczba);
        }
    }
}