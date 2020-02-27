using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Mooc
    {
        public string ClassName;
        public void ShowClassName()
        {
            Console.Write(ClassName);
        }
        public void EnterClassName(string className)
        {
            ClassName = className;
            Console.Write("클래스 이름: " + ClassName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mooc mooc = new Mooc();
            mooc.EnterClassName("C#프로그래밍");
            mooc.ShowClassName();
            mooc.ClassName = "C#수업";
            Console.WriteLine(mooc.ClassName);
        }
    }
}
