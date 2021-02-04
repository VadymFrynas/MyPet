using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BankAccount
    {
        string ownerName, cardName, accountPassword;
        double totalMoney;
        Category[] categories;
        public Category[] Categories { get => categories; set => categories = value; }

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string CardName { get => cardName; set => cardName = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        public string DisplayOwnerAndNumber { get => ownerName + " " + cardName; }
        public BankAccount(string OwnerName, string CardName, Category[] Categories, string AccountPassword, double TotalMoney)
        {

            accountPassword = AccountPassword;
            cardName = CardName;
            categories = Categories;
            ownerName = OwnerName;
            totalMoney = TotalMoney;
        }
        public BankAccount(string OwnerName, string CardName, string AccountPassword, double TotalMoney)
        {

            accountPassword = AccountPassword;
            cardName = CardName;
            ownerName = OwnerName;
            totalMoney = TotalMoney;
        }
        public BankAccount() { }
        public string AddCategory(Category category)
        {
            if (categories == null) categories = new Category[1] { category };
            else
            {
                Category[] buf = new Category[categories.Length + 1];
                for (int i = 0; i < categories.Length; i++)
                {
                    buf[i] = categories[i];
                }
                buf[categories.Length] = category;
                categories = new Category[buf.Length];
                for (int i = 0; i < categories.Length; i++)
                {
                    categories[i] = buf[i];
                }
            }
            Categories = categories;
            return "Successfully deleted";

        }
        public string DeleteCategory(int index)
        {
            if (categories == null) return "There are no any category";
            else
            {
                Category[] buf = new Category[categories.Length - 1];
                if (index == 1)
                {
                    for (int i = index; i < categories.Length; i++)
                    {
                        buf[i - 1] = categories[i];
                    }

                }
                else if (index == categories.Length)
                {
                    for (int i = 0; i < categories.Length - 1; i++)
                    {
                        buf[i] = categories[i];
                    }
                }
                else
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        buf[i] = categories[i];
                    }
                    for (int i = index; i < categories.Length; i++)
                    {
                        buf[i - 1] = categories[i];
                    }
                }
                categories = new Category[buf.Length];
                categories = buf;

                Categories = categories;
                return "Successfully deleted";
            }

        }
        public string UpdateCategoryInfo(int index, Category category)
        {
            if (categories == null)
            {
                return "This account hasn't got any categories empty";
            }
            else
            {
                categories.SetValue(category, index);
                Categories = categories;

                return "Successfully updated";
            }
        }
        public string ShowAllCategories()
        {
            string str = null;
            if (categories == null || categories.Length == default)
            {
                str += "There are no any category on this account.\n";
            }
            else
            {
                foreach (Category category in categories)
                {
                    str += category.ToString();
                }
            }
            return str;
        }
        public double TotalWithOutcome(double outcome)
        {
            if (TotalMoney < outcome)
            {
                return 0;
            }
            else
            {
                return TotalMoney -= outcome;
            }
        }

        public double TotalWithIncome(double Income) => TotalMoney += Income;
        public double TotalAfterDeletingOutcome(double outcome) => TotalMoney += outcome;
        public double TotalAfterDeletingIncome(double income) => TotalMoney -= income;
        public override string ToString()
        {
            return $"Name of the owner of this account: {OwnerName}\nCard number: {CardName}\nSum on this account: {TotalMoney} uan.\n";
        }

    }
}
