using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int number = 0;
        int number1 = 0;
        char op = '-';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    int s = number1 + int.Parse(label1.Text);
                    label1.Text = s.ToString();
                break;

                case '-':

                    int f = number1 - int.Parse(label1.Text);
                    label1.Text = f.ToString();

                    break;
                case '*':
                    int v = number1 * int.Parse(label1.Text);
                    label1.Text =v.ToString();
                    break;

                case'/':
                    int b = number1 / int.Parse(label1.Text);
                    label1.Text = b.ToString();
                    break;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "1";
                number += 1;
            }
            else
            {
                label1.Text = "1";
                number += 1;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "2";
                number += 2;
            }
            else
            {
                label1.Text = "2";
                number += 2;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "3";
                number += 3;
            }
            else
            {
                label1.Text = "3";
                number += 3;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "4";
                number += 4;
            }
            else
            {
                label1.Text = "4";
                number += 4;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "5";
                number += 5;
            }
            else
            {
                label1.Text = "5";
                number += 5;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "6";
                number += 6;
            }
            else
            {
                label1.Text = "6";
                number += 6;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "7";
                number += 7;
            }
            else
            {
                label1.Text = "7";
                number += 7;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "8";
                number += 8;
            }
            else
            {
                label1.Text = "8";
                number += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "9";
                number += 9;
            }
            else
            {
                label1.Text = "9";
                number += 9;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            label1.Text = " ";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "0";
                number += 0;
            }
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += ".";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += ",";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number = 0;
            number1 = 0;
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            op = '+';
            number1 = number;
            number = 0;
            label1.Text ="0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op = '-';
            number1 = number;
            number = 0;
            label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = '*';
            number1 = number;
            number = 0;
            label1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = '/';
            number1 = number;
            number = 0;
            label1.Text = "0";
        }
    }
}
