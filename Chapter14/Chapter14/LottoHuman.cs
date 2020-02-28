using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class LottoHuman:Human
    {
        public override void EarnMoney()
        {
            Money += rnd.Next(30) + 20;
        }

        public override void SpendMoney()
        {
            Money -= rnd.Next(40) + 10;
        }

        public override void BorrowMoney()
        {
            if (Money < 0)
            {
                Debt = -Money;
                Money = 0;
            }
        }

        public override void RepayMoney(double interestRate)
        {
            if (Debt > 0)
            {
                if (Money > Debt*(1+interestRate))
                {
                    Debt = 0;
                    Money -= Debt * (1 + interestRate);
                }
                else
                {
                    Debt = Debt * (1 + interestRate) - Money;
                    Money = 0;
                }
            }
        }
        public int BuyLotto()
        {
            int lottoFlag = 0;
            if (Money > 0)
            {
                if (rnd.Next(10) == 5)
                    lottoFlag = 1;
                if (lottoFlag == 1)
                    Money = 0.5 * Money + 3 * 0.5 * Money;
                else
                    Money = Money * 0.5;
            }
            return lottoFlag;
        }
    }
}
