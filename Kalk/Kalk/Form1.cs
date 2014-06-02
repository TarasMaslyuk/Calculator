using System;
using System.Linq;
using System.Windows.Forms;
using Kalk.Factories;
using Kalk.Intefaces;
using Kalk.SortingOperations;

namespace Kalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BinaryCalculate(string calculatorName)
        {
            try
            {
                double first;
                double second;


                first = Convert.ToDouble(textBox1.Text);
                second = Convert.ToDouble(textBox2.Text);
                IBinaryOperation adder = BinaryOperationFactory.CreateOperation(calculatorName);
                textBox3.Text = adder.Calculate(first, second).ToString();
            }
            catch (Exception e)
            {
                textBox3.Text = e.Message;
            }
        }

        private void UnitCalculate(string calculatorName)
        {
            try
            {
                double first;

                first = Convert.ToDouble(textBox1.Text);
                IUnitOperation uo = UnitOperationFactory.CreateOperation(calculatorName);
                textBox3.Text = uo.Calculate(first).ToString();
            }
            catch (Exception e)
            {
                textBox3.Text = e.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryCalculate("Adder");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BinaryCalculate("Substracter");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            BinaryCalculate("Multuplication");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryCalculate("Divider");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            UnitCalculate("Log10");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            UnitCalculate("Cos");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UnitCalculate("Exp");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UnitCalculate("Sin");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UnitCalculate("Ctg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BinaryCalculate("Degree");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UnitCalculate("Acos");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BinaryCalculate("Log");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            UnitCalculate("Sqrt");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            UnitCalculate("Tg");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            UnitCalculate("Asin");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            UnitCalculate("Atg");
        }


        private void button18_Click(object sender, EventArgs e)
        {
            string[] mass = textBox1.Text.Split(' ');
            int[] array = mass.Select(m => Convert.ToInt32(m)).ToArray();
            ISortingOperation max = SortingOperationFactory.CreateSortingOperation("Max");
            textBox3.Text = string.Join(" ", max.Sort(array));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string[] mass = textBox1.Text.Split(' ');
            int[] array = mass.Select(m => Convert.ToInt32(m)).ToArray();
            ISortingOperation min = SortingOperationFactory.CreateSortingOperation("Min");
            textBox3.Text = string.Join(" ", min.Sort(array));
        }
    }
}
