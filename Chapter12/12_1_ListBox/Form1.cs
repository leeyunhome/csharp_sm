using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_1_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            listBoxShowLetter.Items.Add((Keys)e.KeyCode);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            listBoxShowLetter.Items.Remove((Keys)e.KeyCode);
        }
    }
}
