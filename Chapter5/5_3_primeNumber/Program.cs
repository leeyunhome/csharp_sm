using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_primeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long startTime, endTime;
            long TICKSPERSECOND = 10000000;
            bool flagPrimNumber = true;
            int tmpPrimeNumber = 0;
            int MAXVALUE = 1000;
            startTime = DateTime.Now.Ticks;
            //Console.Write(" 소수 목록은: \n 2, ");
            for (int i = 3; i < MAXVALUE; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) flagPrimNumber = false;
                }
                if (flagPrimNumber)
                {
                    tmpPrimeNumber = i;
                }
                flagPrimNumber = true;
            }

            endTime = DateTime.Now.Ticks;

            Console.WriteLine(MAXVALUE + " 이하 최대 소수 값은 " + tmpPrimeNumber + " 입니다.");
            Console.WriteLine("걸린 시간은: " + (double)(endTime - startTime) / TICKSPERSECOND);
        }
    }
}
