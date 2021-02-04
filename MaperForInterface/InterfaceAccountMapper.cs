using System;
using InterfaceModels;
using Entity;
namespace MapperForInterface
{
    public static class InterfaceAccountMapper
    {
        public static BankAccount ToBllEntity(this InterfaceAccount account)
        {
            return new BankAccount(account.OwnerName, account.CardName,account.Categories.ToBllEntities(), account.AccountPassword, account.TotalMoney);
        }
        public static BankAccount[] ToBllEntities(this InterfaceAccount[] accounts)
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
                    bankAccountEntities[i] = accounts[i].ToBllEntity();
                }
                return bankAccountEntities;
            }
        }
        public static InterfaceAccount ToInterfaceEntity(this BankAccount account)
        {
            return new InterfaceAccount(account.OwnerName, account.CardName, account.Categories.ToInterfaceEntities(), account.AccountPassword, account.TotalMoney);
        }
        public static InterfaceAccount[] ToInterfaceEntities(this BankAccount[] accounts)
        {
            InterfaceAccount[] bankAccountEntities;
            if (accounts == null)
            {
                return bankAccountEntities = null;
            }
            else
            {
                bankAccountEntities = new InterfaceAccount[accounts.Length];
                for (int i = 0; i < bankAccountEntities.Length; i++)
                {
                    bankAccountEntities[i] = accounts[i].ToInterfaceEntity();
                }
                return bankAccountEntities;
            }
        }
    }
}
