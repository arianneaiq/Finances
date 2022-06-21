using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances
{
    public partial class Form1 : Form
    {
        Wallet myWallet;
        Wallet anotherWallet;

       
        public Form1()
        {
            InitializeComponent();

            myWallet = new Wallet();
            anotherWallet = new Wallet();
            
        }

        //Wallet 1
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbOwnerNameInfo.Text = myWallet.GetOwnerName();
            lbOwnerAmountInfo.Text = myWallet.GetOwnerAmount();
        }

        private void btnSetOwnerName_Click(object sender, EventArgs e)
        {
          myWallet.SetOwnerName(tbSetName.Text);
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            int Addmoney = Convert.ToInt32(tbAddMoney.Text);
            if (Addmoney < 0)
            {
                lbWithdrawInfo.Text = myWallet.addNegativeAmmount(); 
            }
            else  {
                myWallet.AddMoney(Addmoney);
            }
          
        }

       private void btnWithdraw1to2_Click(object sender, EventArgs e)
        {
            int withdrawAmount = Convert.ToInt32(tbWithdrawAmount.Text);

            if (withdrawAmount <= 0)
            {
                lbWithdrawInfo.Text = myWallet.negativeAmount();
            }
            else if (withdrawAmount >= myWallet.GetOwnerAmmount())
            {
                lbWithdrawInfo.Text = myWallet.notEnoughAmount();
            }
            else
            {
                lbWithdrawInfo.Text = myWallet.withdrawSucess();
                myWallet.WithdrawMoney(withdrawAmount);
                anotherWallet.AddMoney(withdrawAmount);
                lbOwnerAmountInfo.Text = myWallet.GetOwnerAmount();
                lbOwnerAmountInfo2.Text = anotherWallet.GetOwnerAmount();
            }
           
        }

        //Wallet 2

        private void btnShowInfo2_Click(object sender, EventArgs e)
        {
            lbOwnerNameInfo2.Text = anotherWallet.GetOwnerName();
            lbOwnerAmountInfo2.Text = anotherWallet.GetOwnerAmount();
  
        }

        private void btnSetOwnerName2_Click(object sender, EventArgs e)
        {
            anotherWallet.SetOwnerName(tbSetName2.Text);
        }

        private void btnAddMoney2_Click(object sender, EventArgs e)
        { 
            int Addmoney = Convert.ToInt32(tbAddMoney2.Text);

            if (Addmoney <= 0)
            {
                lbWithdrawInfo2.Text = anotherWallet.addNegativeAmmount();
            }
            else
            {
                anotherWallet.AddMoney(Addmoney);
                
            }
        }

        

        private void btnWithdraw2to1_Click(object sender, EventArgs e)
        {

            int withdrawAmount = Convert.ToInt32(tbWithdrawAmount.Text);

            if (withdrawAmount <= 0)
            {
                lbWithdrawInfo2.Text = anotherWallet.negativeAmount();
            }
            else if (withdrawAmount >= anotherWallet.GetOwnerAmmount())
            {
                lbWithdrawInfo2.Text = anotherWallet.notEnoughAmount();
            }
            else
            {
                lbWithdrawInfo2.Text = myWallet.withdrawSucess();
                myWallet.AddMoney(withdrawAmount);
                anotherWallet.WithdrawMoney(withdrawAmount);
                lbOwnerAmountInfo.Text = myWallet.GetOwnerAmount();
                lbOwnerAmountInfo2.Text = anotherWallet.GetOwnerAmount();
            }
           
        }
    }
}
