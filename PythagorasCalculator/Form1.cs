using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythagorasCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("If you don't know the Value of a variable, just set it to 0. Otherwise it will not run!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = int.Parse(this.a.Text);
            float b = int.Parse(this.b.Text);
            float c = int.Parse(this.c.Text);

            if (a > 0 && b > 0)
            {
                c = (float)Math.Sqrt((float)Math.Pow(a, 2) + (float)Math.Pow(b, 2));
                MessageBox.Show("The Value of C is equal to: " + c);
            }
            else if (a > 0 && c > 0)
            {
                b = (float)Math.Sqrt((float)Math.Pow(c, 2) - (float)Math.Pow(a, 2));
                MessageBox.Show("The Value of B is equal to: " + b);
            }
            else if (b > 0 && c > 0)
            {
                a = (float)Math.Sqrt((float)Math.Pow(c, 2) - (float)Math.Pow(b, 2));
                MessageBox.Show("The Value of A is equal to: " + a);
            }
        }
    }
}
