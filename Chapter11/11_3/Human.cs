using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class Human:Creature
    {
        private int MaxAttack = 10;
        public int MAXATTACK
        {
            get { return MaxAttack; }
            set { MaxAttack = value; }
        }

        public Human()
        {
            HP = rnd.Next(50) + 50;
        }

        public override int Attack()
        {
            return rnd.Next(MaxAttack) + 10;
        }

        public override void Attacked(int damage)
        {
            this.HP -= damage;
        }

        public int SpecialAttack()
        {
            return rnd.Next(2 * MaxAttack) + 10;
        }
    }
}
