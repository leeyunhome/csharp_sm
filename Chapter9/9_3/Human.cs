using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Human:Creature
    {
        public Human(String name)
        {
            this.Name = name;
        }
        public void Speak()
        {
            Console.WriteLine("지구인인데 말해보라고?");
        }
    }
}
