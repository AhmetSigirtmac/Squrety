using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win10_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        string islem;
        double sayi1, sayi2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
               
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += 7;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text)>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text.Length==0)
            {
                textBox1.Text = "0";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text)>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text.Length==0)
            {
                textBox1.Text = "0";
            }
        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + " +";
            textBox1.Text = "0";
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            if (islem=="+")
            {
                textBox1.Text = Convert.ToString(sayi1 + sayi2);
                label1.Text = "";
            }

            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(sayi1 - sayi2);
                label1.Text = "";
            }

            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(sayi1 * sayi2);
                label1.Text = "";
            }

            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(sayi1 / sayi2);
                label1.Text = "";
            }

            if (islem == "%")
            {
                textBox1.Text = Convert.ToString(sayi1 % sayi2);
            }
        }

        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + " -";
            textBox1.Text = "0";
        }

        private void btn_Carp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + " *";
            textBox1.Text = "0";
        }

        private void btn_Bol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + " /";
            textBox1.Text = "0";
        }



        private void btn_ModAlma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = "%";
            label1.Text = textBox1.Text + "% (mod)";
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
