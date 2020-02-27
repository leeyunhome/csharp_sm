using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class GameID
    {
        public string ID;
        public string NickName;
        public int Cash;

        public GameID(string id, string nick)
        {
            ID = id;
            NickName = nick;
            Cash = 0;
        }
        public void ShowID()
        {
            Console.WriteLine("ID는" + ID + "입니다.");
        }
        public void ShowNickName()
        {
            Console.WriteLine("별명은 " + NickName + "입니다.");
        }
        public void ChangeNickName(string nick)
        {
            NickName = nick;
        }

        public void ShowCash()
        {
            Console.WriteLine("Cash는 " + Cash + "원 입니다.");
        }
        public void ReceivedCash(int cash)
        {
            Cash += cash;
            Console.WriteLine(cash + "원 입금후 Cash는 " + Cash + "원 입니다.");
        }
        public void ConsumedCash(int cash)
        {
            Cash -= cash;
            Console.WriteLine(cash + "원 소비 후 Cash는 " + Cash + "원 입니다.");
        }
    }
}
