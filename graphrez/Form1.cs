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
        public static string argument1=null; // первый аргумент (мусор, которому недолго жить)
        public static string operation=null; // операция (+,- и т.д)(мусор, которому недолго жить)
        public static string argument2=null; // второй аргумент (мусор, которому недолго жить)
        public static string InputOnDisplay=null; // то, что выводится на экран (мусор, которому недолго жить)
        public static string result = null; // результат вычислений (мусор, которому недолго жить)
  
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e) // функция сброса "С"
        {
            argument1 = null;
            operation = null;
            argument2 = null;
            InputOnDisplay = null;
            result = null;
            richTextBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e) //кнопка 0
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
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

        private void button2_Click(object sender, EventArgs e) //кнопка1
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "1";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button7_Click(object sender, EventArgs e) //кнопка 2
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "2";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button11_Click(object sender, EventArgs e) //кнопка 3
        {
            string NewSymbol;
            if (result != null) result= InputOnDisplay = null;
            NewSymbol = "3";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button1_Click(object sender, EventArgs e) //кнопка4
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "4";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button8_Click(object sender, EventArgs e) //кнопка 5
        { 
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "5";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button12_Click(object sender, EventArgs e) //кнопка 6
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "6";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button4_Click(object sender, EventArgs e) //кнопка 7
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "7";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button5_Click(object sender, EventArgs e) //кнопка 8
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "8";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button9_Click(object sender, EventArgs e) //кнопка 9
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            NewSymbol = "9";
            if (operation == null) argument1 = argument1 + NewSymbol;
            else argument2 = argument2 + NewSymbol;
            InputOnDisplay = InputOnDisplay + NewSymbol;
            richTextBox1.Text = InputOnDisplay;
        }

        private void button6_Click(object sender, EventArgs e) //функция написания дробного числа (запятая) 
        {
            string NewSymbol;
            if (result != null) result = InputOnDisplay = null;
            if (operation == null)
            {
                if (argument1 == null)
                {
                    NewSymbol = "0,";
                    InputOnDisplay = InputOnDisplay + NewSymbol;
                    richTextBox1.Text = InputOnDisplay;
                    argument1 = argument1 + NewSymbol;
                }
                else
                {
                    if (argument1.Contains(",") != true)
                    {
                        NewSymbol = ",";
                        InputOnDisplay = InputOnDisplay + NewSymbol;
                        richTextBox1.Text = InputOnDisplay;
                        argument1 = argument1 + NewSymbol;
                    }
                }
            }
            else
            {
                if (argument2 == null)
                {
                    NewSymbol = "0,";
                    InputOnDisplay = InputOnDisplay + NewSymbol;
                    richTextBox1.Text = InputOnDisplay;
                    argument2 = argument2 + NewSymbol;
                }
                else
                {
                    if (argument2.Contains(",") != true)
                    {
                        NewSymbol = ",";
                        InputOnDisplay = InputOnDisplay + NewSymbol;
                        richTextBox1.Text = InputOnDisplay;
                        argument2 = argument2 + NewSymbol;
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e) //функция сложения "+"
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "+";
                operation = operation + NewSymbol;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "+";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
        }

        private void button15_Click(object sender, EventArgs e) // функция перемножения "*"
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "*";
                operation = operation + NewSymbol;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "*";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
        }

        private void button16_Click(object sender, EventArgs e) //функция вычитания "-"
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "-";
                operation = operation + NewSymbol;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "-";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
        }

        private void button14_Click(object sender, EventArgs e) //функция деления "/"
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "/";
                operation = operation + NewSymbol;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation=null;
                NewSymbol = "/";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
         }

        private void button17_Click(object sender, EventArgs e) //Функция вывода результатов "="
        {
            double value1 = Convert.ToDouble(argument1);
            double value2 = Convert.ToDouble(argument2);
            BinaryOperation Calc = BinaryCalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1, value2);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
            label1.Text = null;
         }

        private void button19_Click(object sender, EventArgs e) //Синус
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "(sin)";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "(sin)";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
        }

        private void button20_Click(object sender, EventArgs e) //Косинус
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "(cos)";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "(cos)";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                richTextBox1.Text = InputOnDisplay;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
        }

        private void button21_Click(object sender, EventArgs e) //Тангенс
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "(tg)";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "(tg)";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                richTextBox1.Text = InputOnDisplay;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
        }

        private void button22_Click(object sender, EventArgs e) // Функция перевода градусов  в радианы
        {
            
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "(perevod_vRad)";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "(perevod_vRad)";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                richTextBox1.Text = InputOnDisplay;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
            }

        private void button10_Click(object sender, EventArgs e) //функция "+/-"
        {
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                if (argument1 == null) argument1="0";
                if (argument1.Contains("-") == true)
                {
                    argument1 = argument1.Remove(0, 1); ;
                    InputOnDisplay = argument1;
                    richTextBox1.Text = InputOnDisplay;
                }
                else
                {
                    argument1 = argument1.Insert(0,"-");
                    InputOnDisplay = argument1;
                    richTextBox1.Text = InputOnDisplay;
                }
            }
            else
            {
                if (argument2.Contains("-") == true)
                {
                    argument2 = argument2.Remove(0, 1); ;
                    InputOnDisplay = argument1+operation+argument2;
                    richTextBox1.Text = InputOnDisplay;
                }
                else
                {
                    argument2 = argument2.Insert(0, "-");
                    InputOnDisplay = argument1+operation+argument2;
                    richTextBox1.Text = InputOnDisplay;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e) //перевод полярных координат в X
        {
            string NewSymbol;
            label1.Text = "Введите угол в радианах";
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "ToX";
                operation = operation + NewSymbol;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation=null;
                NewSymbol = "ToX";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
         }

        private void button23_Click(object sender, EventArgs e) //перевод полярных координат в Y
        {
            string NewSymbol;
            label1.Text = "Введите угол в радианах";
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "ToY";
                operation = operation + NewSymbol;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "ToY";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
                InputOnDisplay = InputOnDisplay + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            label1.Text = "Введите угол в радианах";
        }

        private void button25_Click(object sender, EventArgs e)  //arcsinus числа
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "arcsinus";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "arcsinus";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "Arccos";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "Arccos";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "Arctang";
                operation = operation + NewSymbol;
                richTextBox1.Text = InputOnDisplay;
            }
            else
            {
                operation = null;
                NewSymbol = "Arctang";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
        }

        private void FAR_Click(object sender, EventArgs e) //e в степени х
        {
            string NewSymbol;
            if (result != null)
            {
                argument1 = result;
                result = null;
            }
            if (operation == null)
            {
                NewSymbol = "Exp";
                operation = operation + NewSymbol;
            }
            else
            {
                operation=null;
                NewSymbol = "Exp";
                operation = operation + NewSymbol;
                InputOnDisplay = argument1;
  
            }
            double value1 = Convert.ToDouble(argument1);
            Operation Calc = CalculatorsFactory.Create(operation);
            double localresult = Calc.Calculate(value1);
            result = Convert.ToString(localresult);
            InputOnDisplay = result;
            richTextBox1.Text = InputOnDisplay;
            argument1 = null;
            operation = null;
            argument2 = null;
         }
        

        }

      
        }
 


   
    


