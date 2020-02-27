using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FitnessMember fm = new FitnessMember();
            fm._Name = "이혜림";
            // fm._Weight = 45;
            fm.Weight = 101.2;
            fm.SetHight(1.83);
            fm.BMICalc();

            fm.SetHight(183);
            fm.BMICalc();
        }
    }
}
