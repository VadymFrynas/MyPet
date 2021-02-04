using System;

namespace InterfaceModels
{
    public class InterfaceAccount
    {
        string ownerName, cardName, accountPassword;
        double totalMoney;
        InterfaceCategory[] categories;
        public InterfaceCategory[] Categories { get => categories; set => categories = value; }

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string CardName { get => cardName; set => cardName = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        public string DisplayOwnerAndNumber { get => ownerName + " " + cardName; }
        public InterfaceAccount(string ownerName, string cardName, InterfaceCategory[] categories, string accountPassword, double totalMoney)
        {

            this.accountPassword = accountPassword;
            this.cardName = cardName;
            this.categories = categories;
            this.ownerName = ownerName;
            this.totalMoney = totalMoney;
        }
        public InterfaceAccount(string ownerName, string cardName, string accountPassword, double totalMoney)
        {

            this.accountPassword = accountPassword;
            this.cardName = cardName;
            this.ownerName = ownerName;
            this.totalMoney = totalMoney;
        }
        public InterfaceAccount() { }
    }
}
