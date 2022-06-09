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

        public Form1()
        {
            InitializeComponent();

            myWallet = new Wallet();
            

        }

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
    }
}
