using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Alien:Creature
    {
        public Alien(String name)
        {
            this.Name = name;
        }
        public void Telepathy()
        {
            Console.WriteLine("!@#$%^^&?");
        }
    }
}
