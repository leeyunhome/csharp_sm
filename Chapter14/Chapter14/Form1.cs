using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14
{
    public partial class Form1 : Form
    {
        double InterestRateDebt = 0.1;
        double InterestRate = 0.01;
        LottoHuman lotto;
        ThriftHuman thrift;
        public Form1()
        {
            InitializeComponent();
            lotto = new LottoHuman();
            thrift = new ThriftHuman();
            pictureBoxLottoHappy.Visible = false;
            pictureBoxLottoNormal.Visible = false;
            pictureBoxLottoUnhappy.Visible = false;
            pictureBoxThriftHappy.Visible = false;
            pictureBoxThriftNormal.Visible = false;
            pictureBoxThriftUnhappy.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int lottoFlag = 0;

            lotto.SaveMoney(InterestRate);
            lotto.EarnMoney();
            lotto.RepayMoney(InterestRateDebt);
            lotto.SpendMoney();
            lotto.BorrowMoney();
            lottoFlag = lotto.BuyLotto();

            thrift.SaveMoney(InterestRate);
            thrift.EarnMoney();
            thrift.RepayMoney(InterestRateDebt);
            thrift.SpendMoney();
            thrift.BorrowMoney();

            labelLottoMoney.Text = "" + (int)lotto.Money;
            labelLottoDebt.Text = "" + (int)lotto.Debt;
            chart1.Series["Series1"].Points.AddXY((int)thrift.Money, (int)lotto.Money);
            if (lottoFlag == 1)
                labelWinLotto.Text = "로또 당첨";
            else
                labelWinLotto.Text = "꽝";

            labelThriftMoney.Text = "" + (int)thrift.Money;
            labelThriftDebt.Text = "" + (int)thrift.Debt;

            if (lotto.Money > 50)
            {
                pictureBoxLottoHappy.Visible = true;
                pictureBoxLottoNormal.Visible = false;
                pictureBoxLottoUnhappy.Visible = false;
            }
            else if (lotto.Money > 20)
            {
                pictureBoxLottoHappy.Visible = false;
                pictureBoxLottoNormal.Visible = true;
                pictureBoxLottoUnhappy.Visible = false;
            }
            else
            {
                pictureBoxLottoHappy.Visible = false;
                pictureBoxLottoNormal.Visible = false;
                pictureBoxLottoUnhappy.Visible = true;
            }

            if (thrift.Money  >100)
            {
                pictureBoxThriftHappy.Visible = true;
                pictureBoxThriftNormal.Visible = false;
                pictureBoxThriftUnhappy.Visible = false;
            }
            else if (thrift.Money > 50)
            {
                pictureBoxThriftHappy.Visible = false;
                pictureBoxThriftNormal.Visible = true;
                pictureBoxThriftUnhappy.Visible = false;
            }
            else
            {
                pictureBoxThriftHappy.Visible = false;
                pictureBoxThriftNormal.Visible = false;
                pictureBoxThriftUnhappy.Visible = true;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
