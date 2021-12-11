using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
            Rational r = new Rational();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = button5.Text;
            bool num_1 = Int32.TryParse(textBox1.Text, out int Num1);
            bool del_1 = Int32.TryParse(textBox2.Text, out int Del1);
            bool num_2 = Int32.TryParse(textBox3.Text, out int Num2);
            bool del_2 = Int32.TryParse(textBox4.Text, out int Del2);

            if (Del1 == 0 || Del2 == 0)
            {
                textBox5.Text = "неверные данные";
                return;
            }

            Rational r1 = new Rational(Num1, Del1);
            Rational r2 = new Rational(Num2, Del2);
            Rational r_result = new Rational();
            if (label1.Text == "+")
            {
                r_result = r1 + r2;
                r_result.Reduction();
                textBox5.Text = r_result.ToString();
            }
            if (label1.Text == "-")
            {
                r_result = r1 - r2;
                r_result.Reduction();
                textBox5.Text = r_result.ToString();
            }
            if (label1.Text == "*")
            {
                r_result = r1 * r2;
                r_result.Reduction();
                textBox5.Text = r_result.ToString();
            }
            if (label1.Text == "/")
            {
                r_result = r1 / r2;
                r_result.Reduction();
                textBox5.Text = r_result.ToString();
            }
        }
    }

            
}
