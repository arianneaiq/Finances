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
            lbOwnerAmountInfo.Text = myWallet.GetOwnerAmountToAdd();
            lbOwnerAmountInfo.Text = myWallet.GetOwnerAmountWithdraw();
        }

        private void btnSetOwnerName_Click(object sender, EventArgs e)
        {
          myWallet.SetOwnerName(tbSetName.Text);
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            myWallet.AddMoney(Convert.ToInt32(tbAddMoney.Text));
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            myWallet.WithdrawMoney(Convert.ToInt32(tbWithdrawMoney.Text));
        }

        //Wallet 2

        private void btnShowInfo2_Click(object sender, EventArgs e)
        {
            lbOwnerNameInfo2.Text = anotherWallet.GetOwnerName();
            lbOwnerAmountInfo2.Text = anotherWallet.GetOwnerAmountToAdd();
            lbOwnerAmountInfo2.Text = anotherWallet.GetOwnerAmountWithdraw();
        }

        private void btnSetOwnerName2_Click(object sender, EventArgs e)
        {
            anotherWallet.SetOwnerName(tbSetName2.Text);
        }

        private void btnAddMoney2_Click(object sender, EventArgs e)
        {
            anotherWallet.AddMoney(Convert.ToInt32(tbAddMoney2.Text));
        }

        private void btnWithdrawMoney2_Click(object sender, EventArgs e)
        {
            anotherWallet.WithdrawMoney(Convert.ToInt32(tbWithdrawMoney2.Text));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
