using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class FitnessMember
    {
        public string _Name;
        private double _Weight;
        private double _Height;
        private double _BMIThreshold = 23.0;

        public void SetHight(double height)
        {
            if (height > 3)
            {
                _Height = height / 100;
            }
            else
            {
                _Height = height;
            }
        }

        public double GetHeight()
        {
            return _Height;
        }

        public double Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public void BMICalc()
        {
            double tmpBMI = Weight / (_Height * _Height);
            Console.WriteLine("신체질량지수 BMI: " + tmpBMI);
            if (tmpBMI > _BMIThreshold)
                Console.WriteLine("과체중입니다.");
            else
                Console.WriteLine("과체중은 아닙니다.");
        }
    }
}
