using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleApplication3;

namespace graphrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

          }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string temp = richTextBox1.Text;
            string operation = richTextBox2.Text;
            string temp2 = richTextBox3.Text;
            int arg1 = Convert.ToInt32(temp);
            int arg2 = Convert.ToInt32(temp2);
            Operation Calc = CalculatorsFactory.Create(operation);
            label1.Text = Convert.ToString(Calc.Calculate(arg1, arg2));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

 
    }

}
