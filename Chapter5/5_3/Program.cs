using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber;
            int numberOfRandomValues;

            Console.Write("정수 최대값을 입력해주세요: ");
            maxNumber = int.Parse(Console.ReadLine());

            if ((maxNumber % 5) == 0)
                numberOfRandomValues = maxNumber / 5;
            else
                numberOfRandomValues = (maxNumber / 5) + 1;

            Console.WriteLine("입력된 수는" + maxNumber);
            Console.WriteLine("방법1: 생성할 random number의 수는:" + numberOfRandomValues);

            numberOfRandomValues = ((maxNumber - 1) / 5) + 1;
            Console.WriteLine("방법2: 생성할 random number의 수는:" + numberOfRandomValues);

            int[] arrayNumber = new int[numberOfRandomValues];
            int numberCount = 0;    // 발생된 숫자 개수를 센다.
            int tempRandomNumber = 0;

            Random random = new Random();

            while (numberCount < (numberOfRandomValues - 1))
            {
                bool failFlag = false;
                if (numberCount == 0)
                {
                    arrayNumber[numberCount] = (random.Next(maxNumber) + 1);
                }
                tempRandomNumber = (random.Next(maxNumber) + 1);
                for (int i = 0; i <= numberCount; i++)
                {
                    if (tempRandomNumber == arrayNumber[i]) failFlag = true;
                }
                if (!failFlag)
                {
                    numberCount++;
                    arrayNumber[numberCount] = tempRandomNumber;
                }

            }

            foreach (int value in arrayNumber)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n");

            Console.WriteLine("정렬하면 다음과 같이 됩니다.");

            for (int i = 0; i < numberOfRandomValues - 1; ++i)
            {
                int min_idx = i;
                for (int j = i; j < numberOfRandomValues; ++j)
                {
                    if (arrayNumber[min_idx] > arrayNumber[j])
                    {
                        min_idx = j;
                    }
                }
                int temp = arrayNumber[min_idx];
                arrayNumber[min_idx] = arrayNumber[i];
                arrayNumber[i] = temp;
            }

            foreach (int value in arrayNumber)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n");

        }
    }
}
