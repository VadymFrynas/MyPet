using InterfaceModels;
using InterfaceService;
using System.IO;
using System.Windows;
namespace Wallet
{
    public partial class MainWindow : Window
    {


        private AccountServiceForInterface ForAccount;
        InterfaceAccount[] account;
        public MainWindow()
        {
            var Path = System.IO.Path.GetFullPath(@"MyData.json");
            InterfaceAccount[] accs = null;
            if (File.Exists(Path))
            {
                ForAccount = new AccountServiceForInterface(Path, accs);
                account = ForAccount.ForReading();
            }
            else
            {
                ForAccount = new AccountServiceForInterface(Path, accs);
                account = null;

            }
            ForAccount = new AccountServiceForInterface(Path, account);
            InitializeComponent();
        }
        public MainWindow(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
        }
        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {


            CreateAccount creation = new CreateAccount(ForAccount);
            creation.Show();
            Hide();

        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                AccountDeleting accountDeleting = new AccountDeleting(ForAccount);
                accountDeleting.Show();
                Hide();
            }
        }

        private void UpdateAccount_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                UpdateAccount update = new UpdateAccount(ForAccount);
                update.Show();
                Hide();
            }
        }

        private void ShowAllAccount_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                ShowAllAccount AllAcc = new ShowAllAccount(ForAccount);
                AllAcc.Show();
                Hide();
            }
        }

        private void ShowSum_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                ShowSum showSum = new ShowSum(ForAccount);
                showSum.Show();
                Hide();
            }
        }

        private void CreateCategory_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                AddCategory adding = new AddCategory(ForAccount);
                adding.Show();
                Hide();
            }
        }

        private void DeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                DeleteCategory delete = new DeleteCategory(ForAccount);
                delete.Show();
                Hide();
            }
        }

        private void UpdateCategory_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                UpdateCategories UpdCat = new UpdateCategories(ForAccount);
                UpdCat.Show();
                Hide();
            }
        }

        private void ShowAllCategory_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                ShowCategoriesList show = new ShowCategoriesList(ForAccount);
                show.Show();
                Hide();
            }
        }

        private void CreateExpense_income_Click_1(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                CreateExpInc ExpInc = new CreateExpInc(ForAccount);
                ExpInc.Show();
                Hide();
            }
        }

        private void DeleteExpense_income_Click_1(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                DeleteExpInc delete = new DeleteExpInc(ForAccount);
                delete.Show();
                Hide();
            }
        }

        private void TransferBetweenAcc_Click_1(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                TransferMoney transfer = new TransferMoney(ForAccount);
                transfer.Show();
                Hide();
            }
        }

        private void SearchCategory_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                SearchByCategory search = new SearchByCategory(ForAccount);
                search.Show();
                Hide();
            }
        }

        private void SearchExpen_Inc_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                SearchExpInctByCategory search = new SearchExpInctByCategory(ForAccount);
                search.Show();
                Hide();
            }
        }

        private void SearchExpen_IncByAmount_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                SearchExpIncByAmount search = new SearchExpIncByAmount(ForAccount);
                search.Show();
                Hide();
            }
        }

        private void SearchExpen_IncByDate_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                SearchExpIncByDate search = new SearchExpIncByDate(ForAccount);
                search.Show();
                Hide();
            }
        }

        private void SearchExpen_IncForPeriod_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                SearchIncOutByPeriod search = new SearchIncOutByPeriod(ForAccount);
                search.Show();
                Hide();
            }
        }

        private void GetStatisticforPeriod_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                GetStatisticByPeriod statistic = new GetStatisticByPeriod(ForAccount);
                statistic.Show();
                Hide();
            }
        }

        private void GetStatisticForCategory_Click(object sender, RoutedEventArgs e)
        {
            if (ForAccount.Accounts.Length == 0 || ForAccount.Accounts == null)
            {
                MessageBox.Show("There isn't any account");
            }
            else
            {
                GetStatisticForCategory statistic = new GetStatisticForCategory(ForAccount);
                statistic.Show();
                Hide();
            }
        }
    }
}
