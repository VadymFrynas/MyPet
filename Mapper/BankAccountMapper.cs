using System;
using DAL;
using Entity;
namespace Mapper
{
    public static class BankAccountMapper
    {
        public static BankAccountEntity ToEntity(this BankAccount account)
        {
            return new BankAccountEntity(account.OwnerName, account.CardName, account.Categories.ToEntities(), account.AccountPassword,account.TotalMoney);
        }
        public static BankAccountEntity[] ToEntities(this BankAccount[] accounts)
        {
            BankAccountEntity[] bankAccountEntities;
            if (accounts == null)
            {
                return bankAccountEntities = null;
            }
            else
            {
                bankAccountEntities = new BankAccountEntity[accounts.Length];
                for (int i = 0; i < bankAccountEntities.Length; i++)
                {
                    bankAccountEntities[i] = accounts[i].ToEntity();
                }
                return bankAccountEntities;
            }
        }
        public static BankAccount ToBLLEntity(this BankAccountEntity account)
        {
            return new BankAccount(account.OwnerName, account.CardName, account.Categories.ToBLLEntities(), account.AccountPassword, account.TotalMoney);
        }
        public static BankAccount[] ToBLLEntities(this BankAccountEntity[] accounts)
        {
            BankAccount[] bankAccountEntities;
            if (accounts == null)
            {
                return bankAccountEntities = null;
            }
            else
            {
                bankAccountEntities = new BankAccount[accounts.Length];
                for (int i = 0; i < bankAccountEntities.Length; i++)
                {
                    bankAccountEntities[i] = accounts[i].ToBLLEntity();
                }
                return bankAccountEntities;
            }
        }
    }
}
