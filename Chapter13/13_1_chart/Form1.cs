using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_1_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            for (int x = -10; x <= 10; x++)
            {
                y = (x + 7) * (x + 1) * (x - 5);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
        }
    }
}
