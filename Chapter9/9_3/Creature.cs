using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Creature
    {
        protected string Name;
        public void ShowName()
        {
            Console.WriteLine("내 이름은 " + Name + " 입니다.");
        }
    }
}
