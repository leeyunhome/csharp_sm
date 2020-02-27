using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (sum < 10000)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
