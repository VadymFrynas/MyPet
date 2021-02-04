using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Mapper;
using DAL;
using System.Runtime.Serialization;

namespace BLL.Tests
{
    [TestClass()]
    public class ForAccountTests
    {


        [TestMethod()]
        public void DeleteFirstAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            string expected = account2.ToString() + account3.ToString();
            forAccount.DeleteAccount(1);
            string actual = forAccount._Accounts[0].ToString() + forAccount._Accounts[1].ToString();



            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteLastAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            string expected = account1.ToString() + account2.ToString();
            forAccount.DeleteAccount(3);
            string actual = forAccount._Accounts[0].ToString() + forAccount._Accounts[1].ToString();



            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DeleteNotFirstNotLastAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            string expected = account1.ToString() + account3.ToString();
            forAccount.DeleteAccount(2);
            string actual = forAccount._Accounts[0].ToString() + forAccount._Accounts[1].ToString();



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfBounds_DeleteAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            forAccount.DeleteAccount(4);
        }

        [TestMethod()]
        public void AddEmpty_AddAccountTest()
        {
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            Category[] categories = new Category[] { category1, category2, category3 };
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", categories, "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            double expected = 3;
            double actual = accounts.Length;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void AddFirst_AddAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddAccount(account1);
            string expected = account1.ToString();
            string actual = forAccount._Accounts[0].ToString();


            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddNotFirst_AccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddAccount(account2);
            string expected = account1.ToString() + account2.ToString();
            string actual = forAccount._Accounts[0].ToString() + forAccount._Accounts[1].ToString();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UpdateAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            string expected = account3.ToString() + account2.ToString() + account3.ToString();
            forAccount.UpdateAccount(0, account3);
            string actual = forAccount._Accounts[0].ToString() + forAccount._Accounts[1].ToString() + forAccount._Accounts[2].ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfBounds_UpdateAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";

            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);


            forAccount.UpdateAccount(4, account2);
        }

        [TestMethod()]
        public void NotFirstElement_UpdateAccountTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            string expected = account1.ToString() + account3.ToString() + account3.ToString();
            forAccount.UpdateAccount(1, account3);
            string actual = forAccount._Accounts[0].ToString() + forAccount._Accounts[1].ToString() + forAccount._Accounts[2].ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void InfoAboutAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            string expected = account1.ToString() + "There is no any outcome and income on this account\n";
            string actual = forAccount.InfoAboutAcc(0);
            Assert.AreEqual(expected, actual);
        }[TestMethod()]
        public void NotFirst_InfoAboutAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            string expected = account2.ToString() + "There is no any outcome and income on this account\n";
            string actual = forAccount.InfoAboutAcc(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void WithCategories_InfoAboutAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            forAccount.AddCategory(0, category1);


            string expected = account1.ToString() + category1.ToString();
            string actual = forAccount.InfoAboutAcc(0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfBounds_InfoAboutAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            forAccount.InfoAboutAcc(4);
        }

        [TestMethod()]
        public void InfoAllAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";

            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);


            string expected = forAccount.InfoAboutAcc(0) + forAccount.InfoAboutAcc(1) + forAccount.InfoAboutAcc(2);
            string actual = forAccount.InfoAllAcc();
            Assert.AreEqual(expected, actual);
        }
         [TestMethod()]
        public void InfoAllAccTest2()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            account2.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 12));
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 15, new DateTime(2020, 11, 15));
            BankAccount[] accounts = new BankAccount[] { account1, account2};
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddIncome(0, 0, income2);

            string expected = forAccount._Accounts[0].ToString() + $"Total sum of outcomes in this account: {forAccount._Accounts[0]._Categories[0].AllOutcomeSum()} uan.\n"
                + $"Total sum of incomes in this account: {forAccount._Accounts[0]._Categories[0].AllIncomeSum()} uan.\n"+
                forAccount._Accounts[1].ToString()+ $"Total sum of outcomes in this account: {forAccount._Accounts[1]._Categories[0].AllOutcomeSum()} uan.\n"
                + $"Total sum of incomes in this account: {forAccount._Accounts[1]._Categories[0].AllIncomeSum()} uan.\n";
            string actual = forAccount.InfoAllAcc();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]

        public void ForWritingTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";

            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            forAccount.ForWriting(accounts);
            string expected = "Successfully serialized";
            string actual = forAccount.success;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(SerializationException))]
        public void ForReadingTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.ForWriting(accounts);
            string expected = account1.ToString() + account2.ToString();
            BankAccount[] account = forAccount.ForReading();

        }

        [TestMethod()]
        public void AddCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);


            string expected = "Successfully added";
            string actual = forAccount.AddCategory(0, category1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NotFirst_AddCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            string expected = "Successfully added";
            string actual = forAccount.AddCategory(1, category1);
            Assert.AreEqual(expected, actual);
        }[TestMethod()]
        public void AddSecondCategory_AddCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);


            string expected = category2.ToString();
            forAccount.AddCategory(1, category2);
            string actual = forAccount._Accounts[1]._Categories[0].ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfBounds_AddCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            forAccount.AddCategory(4, category1);
        }

        [TestMethod()]
        public void First_DeleteCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddCategory(0, category1);
            forAccount.AddCategory(0, category2);
            forAccount.AddCategory(0, category3);


            string expected = category2.ToString() + category3.ToString();
            forAccount.DeleteCategory(0, 1);
            string actual = forAccount._Accounts[0]._Categories[0].ToString() + forAccount._Accounts[0]._Categories[1].ToString();



            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Last_DeleteCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddCategory(0, category1);
            forAccount.AddCategory(0, category2);
            forAccount.AddCategory(0, category3);

            double expected = 1;
            forAccount.DeleteCategory(0, 3);
            forAccount.DeleteCategory(0, 2);
            double actual = forAccount._Accounts[0]._Categories.Length;



            Assert.AreEqual(expected, actual);
        }
      

        [TestMethod()]
        public void GetIncByPeriod() 
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 14));
            Income income3 = new Income("Bread", 10, new DateTime(2020, 11, 10));
            
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
       
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income3);
            string expected=income2.ToString();
            string actual = forAccount.GetIncOutByPeriod(new DateTime(2020, 11, 12), new DateTime(2020, 11, 15), "Income");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void GetOutByPeriod()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 14));
            Outcome outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 10));

            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            forAccount.AddOutcome(0, 0, outcome2);
            forAccount.AddOutcome(0, 0, outcome3);
            string expected = outcome2.ToString();
            string actual = forAccount.GetIncOutByPeriod(new DateTime(2020, 11, 12), new DateTime(2020, 11, 15), "Expence");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void GetOutNullByPeriod()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            string expected = "There are no any outcome on this account\n";
            string actual = forAccount.GetIncOutByPeriod(new DateTime(2020, 11, 12), new DateTime(2020, 11, 15), "Expence");
            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void UpdateCategoryInfoTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            Category category2 = new Category("OnFun");
            Category category3 = new Category("OnRoad");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddCategory(0, category1);
            forAccount.AddCategory(0, category2);
            forAccount.AddCategory(0, category3);
            forAccount.UpdateCategoryInfo(0, 0, category3);
            string expected = category3.ToString() + category2.ToString();
            string actual = forAccount._Accounts[0]._Categories[0].ToString() + forAccount._Accounts[0]._Categories[1].ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestForNullCateg_UpdateCategory()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            string expected = "This account hasn't got any categories empty";
            string actual = forAccount.UpdateCategoryInfo(0, 0, category1);
            Assert.AreEqual(expected, actual);



        }

        [TestMethod()]
        public void AddIncomeTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Income income1 = new Income();
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 10, new DateTime(2020, 11, 11));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddIncome(0, 0, income3);
            forAccount.AddIncome(0, 0, income2);
            double expected = 2;
            double actual = forAccount._Accounts[0]._Categories[0]._Incomes.Length;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddOutcomeTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 11));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.AddOutcome(0, 0, Outcome2);
            double expected = 2;
            double actual = forAccount._Accounts[0]._Categories[0]._Outcome.Length;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void TransferFromAccToAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 100);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.TransferFromAccToAcc(0, 1, 50);
            double expected = 50;
            double actual = forAccount._Accounts[0]._TotalMoney;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TooMuch_TransferFromAccToAccTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 100);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);

            string expected = "Balance of the first acc isn't enough to transfer: 150 uan.";
            string actual = forAccount.TransferFromAccToAcc(0, 1, 150);
            Assert.AreEqual(expected, actual);
        }

        

        [TestMethod()]
        public void DeleteIncomeTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 15, new DateTime(2020, 11, 15));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income3);
            forAccount.DeleteIncome(0, 0, 1);
            forAccount.DeleteIncome(0, 0, 2);
            forAccount.DeleteIncome(0, 0, 2);
            string expected = income2.ToString();
            string actual = forAccount._Accounts[0]._Categories[0]._Incomes[0].ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DeleteOutcomeomeTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1); 
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 12));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.DeleteOutcome(0, 0, 1);
            forAccount.DeleteOutcome(0, 0, 2);
            forAccount.DeleteOutcome(0, 0, 2);
            string expected = Outcome2.ToString();
            string actual = forAccount._Accounts[0]._Categories[0]._Outcome[0].ToString();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void SearchCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 11));
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 10, new DateTime(2020, 11, 11));
            category1.AddOutcome(Outcome3);
            category1.AddOutcome(Outcome2);
            category1.AddIncome(income2);
            category1.AddIncome(income3);
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income3);
            string expected = category1.ToString();
            string actual = forAccount.SearchCategory("OnFood");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchByCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 11));
            
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.AddOutcome(0, 0, Outcome2);
            string expected = "There are no any income on this account\n";
            string actual = forAccount.SearchIncomeByCategory("OnFood");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Income_GetStatisticIncExpByPeriodTest()
        {

            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 12));
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 15, new DateTime(2020, 11, 15));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income3);
            string expected = $"Maximal income during this period was \n{income3.ToString()}\n" +
                            $"Minimal income during this period was \n{income2.ToString()}\n" +
                            $"Total sum of incomes during this period: +{category1.AllIncomeSum()}\n\n" +
                            $"Average sum of incomes is equal {category1.AllIncomeSum() / category1._Incomes.Length}\n\n";
            string actual = forAccount.GetStatisticIncExpByPeriod(new DateTime(2020, 11, 10), new DateTime(2020, 11, 16), "Income");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Income_GetStatisticForCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 10, new DateTime(2020, 11, 12));
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 15, new DateTime(2020, 11, 15));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income3);
            string expected = $"Maximal income in this category was \n{income3.ToString()}\n" +
                            $"Minimal income in this category was \n{income2.ToString()}\n" +
                            $"Total sum of incomes in this category: +{category1.AllIncomeSum()}\n\n" +
                            $"Average sum of incomes is equal {category1.AllIncomeSum() / category1._Incomes.Length}\n\n";
            string actual=forAccount.GetStatisticForCategory("OnFood", "Income");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Outcome_GetStatisticForCategoryTest()
        {
            BankAccount account1 = new BankAccount("Vadym Frynas", "12121212", "123", 150);
            BankAccount account2 = new BankAccount("Ivan Frynas", "22222222", "222", 150);
            BankAccount account3 = new BankAccount("Petro Frynas", "33333333", "333", 150);
            string Path = @"C:\Users\user\source\repos\TestTerm\TermPaper\ForTest";
            Category category1 = new Category("OnFood");
            account1.AddCategory(category1);
            Outcome Outcome1 = new Outcome();
            Outcome Outcome2 = new Outcome("Milk", 10, new DateTime(2020, 11, 11));
            Outcome Outcome3 = new Outcome("Bread", 15, new DateTime(2020, 11, 12));
            Income income2 = new Income("Milk", 10, new DateTime(2020, 11, 11));
            Income income3 = new Income("Bread", 15, new DateTime(2020, 11, 15));
            BankAccount[] accounts = new BankAccount[] { account1, account2, account3 };
            AccountServices forAccount = new AccountServices(Path, accounts);
            forAccount.AddOutcome(0, 0, Outcome3);
            forAccount.AddOutcome(0, 0, Outcome2);
            forAccount.AddIncome(0, 0, income2);
            forAccount.AddIncome(0, 0, income3);
            string expected = $"Maximal expanse in this category was \n{Outcome3.ToString()}\n" +
                            $"Minimal expanse in this category was \n{Outcome2.ToString()}\n" +
                            $"Total sum of expenses in this category: -{category1.AllOutcomeSum()}\n\n" +
                            $"Average sum of expanses is equal {category1.AllOutcomeSum() / category1._Outcome.Length}\n\n";
            string actual = forAccount.GetStatisticForCategory("OnFood", "Expence");
            Assert.AreEqual(expected, actual);
        }
    }
}