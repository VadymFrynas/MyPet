using System;
using DAL;
using BLL;
using Entity;
namespace TermPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //#34CFBE" 
            string Path = @"C:\Users\user\source\repos\TermPaper\1.json";
            BankAccount bank1 = new BankAccount("Vadym Frynas", "4567456745674567", "Password", 1890);
            BankAccount bank2 = new BankAccount("Ivan Petrov", "4567456745674567", "Password", 3000);
            BankAccount[] accs=null;
            ForAccount forAccount = new ForAccount(Path, accs);
            forAccount.AddAccount(bank1);
            forAccount.AddAccount(bank2);
            Console.WriteLine( forAccount.InfoAboutAcc(0));
            forAccount.TransferFromAccToAcc(0, 1, 200);
            
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            forAccount.AddCategory(0, new Category("OnFood"));
            forAccount.AddCategory(0, new Category("HellFood"));
            forAccount.AddOutcome(0, 1, new Outcome("Bought water", 102,new DateTime(2020,11,12)));

            forAccount.AddCategory(0, new Category("FuckFood"));
            Console.WriteLine(forAccount.InfoAboutAcc(0));
            Console.WriteLine("||||||||||||||||||||||||||||||||");

            forAccount.DeleteCategory(0, 1);

            Console.WriteLine(  forAccount.InfoAboutAcc(0));
            Console.WriteLine("||||||||||||||||||||||||||||||||");

             forAccount.AddOutcome(0,0, new Outcome("Bought milk", 13.50,new DateTime(2020, 11, 14)));
            forAccount.AddOutcome(0,0, new Outcome("Bought water", 10, new DateTime(2020, 11, 12)));
            forAccount.InfoAboutAcc(0);
            Console.WriteLine("||||||||||||||||||||||||||||||||");

            forAccount.AddOutcome(0,1, new Outcome("Bought water", 102, new DateTime(2020, 11, 17)));
           
            forAccount.AddOutcome(0, 1, new Outcome("Bought beer", 18.5, new DateTime(2020, 11, 12)));
            forAccount.AddAccount(new BankAccount("Hello world", "4567456745674567", "Password", 3000));
            forAccount.AddCategory(1, new Category("Rain"));
            forAccount.AddCategory(1, new Category("Salary"));

            forAccount.AddIncome(1, 1, new Income("Monthly salary ", 18000, new DateTime(2020, 11, 12)));
            forAccount.AddCategory(1, new Category("Suny"));
            Console.WriteLine( forAccount.InfoAllAcc());
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchIncomeByDate(new DateTime(2020, 11, 12)));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchOutcomeByDate(new DateTime(2020, 11, 12)));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchCategory("OnFood"));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchIncomeByCategory("Salary"));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchOutcomeByCategory("OnFood"));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchIncomeBySum(18000));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchOutcomeBySum(10));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine(forAccount.SearchOutcomeBySum(1));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            forAccount.DeleteCategory(0, 1);
            Console.WriteLine(forAccount.InfoAboutAcc(0));
            Console.WriteLine(forAccount.InfoAboutAcc(2));
            Console.WriteLine(forAccount.InfoAboutAcc(1));
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            forAccount.ForWriting(forAccount._Accounts);
            BankAccount[] banks = forAccount.ForReading();
            ForAccount forAccount1 = new ForAccount(Path, banks);
            Console.WriteLine(forAccount1.InfoAllAcc()  );

          
        }
    }
}
