using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameID gamer = new GameID("1", "leehyerim");
            gamer.ShowCash();

            gamer.ReceivedCash(2000);
            gamer.ChangeNickName("beakyuri");
            gamer.ConsumedCash(1500);
            gamer.ShowNickName();
            gamer.ShowCash();
        }
    }
}
