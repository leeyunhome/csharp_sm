using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_3
{
    public partial class Form1 : Form
    {
        Human human;
        Alien alien;
        public Form1()
        {
            InitializeComponent();
            human = new Human();
            alien = new Alien();
            labelHumanHp.Text = "" + human.HP;
            labelAlienHp.Text = "" + alien.HP;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            human.HP = 50;
            labelHumanHp.Text = "" + human.HP;
        }

        private void buttonFight_Click(object sender, EventArgs e)
        {
            human.Attacked(alien.Attack());
            alien.Attacked(human.Attack());
            alien.Heal();

            if (human.HP <= 0) { labelHumanHp.Text = "종료"; }
            else if (alien.HP <= 0) { labelAlienHp.Text = "종료"; }
            else
            {
                labelHumanHp.Text = "" + human.HP;
                labelAlienHp.Text = "" + alien.HP;
            }
        }

        private void buttonAlienRecover_Click(object sender, EventArgs e)
        {
            alien.HP = 50;
            labelAlienHp.Text = "" + alien.HP;
        }
    }
}
