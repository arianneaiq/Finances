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

        public String GetOwnerAmount()
        {
            return $"Amount of money is {Amount} euro";
        }

        public String negativeAmount() 
        {
            return $"You can not transfer negative amount";
        }

        public String notEnoughAmount()
        {
            return $"Sorry you don't have enough money in your account";
        }

        public String withdrawSucess()
        {
            return $"Withdraw succesfull";
        }

        public String addNegativeAmmount()
        {
            return $"You can not add a negative amount";
        }


        public void SetOwnerName(String aName)
        {
            Name = aName;
        }

        public int GetOwnerAmmount()
        {
           return Amount;
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
