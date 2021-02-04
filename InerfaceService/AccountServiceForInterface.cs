using System;
using BLL;
using InterfaceModels;
using MapperForInterface;

namespace InterfaceService
{
    public class AccountServiceForInterface
    {
        AccountServices ForAccount;
        InterfaceAccount[] accounts;
        public InterfaceAccount[] Accounts { get => ForAccount.Accounts.ToInterfaceEntities(); set => ForAccount.Accounts = value.ToBllEntities(); }

        public AccountServiceForInterface(string Path, InterfaceAccount[] accounts)
        {
            ForAccount = new AccountServices(Path, accounts.ToBllEntities());
            this.accounts = accounts;

        }
       
        public string DeleteAccount(int index)
        {
            ForAccount.DeleteAccount(index);
            return "Successfully deleted";

        }
        public string AddAccount(InterfaceAccount account)
        {
            ForAccount.AddAccount(account.ToBllEntity());
            return "Successfully deleted";

        }
        public string UpdateAccount(int index, InterfaceAccount account)
        {
            ForAccount.UpdateAccount(index, account.ToBllEntity());
            return "Successfully updated";

        }
        public string InfoAboutAcc(int index)
        {
            return ForAccount.InfoAboutAcc(index);
        }
        public string InfoAllAcc()
        {
            return ForAccount.InfoAllAcc();

        }
        public void ForWriting(InterfaceAccount[] accounts)
        {
            ForAccount.ForWriting(accounts.ToBllEntities());

        }
        public InterfaceAccount[] ForReading()
        {
            
            return ForAccount.ForReading().ToInterfaceEntities();
        }
        
        public string AddCategory(int index, InterfaceCategory category)
        {
            ForAccount.AddCategory(index, category.ToBllEntity());
            return "Successfully added";

        }

        public string DeleteCategory(int indexAcc, int indexCat)
        {

            ForAccount.DeleteCategory(indexAcc, indexCat);
            return "Successfully deleted";

        }
        public string UpdateCategoryInfo(int indexAcc, int indexCat, InterfaceCategory category)
        {
            ForAccount.UpdateCategoryInfo(indexAcc, indexCat, category.ToBllEntity());
            return "Successfully deleted";
        }
        public void AddIncome(int indexAcc, int indexCategory, InterfaceIncome income)
        {
            ForAccount.AddIncome(indexAcc, indexCategory, income.ToBllEntity());
        }
        public void AddOutcome(int indexAcc, int indexCategory, InterfaceOutcome outcome)
        {
            ForAccount.AddOutcome(indexAcc, indexCategory, outcome.ToBllEntity());
        }
        public string TransferFromAccToAcc(int indexAcc1, int indexAcc2, double TransferCash)
        {
            return  ForAccount.TransferFromAccToAcc(indexAcc1, indexAcc2, TransferCash);
            

        }
        public string DeleteOutcome(int indexAcc, int indexCategory, int indexOutcome)
        {
            return ForAccount.DeleteOutcome(indexAcc, indexCategory, indexOutcome);

        }
        public string DeleteIncome(int indexAcc, int indexCategory, int indexIncome)
        {
            return ForAccount.DeleteIncome(indexAcc, indexCategory, indexIncome);

        }

        public string SearchIncomeByDate(DateTime dateTime)
        {
            
            return ForAccount.SearchIncomeByDate(dateTime);

        }
        public string SearchOutcomeByDate(DateTime dateTime)
        {

            return ForAccount.SearchOutcomeByDate(dateTime);

        }
        public string SearchCategory(string CategoryName)
        {
            return ForAccount.SearchCategory(CategoryName);

        }
        public string SearchIncomeByCategory(string CategoryName)
        {
            return ForAccount.SearchIncomeByCategory(CategoryName);
        }
        public string SearchOutcomeByCategory(string CategoryName)
        {
           
            return ForAccount.SearchOutcomeByCategory(CategoryName);
        }
        public string SearchIncomeBySum(double Sum)
        {
            return ForAccount.SearchIncomeBySum(Sum);
             
        }
        public string SearchOutcomeBySum(double Sum)
        {
            
            return ForAccount.SearchOutcomeBySum(Sum);
        }
        public string ShowAllCategories(int index) 
        {
            return ForAccount.ShowAllCategories(index);
        }
        public string GetIncOutByPeriod(DateTime start, DateTime end,string IncExp)
        {
            return ForAccount.GetIncOutByPeriod(start, end, IncExp);
        }
        public string GetStatisticIncExpByPeriod(DateTime start, DateTime end, string IncExp) 
        {
            return ForAccount.GetStatisticIncExpByPeriod(start, end, IncExp);
        }
        public string GetStatisticForCategory(string CategoryName, string IncExp) 
        {
            return ForAccount.GetStatisticForCategory(CategoryName, IncExp);
        }
    }
}
