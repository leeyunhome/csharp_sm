using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_3
{
    public partial class Form1 : Form
    {
        private int mSecond;
        private int second;
        public Form1()
        {
            InitializeComponent();
            mSecond = 0;
            second = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBoxmSecond.Items.Remove(mSecond - 1);
            listBoxmSecond.Items.Add(mSecond);

            if (mSecond%2 == 0)
            {
                listBoxColon.Items.Add(":");
            }
            else
            {
                listBoxColon.Items.Remove(":");
            }

            mSecond++;
            if (mSecond == 100)
            {
                listBoxmSecond.Items.Remove(mSecond - 1);
                listBoxSecond.Items.Remove(second);
                second++;
                listBoxSecond.Items.Add(second);
                mSecond = 0;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxSecond.Items.Clear();
            listBoxmSecond.Items.Clear();
            listBoxLapTime.Items.Clear();
        }

        private void buttonLapTime_Click(object sender, EventArgs e)
        {
            listBoxLapTime.Items.Add(
                Convert.ToString(second) + ":" +  Convert.ToString(mSecond));
        }
    }
}
