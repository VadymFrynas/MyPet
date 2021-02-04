using System;
using System.Collections.Generic;
using System.Text;
using Entity;
namespace BLL
{
    public interface IAccountServices
    {
        string DeleteAccount(int index);
        string AddAccount(BankAccount account);
        string UpdateAccount(int index, BankAccount account);
        string InfoAboutAcc(int index);
        string InfoAllAcc();
        void ForWriting(BankAccount[] accounts);
        BankAccount[] ForReading();
        string AddCategory(int index, Category category);


        string DeleteCategory(int indexAcc, int indexCat);
        string UpdateCategoryInfo(int indexAcc, int indexCat, Category category);
        void AddIncome(int indexAcc, int indexCategory, Income income);
        void AddOutcome(int indexAcc, int indexCategory, Outcome outcome);
        string TransferFromAccToAcc(int indexAcc1, int indexAcc2, double TransferCash);
        string DeleteOutcome(int indexAcc, int indexCategory, int indexOutcome);
        string DeleteIncome(int indexAcc, int indexCategory, int indexIncome);


        string SearchIncomeByDate(DateTime dateTime);
        string SearchOutcomeByDate(DateTime dateTime);
        string SearchCategory(string CategoryName);
        string SearchIncomeByCategory(string CategoryName);
        string SearchOutcomeByCategory(string CategoryName);
        string SearchIncomeBySum(double Sum);
        string SearchOutcomeBySum(double Sum);
        string ShowAllCategories(int index);
        string GetIncOutByPeriod(DateTime start, DateTime end, string IncExp);
        string GetStatisticIncExpByPeriod(DateTime start, DateTime end, string IncExp);
        string GetStatisticForCategory(string CategoryName, string IncExp);
    }
}
