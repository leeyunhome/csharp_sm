using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_maxPrimeOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            long startTime, endTime;
            long TICKSPERSECOND = 10000000;
            bool flagPrimeNumber = true;
            int tmpPrimeNumber = 0;
            int count = 0;
            int MAXVALUE = int.MaxValue;
            startTime = DateTime.Now.Ticks;
            Console.WriteLine("시작시간 : " + startTime);
            for (int i = MAXVALUE - 2; i > 3; i-=2)
            {
                for (int j = 3; j < i; j += 2)
                {
                    //Console.Write(j + " : ");
                    //Console.WriteLine(i % j);
                    if ((i % j) == 0) flagPrimeNumber = false;
                }
                if (flagPrimeNumber == true)
                {
                    tmpPrimeNumber = i;
                }
                flagPrimeNumber = true;
            }

            endTime = DateTime.Now.Ticks;

            Console.WriteLine(MAXVALUE + " 이하 최대 소수 값은 " + tmpPrimeNumber + " 입니다.");
            Console.WriteLine("걸린 시간은: " + (double)(endTime - startTime) / TICKSPERSECOND);
        }
    }
}
