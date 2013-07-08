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
        public static string argument1 = null; // первый аргумент (мусор, которому недолго жить)
        public static string operation = null; // операция (+,- и т.д)(мусор, которому недолго жить)
        public static string argument2 = null; // второй аргумент (мусор, которому недолго жить)
        public static string InputOnDisplay = null; // то, что выводится на экран (мусор, которому недолго жить)
        public static string result = null; // результат вычислений (мусор, которому недолго жить)

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e) //функция сложения "+"
        {
            CommonCalculation("+", true);
        }

        private void button15_Click(object sender, EventArgs e) // функция перемножения "*"
        {
            CommonCalculation("*", true);
        }

        private void button16_Click(object sender, EventArgs e) //функция вычитания "-"
        {
            CommonCalculation("-", true);
    
        }

        private void button14_Click(object sender, EventArgs e) //функция деления "/"
        {
            CommonCalculation("/", true);
        }

    
        private void button19_Click(object sender, EventArgs e) //Синус
        {
            CommonCalculation("(sin)", false);
        }

        private void button20_Click(object sender, EventArgs e) //Косинус
        {
            CommonCalculation("(cos)", false);
        }

        private void button21_Click(object sender, EventArgs e) //Тангенс
        {
            CommonCalculation("(tg)", false);
        }

        private void button22_Click(object sender, EventArgs e) // Функция перевода градусов  в радианы
        {

            CommonCalculation("(perevod_vRad)", false);
        }
     
        private void button24_Click(object sender, EventArgs e) //перевод полярных координат в X
        {
            CommonCalculation("ToX", true);
        }

        private void button23_Click(object sender, EventArgs e) //перевод полярных координат в Y
        {
            CommonCalculation("ToY", true);
        }

        private void button25_Click(object sender, EventArgs e)  //Арксинус
        {
            CommonCalculation("arcsinus", false);
        }

        private void button26_Click(object sender, EventArgs e) //Арккосинус
        {
            CommonCalculation("Arccos", false);
        }

        private void button27_Click(object sender, EventArgs e) //Арктангенс
        {
            CommonCalculation("Arctang", false);
        }

        private void FAR_Click(object sender, EventArgs e) //e в степени х
        {
            CommonCalculation("Exp", false);
        }

        private void button28_Click(object sender, EventArgs e) //Квадрат
        {
            CommonCalculation("Sqr", false);
        }

        private void button29_Click(object sender, EventArgs e) //Квадратный корень
        {
            CommonCalculation("Sqrt", false);
        }

        private void button30_Click(object sender, EventArgs e) //Возведение в степень
        {
            CommonCalculation("Pow", true);
        }

        private void button31_Click(object sender, EventArgs e) //Извлечение корня второго аргумента
        {
            CommonCalculation("Izvlech_iz_korn", true);
            
        }

        private void button32_Click(object sender, EventArgs e) //Факториал
        {
            CommonCalculation("!", false);
        }

        private void CommonCalculation(String operation, bool binary) //Новый вариант ввода
        {
            double firstArg;
            try
            {
                firstArg = Convert.ToDouble(richTextBox1.Text);
            }
            catch (Exception e)
            {
                throw new Exception("Не введен первый аргумент!");
            }  
            if (binary!=false)
            {
                double secondArg;
                try
                {
                    secondArg = Convert.ToDouble(richTextBox2.Text);
                }
                catch (Exception e)
                {
                    throw new Exception("Не введен второй аргумент!");
                }

            }
            else
            {
                Operation calc = CalculatorsFactory.Create(operation);
                richTextBox3.Text = calc.Calculate(firstArg).ToString();    
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CommonCalculation("ln", false);
        }

        private void button33_Click(object sender, EventArgs e) //Догарифм по основанию 10
        {
            CommonCalculation("log10", false);
        }

        private void button34_Click(object sender, EventArgs e) //Догарифм по основанию 2
        {
            CommonCalculation("log2", false);
        }

        private void button37_Click(object sender, EventArgs e) //Логарифм по основагию второго аргумента
        {
            CommonCalculation("log", true);
        }

        private void button35_Click(object sender, EventArgs e) //Перевод радиан в градусы
        {
            CommonCalculation("(perevod_vGrad)", false);
        }



        private void SortCommonCalculation(string sortname)
    {
            List<int> intArray = new List<int>();
            try
            {
            List<string> strArray;
            strArray=richTextBox1.Text.Split(',').ToList();
                for (int i=0;i< (strArray.Count); i++)
                {
                    intArray.Add(Convert.ToInt32(strArray[i]));
                }
            }
            catch (Exception e)
                {
                    throw new Exception("не введена числовая последовательность");
                }

            Sorter calc = SorterFactory.CreateSort(sortname);
            intArray = calc.sort(intArray);
            string result = null;
            for (int i = 0; i < (intArray.Count); i++)
            {
                if (i==0) result = result +intArray[i] ;
                else result = result +  "," + intArray[i] ;
            }
            richTextBox3.Text = result;    


    }

        private void button2_Click(object sender, EventArgs e)
        {
            SortCommonCalculation("Sort1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortCommonCalculation("Sort2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortCommonCalculation("Sort3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortCommonCalculation("Sort4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortCommonCalculation("Sort5");
        }
    }


}
 


   
    


