using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphrez
{
    public partial class Form1 : Form
    {
        public static string argument1=null; //мусор, которому недолго жить
        public static string operation=null; //мусор, которому недолго жить
        public static string argument2=null; //мусор, которому недолго жить
        public static string InputOnDisplay=null; //мусор, которому недолго жить

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            argument1 = null;
            operation = null;
            argument2 = null;
            InputOnDisplay = null;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            if (operation == null)
                {
                    if (argument1 != null)
                        {
                        NewSymbol = "0";
                        argument1 = argument1 + NewSymbol;
                        InputOnDisplay = InputOnDisplay + NewSymbol;
                        richTextBox1.Text = InputOnDisplay;
                }
            }
            else
               {
                    if (argument2 != null)
                    {
                        NewSymbol = "0";
                        argument2 = argument2 + NewSymbol;
                        InputOnDisplay = InputOnDisplay + NewSymbol;
                        richTextBox1.Text = InputOnDisplay;
                    }
                }
          }

        private void button2_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "1";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "2";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "3";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "4";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "5";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "6";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "7";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "8";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "9";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            if (operation == null)
            {
                        if (argument1 == null) NewSymbol = "0,";
                        else NewSymbol = ",";
                        InputOnDisplay = InputOnDisplay + NewSymbol;
                        richTextBox1.Text = InputOnDisplay;
                        argument1 = argument1 + NewSymbol;
            }
            else
            {
                    if (argument2 == null) NewSymbol = "0,";
                    else NewSymbol = ",";
                    InputOnDisplay = InputOnDisplay + NewSymbol;
                    richTextBox1.Text = InputOnDisplay;
                    argument2 = argument2 + NewSymbol;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "+";
            operation = operation + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "*";
            operation = operation + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "-";
            operation = operation + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            NewSymbol = "/";
            operation = operation + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(argument1);
            double value2 = Convert.ToDouble(argument2);
            Operation Calc = CalculatorsFactory.Create(operation);
            double result = Calc.Calculate(value1, value2);
            richTextBox1.Text = Convert.ToString(result);
            argument1 = Convert.ToString(result);
            operation = null;
            argument2 = null;
        }


    }

}
