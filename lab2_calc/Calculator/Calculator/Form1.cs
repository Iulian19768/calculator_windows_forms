using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        public string sign = "";
        bool button = false;
        public double op;

        double result;
        string _operator;

        public double Calculate(double value, char operation, double number)
        {
            return number;
        }


        private void button2_Click(object sender, EventArgs e)
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

        

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //PLUS
            //string var = textBox1.Text.ToString();
            //float Greutate = (float)Convert.ToDouble(var);
            textBox1.Text += " + ";
            _operator = "+";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //MINUS
            textBox1.Text += " - ";
            _operator = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //IMPARTIRE
            textBox1.Text += " / ";
            _operator = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //ORI
            textBox1.Text += " * ";
            _operator = "*";
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_operator == "/")
            {
                int findZero = textBox1.Text.IndexOf("/");
                if (Convert.ToDouble(textBox1.Text.Substring(findZero + 2)) == 0) 
                {
                    textBox1.Text = "Nu poti imparti la 0";
                }
            }
            else
            {
                result = Evaluate(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
        }
    }
}
