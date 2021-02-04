using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Mapper;
using Entity;
namespace BLL
{
    public class AccountServices : IAccountServices
    {
        EntityContext<BankAccountEntity> BankContext;
        BankAccount[] accounts;
        public string success;
        public AccountServices(string Path, BankAccount[] Accounts)
        {
            BankContext = new EntityContext<BankAccountEntity>(Path);

            accounts = Accounts;

        }

        public BankAccount[] Accounts { get => accounts; set => accounts = value; }
        public string DeleteAccount(int index)
        {

            if (accounts == null) return "There are no any category";
            else
            {
                BankAccount[] buf = new BankAccount[accounts.Length - 1];
                if (index == 1)
                {
                    for (int i = index; i < accounts.Length; i++)
                    {
                        buf[i - 1] = accounts[i];
                    }

                }
                else if (index == accounts.Length)
                {
                    for (int i = 0; i < accounts.Length - 1; i++)
                    {
                        buf[i] = accounts[i];
                    }
                }
                else
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        buf[i] = accounts[i];
                    }
                    for (int i = index; i <accounts.Length; i++)
                    {
                        buf[i - 1] = accounts[i];
                    }
                }
                accounts = new BankAccount[buf.Length];
                accounts = buf;

                Accounts = accounts;
                BankContext.DeleteAllInfo();
                ForWriting(accounts);
                return "Successfully deleted";
            }

        }
        public string AddAccount(BankAccount account)
        {
            if (accounts == null)
            {
                accounts = new BankAccount[1] { account };
            }
            else
            {
                BankAccount[] buf = new BankAccount[accounts.Length + 1];
                for (int i = 0; i < accounts.Length; i++)
                {
                    buf[i] = accounts[i];
                }
                buf[accounts.Length] = account;
                accounts = new BankAccount[buf.Length];
                for (int i = 0; i < accounts.Length; i++)
                {
                    accounts[i] = buf[i];
                }
            }


            BankContext.DeleteAllInfo();
            ForWriting(accounts);
            return "Successfully deleted";

        }
        public string UpdateAccount(int index, BankAccount account)
        {
            accounts.SetValue(account, index);
            ForWriting(accounts);
            return "Successfully updated";

        }
        public string InfoAboutAcc(int index)
        {
            string str = accounts[index].ToString();
            if (accounts[index].Categories == null)
            {
                str += "There is no any outcome and income on this account\n";
            }
            else
            {
                foreach (Category category in accounts[index].Categories)
                {
                    str += category.ToString();
                }
            }
            return str;
        }
        public string InfoAllAcc()
        {
            string str = null;
            foreach (BankAccount acc in accounts)
            {
                str += acc.ToString();
                double OutSum = default;

                double IncSum = default;
                if (acc.Categories == null)
                {
                    str += "There is no any outcome and income on this account\n";

                }
                else
                {
                    foreach (Category category in acc.Categories)
                    {
                        OutSum += category.AllOutcomeSum();
                        IncSum += category.AllIncomeSum();
                    }
                    if (OutSum == 0)
                    {
                        str += "There is no any outcome on this account\n";
                    }
                    else
                    {
                        str += $"Total sum of outcomes in this account: {OutSum} uan.\n";
                    }
                    if (IncSum == 0)
                    {
                        str += "There is no any income on this account\n";
                    }
                    else
                    {
                        str += $"Total sum of incomes in this account: {IncSum} uan.\n";
                    }
                }

            }
            return str;

        }
        public void ForWriting(BankAccount[] accounts)
        {
            try
            {
                success = BankContext.WriteToFIle(accounts.ToEntities());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BankAccount[] ForReading()
        {
            
            return BankContext.ReadFromFile().ToBLLEntities();
        }
        
        public string AddCategory(int index, Category category)
        {
            accounts[index].AddCategory(category);
            BankContext.DeleteAllInfo();
            ForWriting(accounts);
            return "Successfully added";

        }

        public string DeleteCategory(int indexAcc, int indexCat)
        {
            accounts[indexAcc].DeleteCategory(indexCat);
            BankContext.DeleteAllInfo();
            ForWriting(accounts);
            return "Successfully deleted";

        }
        public string UpdateCategoryInfo(int indexAcc, int indexCat, Category category)
        {
            if (accounts[indexAcc].UpdateCategoryInfo(indexCat, category) == "This account hasn't got any categories empty")
            {
                return "This account hasn't got any categories empty";
            }
            else
            {
                accounts[indexAcc].UpdateCategoryInfo(indexCat, category);
                BankContext.DeleteAllInfo();
                ForWriting(accounts);
                return "Successfully deleted";
            }
        }
        public void AddIncome(int indexAcc, int indexCategory, Income income)
        {
            accounts[indexAcc].Categories[indexCategory].AddIncome(income);
            accounts[indexAcc].TotalWithIncome(income.IncomeCash);
            BankContext.DeleteAllInfo();
            ForWriting(accounts);
        }
        public void AddOutcome(int indexAcc, int indexCategory, Outcome outcome)
        {
            accounts[indexAcc].Categories[indexCategory].AddOutcome(outcome);
            accounts[indexAcc].TotalWithOutcome(outcome.OutcomeCash);
            BankContext.DeleteAllInfo();
            ForWriting(accounts);

        }
        public string TransferFromAccToAcc(int indexAcc1, int indexAcc2, double TransferCash)
        {
            if (accounts[indexAcc1].TotalMoney < TransferCash)
            {
                return $"Balance of the first acc isn't enough to transfer: {TransferCash} uan.";
            }
            else
            {
                accounts[indexAcc1].TotalWithOutcome(TransferCash);
                accounts[indexAcc2].TotalWithIncome(TransferCash);
                BankContext.DeleteAllInfo();
                ForWriting(accounts);
                return $"{TransferCash} uan. was successfully transfered";
            }
        }
        public string DeleteOutcome(int indexAcc, int indexCategory, int indexOutcome)
        {
            Outcome outcome = accounts[indexAcc].Categories[indexCategory].Outcomes[indexOutcome - 1];
            if (accounts[indexAcc].Categories[indexCategory].Outcomes == null)
            {
                return "There is no any outcome";
            }
            else
            {
                Outcome[] Outcomes = accounts[indexAcc].Categories[indexCategory].Outcomes;
                Outcome[] buf = new Outcome[accounts[indexAcc].Categories[indexCategory].Outcomes.Length - 1];
                if (indexOutcome == 0)
                {
                    for (int i = 0; i < Outcomes.Length - 1; i++)
                    {
                        buf[i] = Outcomes[i + 1];
                    }

                }
                else if (indexOutcome == Outcomes.Length)
                {
                    for (int i = 0; i < Outcomes.Length - 1; i++)
                    {
                        buf[i] = Outcomes[i];
                    }
                }
                else
                {
                    for (int i = 0; i < indexOutcome; i++)
                    {
                        buf[i] = Outcomes[i];
                    }
                    for (int i = indexOutcome; i < Outcomes.Length - 1; i++)
                    {
                        buf[i] = Outcomes[i + 1];
                    }
                }
                Outcomes = buf;

                accounts[indexAcc].Categories[indexCategory].Outcomes = Outcomes;
                accounts[indexAcc].TotalAfterDeletingOutcome(outcome.OutcomeCash);
                BankContext.DeleteAllInfo();
                ForWriting(accounts);
                return "Successfully deleted";
            }

        }
        public string DeleteIncome(int indexAcc, int indexCategory, int indexIncome)
        {
            Income income = accounts[indexAcc].Categories[indexCategory].Incomes[indexIncome - 1];
            if (accounts[indexAcc].Categories[indexCategory].Incomes == null)
            {
                return "There is no any income";
            }
            else
            {
                Income[] Incomes = accounts[indexAcc].Categories[indexCategory].Incomes;
                Income[] buf = new Income[accounts[indexAcc].Categories[indexCategory].Incomes.Length - 1];
                if (indexIncome == 0)
                {
                    for (int i = 0; i < Incomes.Length - 1; i++)
                    {
                        buf[i] = Incomes[i + 1];
                    }

                }
                else if (indexIncome == Incomes.Length)
                {
                    for (int i = 0; i < Incomes.Length - 1; i++)
                    {
                        buf[i] = Incomes[i];
                    }
                }
                else
                {
                    for (int i = 0; i < indexIncome; i++)
                    {
                        buf[i] = Incomes[i];
                    }
                    for (int i = indexIncome; i < Incomes.Length - 1; i++)
                    {
                        buf[i] = Incomes[i + 1];
                    }
                }
                Incomes = buf;

                accounts[indexAcc].Categories[indexCategory].Incomes = Incomes;
                accounts[indexAcc].TotalAfterDeletingIncome(income.IncomeCash);
                BankContext.DeleteAllInfo();
                ForWriting(accounts);
                return "Successfully deleted";
            }

        }
        public string SearchIncomeByDate(DateTime dateTime)
        {
            string str = null;
            bool Check = true;
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.Incomes != null)
                        {
                            foreach (Income income in category.Incomes)
                            {

                                if (income.DataTime.ToShortDateString() == dateTime.ToShortDateString())
                                {
                                    str += income.ToString();
                                    Check = false;
                                }
                            }
                        }
                    }
                }

            }
            if (Check)
            {
                str = "There is no any income on this date\n";
            }
            return str;

        }
        public string SearchOutcomeByDate(DateTime dateTime)
        {
            bool Check = true;

            string str = null;
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.Outcomes != null)
                        {
                            foreach (Outcome outcome in category.Outcomes)
                            {
                                if (outcome.DataTime.ToShortDateString() == dateTime.ToShortDateString())
                                {
                                    str += outcome.ToString();
                                    Check = false;
                                }
                            }
                        }
                    }
                }

            }
            if (Check)
            {
                str = "There is no any outcome on this date\n";
            }
            return str;

        }
        public string SearchCategory(string CategoryName)
        {
            string str = null;

            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.CategoryName == CategoryName)
                        {
                            str += category.ToString();
                        }
                    }
                }
            }
            if (str == null)
            {
                return "There is doesn't exist such category";
            }
            else return str;

        }
        public string SearchIncomeByCategory(string CategoryName)
        {
            string str = null;
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.CategoryName == CategoryName)
                        {
                            str += category.PrintIncomes();
                        }
                    }
                }
            }
            return str;
        }
        public string SearchOutcomeByCategory(string CategoryName)
        {
            string str = null;
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.CategoryName == CategoryName)
                        {
                            str += category.PrintOutcomes();
                        }
                    }
                }
            }
            return str;
        }
        public string SearchIncomeBySum(double Sum)
        {
            string str = null;
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.Incomes != null)
                        {
                            foreach (Income income in category.Incomes)
                            {
                                if (income.IncomeCash == Sum)
                                {
                                    str += $"Name of the account{account.OwnerName}\nName of the category: {category.CategoryName}\n{income.ToString()}";
                                }
                            }
                        }
                    }
                }
            }
            if (str == null)
            {
                str = "There is no any income with this sum\n";
            }
            return str;
        }
        public string SearchOutcomeBySum(double Sum)
        {
            string str = null;
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.Outcomes != null)
                        {
                            foreach (Outcome outcome in category.Outcomes)
                            {
                                if (outcome.OutcomeCash == Sum)
                                {
                                    str += $"Name of the category: {category.CategoryName}\n{outcome.ToString()}";
                                }
                            }
                        }
                    }
                }
            }
            if (str == null)
            {
                str = "There is no any outcome with this sum\n";
            }
            return str;
        }
        public string ShowAllCategories(int index)
        {
            return accounts[index].ShowAllCategories();
        }
        private Category GetIncOutByPeriodForStatistic(DateTime start, DateTime end)
        {
            string str = null;
            Category ForStat = new Category("ForStat");
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.Incomes != null)
                        {
                            for (int i = 0; i < category.Incomes.Length; i++)
                            {
                                if (category.Incomes[i].DataTime > start && category.Incomes[i].DataTime < end)
                                {
                                    ForStat.AddIncome(category.Incomes[i]);

                                }
                            }
                        }
                        if (category.Outcomes != null)
                        {
                            for (int i = 0; i < category.Outcomes.Length; i++)
                            {
                                if (category.Outcomes[i].DataTime > start && category.Outcomes[i].DataTime < end)
                                {
                                    ForStat.AddOutcome(category.Outcomes[i]);
                                }
                            }
                        }
                    }
                }
            }

            return ForStat;
        }
        public string GetIncOutByPeriod(DateTime start, DateTime end, string IncExp)
        {
            string str = null;
            Category ForStat = GetIncOutByPeriodForStatistic(start, end);
            if (IncExp == "Expence")
            {
                str = ForStat.PrintOutcomes();
            }
            if (IncExp == "Income")
            {
                str = ForStat.PrintIncomes();
            }

            return str;
        }
        public string GetStatisticIncExpByPeriod(DateTime start, DateTime end, string IncExp)
        {
            string str = null;
            bool CheckInc = true, CheckOut = true;
            Income IncTemp;
            double IncAvg = 0, OutAvg = 0;
            Outcome OutTemp;
            Category ForStat = GetIncOutByPeriodForStatistic(start, end);
            if (ForStat.Incomes != null)
            {
                CheckInc = false;
                for (int i = 0; i < ForStat.Incomes.Length - 1; i++)
                {
                    for (int j = i + 1; j < ForStat.Incomes.Length; j++)
                    {
                        if (ForStat.Incomes[i].IncomeCash > ForStat.Incomes[j].IncomeCash)
                        {
                            IncTemp = ForStat.Incomes[i];
                            ForStat.Incomes[i] = ForStat.Incomes[j];
                            ForStat.Incomes[j] = IncTemp;
                        }
                    }
                }
            }
            if (ForStat.Outcomes != null)
            {
                CheckOut = false;
                for (int i = 0; i < ForStat.Outcomes.Length - 1; i++)
                {
                    for (int j = i + 1; j < ForStat.Outcomes.Length; j++)
                    {
                        if (ForStat.Outcomes[i].OutcomeCash > ForStat.Outcomes[j].OutcomeCash)
                        {
                            OutTemp = ForStat.Outcomes[i];
                            ForStat.Outcomes[i] = ForStat.Outcomes[j];
                            ForStat.Outcomes[j] = OutTemp;
                        }
                    }
                }

            }
            if (IncExp == "Expence")
            {
                if (!CheckOut)
                {
                    str += $"Maximal expanse during this period was \n{ForStat.Outcomes[ForStat.Outcomes.Length - 1].ToString()}\n" +
                        $"Minimal expanse during this period was \n{ForStat.Outcomes[0].ToString()}\n" +
                        $"Total sum of expenses during this period: -{ForStat.AllOutcomeSum()}\n\n" +
                        $"Average sum of expanses is equal {ForStat.AllOutcomeSum() / ForStat.Outcomes.Length}\n\n";
                }
                else
                {
                    str += "There is no any expense during this time\n ";
                }
            }
            if (IncExp == "Income")
            {
                if (!CheckInc)
                {
                    str = $"Maximal income during this period was \n{ForStat.Incomes[ForStat.Incomes.Length - 1].ToString()}\n" +
                            $"Minimal income during this period was \n{ForStat.Incomes[0].ToString()}\n" +
                            $"Total sum of incomes during this period: +{ForStat.AllIncomeSum()}\n\n" +
                            $"Average sum of incomes is equal {ForStat.AllIncomeSum() / ForStat.Incomes.Length}\n\n";
                }
                else
                {
                    str += "There is no any income during this time\n ";
                }
            }
            return str;


        }
        public string GetStatisticForCategory(string CategoryName, string IncExp)
        {
            Income IncTemp;
            Outcome OutTemp;
            string str = null;
            bool Check = true;
            Category ForStat = new Category("ForStat");
            foreach (BankAccount account in accounts)
            {
                if (account.Categories != null)
                {
                    foreach (Category category in account.Categories)
                    {
                        if (category.CategoryName == CategoryName)
                        {
                            ForStat = category;
                            Check = false;
                            break;
                        }

                    }
                }
            }
            if (!Check)
            {
                if (IncExp == "Expence")
                {
                    if (ForStat.Outcomes != null)
                    {
                        for (int i = 0; i < ForStat.Outcomes.Length - 1; i++)
                        {
                            for (int j = i + 1; j < ForStat.Outcomes.Length; j++)
                            {
                                if (ForStat.Outcomes[i].OutcomeCash > ForStat.Outcomes[j].OutcomeCash)
                                {
                                    OutTemp = ForStat.Outcomes[i];
                                    ForStat.Outcomes[i] = ForStat.Outcomes[j];
                                    ForStat.Outcomes[j] = OutTemp;
                                }
                            }
                        }
                    }
                    if (ForStat.Outcomes != null && ForStat.Outcomes.Length != 0)
                    {
                        str += $"Maximal expanse in this category was \n{ForStat.Outcomes[ForStat.Outcomes.Length - 1].ToString()}\n" +
                              $"Minimal expanse in this category was \n{ForStat.Outcomes[0].ToString()}\n" +
                              $"Total sum of expenses in this category: -{ForStat.AllOutcomeSum()}\n\n" +
                              $"Average sum of expanses is equal {ForStat.AllOutcomeSum() / ForStat.Outcomes.Length}\n\n";
                    }
                    else
                    {
                        str += "There is no any expense in this category\n ";
                    }
                }
                if (IncExp == "Income")
                {
                    if (ForStat.Incomes != null)
                    {
                        for (int i = 0; i < ForStat.Incomes.Length - 1; i++)
                        {
                            for (int j = i + 1; j < ForStat.Incomes.Length; j++)
                            {
                                if (ForStat.Incomes[i].IncomeCash > ForStat.Incomes[j].IncomeCash)
                                {
                                    IncTemp = ForStat.Incomes[i];
                                    ForStat.Incomes[i] = ForStat.Incomes[j];
                                    ForStat.Incomes[j] = IncTemp;
                                }
                            }
                        }
                    }
                    if (ForStat.Incomes != null && ForStat.Incomes.Length != 0)
                    {
                        str = $"Maximal income in this category was \n{ForStat.Incomes[ForStat.Incomes.Length - 1].ToString()}\n" +
                                $"Minimal income in this category was \n{ForStat.Incomes[0].ToString()}\n" +
                                $"Total sum of incomes in this category: +{ForStat.AllIncomeSum()}\n\n" +
                                $"Average sum of incomes is equal {ForStat.AllIncomeSum() / ForStat.Incomes.Length}\n\n";
                    }
                    else
                    {
                        str += "There is no any income in this category\n ";
                    }
                }
            }
            return str;

        }



    }

}

