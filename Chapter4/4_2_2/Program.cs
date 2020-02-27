using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int total_count = 0;
            while (true)
            {
                Random rand = new Random();
                if (rand.Next(1, 11) == 5)
                {
                    Console.WriteLine(5);
                    count++;
                }
                if (count == 10)
                {
                    break;
                }
                total_count++;
            }
            Console.WriteLine("5가" + count + " 번 발생할때 까지");
            Console.WriteLine(total_count);

        }
    }
}
