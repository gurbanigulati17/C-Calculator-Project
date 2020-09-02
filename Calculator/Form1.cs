using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstnum, secondnum;
        String operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + b.Text;


                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button sender1 = (Button)sender;
            Button b = sender1;
            firstnum = double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";

        }

        private void BtnBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";

            }

        }

        private void BtnPM_Click(object sender, UICuesEventArgs e)
        {
            if (!txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;

            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secondnum = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(firstnum /secondnum);
                    break;
                default:
                    break;

            }
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            String f, s;
            s = Convert.ToString(secondnum);
            f = Convert.ToString(firstnum);

            s = "";
            f = "";


        }
    }
}
