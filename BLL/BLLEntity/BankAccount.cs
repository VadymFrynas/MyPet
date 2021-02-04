using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public  class BankAccount
    {
        string OwnerName, CardName, AccountPassword;
        double TotalMoney;
        Category[] Categories;
        public Category[] _Categories { get => Categories; set => Categories = value; }

        public string _OwnerName { get => OwnerName; set => OwnerName = value; }
        public string _CardName { get => CardName; set => CardName = value; }
        public double _TotalMoney { get => TotalMoney; set => TotalMoney = value; }
        public string _AccountPassword { get => AccountPassword; set => AccountPassword = value; }
        public BankAccount(string OwnerName, string CardName, Category[] Categories, string AccountPassword, double TotalMoney)
        {

            this.AccountPassword = AccountPassword;
            this.CardName = CardName;
            this.Categories = Categories;
            this.OwnerName = OwnerName;
            this.TotalMoney = TotalMoney;
        }
        public BankAccount()
        {
            AccountPassword = default;
            CardName = default;
            OwnerName = default;
            TotalMoney = default;
        }
        public double TotalWithOutcome(double outcome)
        {
            if (TotalMoney < outcome) return 0;
            else return TotalMoney -= outcome;

        }
        public double TotalWithIncome(double Income) => TotalMoney += Income;
        public double TotalAfterDeletingOutcome(double outcome) => TotalMoney += outcome;
        public double TotalAfterDeletingIncome(double income) => TotalMoney -= income;
        public override string ToString()
        {
            return $"Name of the owner of this account: {OwnerName}\nCard number: {CardName}\nSum on this account: {TotalMoney} uan.";
        }

    }
}
