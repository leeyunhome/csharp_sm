using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_3
{
    public partial class Form1 : Form
    {
        Person ps;
        public Form1()
        {
            InitializeComponent();
            ps = new Person(pictureBoxLee.Location.X, pictureBoxLee.Location.Y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point p;
            switch(e.KeyCode)
            {
                case Keys.Right:
                    ps.X += 10;
                    p = new Point(ps.X, ps.Y);
                    pictureBoxLee.Location = p;
                    break;
                case Keys.Left:
                    ps.X -= 10;
                    p = new Point(ps.X, ps.Y);
                    pictureBoxLee.Location = p;
                    break;
                case Keys.Up:
                    ps.Y -= 10;
                    p = new Point(ps.X, ps.Y);
                    pictureBoxLee.Location = p;
                    break;
                case Keys.Down:
                    ps.Y += 10;
                    p = new Point(ps.X, ps.Y);
                    pictureBoxLee.Location = p;
                    break;
            }

            if (ps.X > 500)
            {
                label2.Text = "Sex";
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            labelX.Text = Convert.ToString(ps.X);
            labelY.Text = Convert.ToString(ps.Y);
        }
    }
}
