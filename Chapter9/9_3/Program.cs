using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature c1 = new Human("이혜림");
            Creature c2 = new Human("이윤호");
            Creature c3 = new Alien("@@_@@!");
            Creature c4 = new Alien("C#MOOC");

            List<Creature> list = new List<Creature>();
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);

            foreach (var element in list)
            {
                if (element is Human)
                {
                    Human human = element as Human;
                    human.ShowName();
                    human.Speak();
                }
                else
                {
                    Alien alien = element as Alien;
                    alien.ShowName();
                    alien.Telepathy();
                }
            }
        }
    }
}
