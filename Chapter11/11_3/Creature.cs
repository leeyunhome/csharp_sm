using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    abstract class Creature
    {
        private int Hp;
        public static Random rnd = new Random();

        public int HP
        {
            get { return Hp; }
            set { Hp = value; }
        }

        public abstract int Attack();
        public abstract void Attacked(int damage);
    }
}
