using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_2
{
    public partial class Form1 : Form
    {
        private int Second;
        private int Minute;

        public Form1()
        {
            InitializeComponent();
            Second = 0;
            Minute = 0;
            listBoxSecond.Items.Add(Second);
        }

        private void listBoxColon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBoxSecond.Items.Remove(Second);
            Second++;
            if (Second == 60)
            {
                Second = 0;
                listBoxMinute.Items.Remove(Minute);
                Minute++;
                listBoxMinute.Items.Add(Minute);
            }
            if (Second % 2 == 1)
            {
                listBoxColon.Items.Add(":");
            }
            else
            {
                listBoxColon.Items.Remove(":");
            }
            listBoxSecond.Items.Add(Second);
        }
    }
}
