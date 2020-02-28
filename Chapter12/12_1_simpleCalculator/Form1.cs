using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_1_simpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (txtBoxOperator.Text == "+")
            {
                txtBoxResult.Text = Convert.ToString(
                    Convert.ToDouble(txtBoxNum1.Text) +
                    Convert.ToDouble(txtBoxNum2.Text));
                
            }
        }
    }
}
