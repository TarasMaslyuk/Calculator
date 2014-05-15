using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            double first;
            double second;


            first = Convert.ToDouble(textBox1.Text);
            second = Convert.ToDouble(textBox2.Text);
            IBinaryOperation adder = BinaryOperationFactory.CreateOperation("Adder");
            textBox3.Text = adder.Calculate(first, second).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double first;
            double second;


            first = Convert.ToDouble(textBox1.Text);
            second = Convert.ToDouble(textBox2.Text);
            IBinaryOperation substracter = BinaryOperationFactory.CreateOperation("Substracter");
            textBox3.Text = substracter.Calculate(first, second).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double first;
            double second;


            first = Convert.ToDouble(textBox1.Text);
            second = Convert.ToDouble(textBox2.Text);
            IBinaryOperation multuplication = BinaryOperationFactory.CreateOperation("Multuplication");
            textBox3.Text = multuplication.Calculate(first, second).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
            {

                double first;
                double second;


                first = Convert.ToDouble(textBox1.Text);
                second = Convert.ToDouble(textBox2.Text);
                IBinaryOperation divider = BinaryOperationFactory.CreateOperation("Divider");
                textBox3.Text = divider.Calculate(first, second).ToString();
            }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double first;
      
            first = Convert.ToDouble(textBox1.Text);
            IUnitOperation exp = UnitOperationFactory.CreateOperation("Exp");
            textBox3.Text = exp.Calculate(first).ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double first = 0;
           
            first = Convert.ToDouble(textBox1.Text);
            IUnitOperation sin = UnitOperationFactory.CreateOperation("Sin");
            textBox3.Text = sin.Calculate(first).ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double first ;
           
            first = Convert.ToDouble(textBox1.Text);
            IUnitOperation ctg = UnitOperationFactory.CreateOperation("Ctg");
            textBox3.Text = ctg.Calculate(first).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double first;
            double second;


            first = Convert.ToDouble(textBox1.Text);
            second = Convert.ToDouble(textBox2.Text);
            IBinaryOperation degree = BinaryOperationFactory.CreateOperation("Degree");
            textBox3.Text = degree.Calculate(first, second).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double first;
          
            first = Convert.ToDouble(textBox1.Text);
            IUnitOperation acos = UnitOperationFactory.CreateOperation("Acos");
            textBox3.Text = acos.Calculate(first).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
                double first;
                double second;


                first = Convert.ToDouble(textBox1.Text);
                second = Convert.ToDouble(textBox2.Text);
                IBinaryOperation log = BinaryOperationFactory.CreateOperation("Log");
                textBox3.Text = log.Calculate(first, second).ToString();
            
        }
    }
}
