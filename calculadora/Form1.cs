using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonRedondo19_Click(object sender, EventArgs e)
        {
            if(label2.Text == "0")
            {
                label2.Text = "0";
            }
            else
            {
                label2.Text += "0";
            }
            
        }

        private void botonRedondo15_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "2";
            }
            else
            {
                label2.Text += "2";
            }

        }

        private void botonRedondo14_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "3";
            }
            else
            {
                label2.Text += "3";
            }

        }

        private void botonRedondo12_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "4";
            }
            else
            {
                label2.Text += "4";
            }

        }

        private void botonRedondo11_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "5";
            }
            else
            {
                label2.Text += "5";
            }

        }

        private void botonRedondo10_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "6";
            }
            else
            {
                label2.Text += "6";
            }

        }

        private void botonRedondo8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "7";
            }
            else
            {
                label2.Text += "7";
            }

        }

        private void botonRedondo7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "8";
            }
            else
            {
                label2.Text += "8";
            }

        }

        private void botonRedondo6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "9";
            }
            else
            {
                label2.Text += "9";
            }

        }

        private void botonRedondo16_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                label2.Text = "1";
            }
            else
            {
                label2.Text += "1";
            }

        }

        private void botonRedondo18_Click(object sender, EventArgs e)
        {
            // no funciona aun
            if (label2.Text == "" && Char.IsNumber(label2.Text[label2.Text.Length - 1]) && label2.Text[label2.Text.Length - 1] != '.')
            {
                label2.Text = ".";
            }
            else
            {
                label2.Text += ".";
            }
        }

        private void botonRedondo13_Click(object sender, EventArgs e)
        {
            if (label2.Text != "" && Char.IsNumber(label2.Text[label2.Text.Length - 1]) )
            {
                label2.Text += " + ";
            }
        }

        private void botonRedondo9_Click(object sender, EventArgs e)
        {
            if (label2.Text != "" && Char.IsNumber(label2.Text[label2.Text.Length - 1]))
            {
                label2.Text += " - ";
            }
        }

        private void botonRedondo5_Click(object sender, EventArgs e)
        {
            if (label2.Text != "" && Char.IsNumber(label2.Text[label2.Text.Length - 1]))
            {
                label2.Text += " × ";
            }
        }

        private void botonRedondo4_Click(object sender, EventArgs e)
        {
            if (label2.Text != "" && Char.IsNumber(label2.Text[label2.Text.Length - 1]))
            {
                label2.Text += " ÷ ";
            }
        }

        private void botonRedondo17_Click(object sender, EventArgs e)
        {

        }
    }
}
