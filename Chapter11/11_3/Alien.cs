using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class Alien:Creature
    {
        private int MaxAttack = 10;
        private int MaxHeal = 10;
        public int MAXATTACK
        {
            get { return MaxAttack; }
            set { MaxAttack = value; }
        }

        public int MAXHEAL
        {
            get { return MaxHeal; }
            set { MaxHeal = value; }
        }

        public Alien()
        {
            HP = rnd.Next(30) + 40;
        }

        public override int Attack()
        {
            return rnd.Next(MaxAttack) + 10;
        }

        public override void Attacked(int damage)
        {
            this.HP -= damage;
        }

        public void Heal()
        {
            this.HP += rnd.Next(2 * MaxHeal);
        }
    }
}
