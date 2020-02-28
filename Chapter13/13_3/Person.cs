using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3
{
    class Person
    {
        private int x;
        private int y;

        public Person(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

    }
}
