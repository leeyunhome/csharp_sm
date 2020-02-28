using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    abstract class Human
    {
		private double money;
		private double debt;
		protected static Random rnd = new Random();

		public Human()
		{
			this.money = 30;
		}
		public double Debt
		{
			get { return debt; }
			set { debt = value; }
		}

		public double Money
		{
			get { return money; }
			set { money = value; }
		}

		abstract public void EarnMoney();
		abstract public void SpendMoney();
		abstract public void BorrowMoney();
		abstract public void RepayMoney(double interestRate);

		public void SaveMoney(double interestRate)
		{
			if (Money > 0)
				Money *= (1 + interestRate);
		}

	}
}
