using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    [Serializable]
    public class BankAccountEntity
    {
        string ownerName, cardName, accountPassword;
        double totalMoney;
        CategoryEntity[] categories;
        public CategoryEntity[] Categories { get => categories; set => categories = value; }

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string CardName { get => cardName; set => cardName = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        
        public BankAccountEntity(string ownerName, string cardName, CategoryEntity[] categories, string accountPassword, double totalMoney) 
        {

            this.accountPassword = accountPassword;
            this.cardName = cardName;
            this.categories = categories;
            this.ownerName = ownerName;
            this.totalMoney = totalMoney;
        }
       
    }
}
