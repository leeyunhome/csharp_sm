using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            long startTime = DateTime.Now.Ticks;

            long endTime = DateTime.Now.Ticks;
            long elapsedTime = (long)(endTime - startTime) / 1000000;
        }
    }
}
