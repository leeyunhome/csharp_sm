using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class ThriftHuman:Human
    {
        public override void EarnMoney()
        {
            Money += rnd.Next(20) + 20;
        }

        public override void SpendMoney()
        {
            Money -= rnd.Next(35) + 10;
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
                if (Money > Debt * (1 + interestRate))
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
    }
}
