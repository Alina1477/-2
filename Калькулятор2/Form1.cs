using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор2
{
    public partial class Form1 : Form
    {
        public string D;
        public string FirstValue;
        public bool SecondValue;

        public Form1()
        {
            SecondValue = false;
            InitializeComponent();
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (SecondValue)
            {
                SecondValue = false;
                vyvod.Text = "0";
            }
            Button B = (Button)sender;
            if(vyvod.Text == "0") vyvod.Text = B.Text;
            else vyvod.Text = vyvod.Text + B.Text;
        }

        private void cleanAll_Click(object sender, EventArgs e)
        {
            vyvod.Text = "0";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            FirstValue = vyvod.Text;
            SecondValue = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double dFirstValue, dSecondValue, result;
            result = 0;
            dFirstValue = Convert.ToDouble(FirstValue);
            dSecondValue = Convert.ToDouble(vyvod.Text);

            if (D == "+")
            {
                result = dFirstValue + dSecondValue;
            }

            if (D == "-")
            {
                result = dFirstValue - dSecondValue;
            }

            if (D == "*")
            {
                result = dFirstValue * dSecondValue;
            }
            if (D == "/")
            {
                result = dFirstValue / dSecondValue;
            }
            if (D == "%")
            {
                result = (dFirstValue / dSecondValue)*100;
            }
            D = "=";
            SecondValue = true;
            vyvod.Text = result.ToString(); 
        }

        private void root_Click(object sender, EventArgs e)
        {
            double a, res;
            a = Convert.ToDouble(vyvod.Text);
            res = Math.Sqrt(a);
            vyvod.Text = res.ToString();
        }

        private void partOf_Click(object sender, EventArgs e)
        {
            double a, res;
            a = Convert.ToDouble(vyvod.Text);
            res = 1/a;
            vyvod.Text = res.ToString();
        }

        private void plMin_Click(object sender, EventArgs e)
        {
            double a, res;
            a = Convert.ToDouble(vyvod.Text);
            res = -a;
            vyvod.Text = res.ToString();
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (!vyvod.Text.Contains(","))
            {
                vyvod.Text = vyvod.Text + ",";
            }
            
        }

        private void square_Click(object sender, EventArgs e)
        {
            double a, res;
            a = Convert.ToDouble(vyvod.Text);
            res = a*a;
            vyvod.Text = res.ToString();
        }
    }
}
