using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private bool IsValidXY()
        {
            if (xValue.Text.Length > 0 && yValue.Text.Length > 0)
            {
                return true;
            }

            return false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsValidXY())
            {
                double x = Double.Parse(xValue.Text);
                double y = Double.Parse(yValue.Text);

                double output = Calculator.Add(x, y);
                resultValue.Text = output.ToString();
            }
            else
            {
                MessageBox.Show("You need to fill in valid X and Y value");
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (IsValidXY())
            {
                double x = Double.Parse(xValue.Text);
                double y = Double.Parse(yValue.Text);

                double output = Calculator.Subtract(x, y);
                resultValue.Text = output.ToString();
            }
            else
            {
                MessageBox.Show("You need to fill in valid X and Y value");
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (IsValidXY())
            {
                double x = Double.Parse(xValue.Text);
                double y = Double.Parse(yValue.Text);

                double output = Calculator.Multiply(x, y);
                resultValue.Text = output.ToString();
            }
            else
            {
                MessageBox.Show("You need to fill in valid X and Y value");
            }
        }

        private void divideButtton_Click(object sender, EventArgs e)
        {
            if (IsValidXY())
            {
                double x = Double.Parse(xValue.Text);
                double y = Double.Parse(yValue.Text);

                double output = Calculator.Divide(x, y);
                resultValue.Text = output.ToString();
            }
            else
            {
                MessageBox.Show("You need to fill in valid X and Y value");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            xValue.Text = "";
            yValue.Text = "";
            resultValue.Text = "";
        }
    }
}
