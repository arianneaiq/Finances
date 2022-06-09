using System;
using System.Collections.Generic;
using System.Text;

namespace Finances
{
    internal class Wallet
    {
        private string Name;
        private int Amount;

        public String GetOwnerName()
        {
            return $"Wallet belongs to {Name}";
        }

        public String GetOwnerAmountToAdd()
        {
            return $"Amount of money is {Amount} euro";
        }

        public String GetOwnerAmountWithdraw()
        {
            return $"Amount of money is {Amount} euro";
        }

        public void SetOwnerName(String aName)
        {
            Name = aName;
        }


        public void AddMoney(int amountOfMoneyToAdd)
        {
           Amount += amountOfMoneyToAdd;
        }

        public void WithdrawMoney(int amountOfMoneyToWithdraw)
        {
            Amount -= amountOfMoneyToWithdraw;
        }
    }
}
