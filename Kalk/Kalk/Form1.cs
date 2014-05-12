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
    }
}
