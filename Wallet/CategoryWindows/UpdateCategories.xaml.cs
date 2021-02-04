using InterfaceModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{
    public partial class UpdateCategories : Window
    {
        AccountServiceForInterface ForAccount;
        static TreeViewItem item;
        public UpdateCategories(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            Show(treeView, ForAccount);
        }
        static public void Show(TreeView tree, AccountServiceForInterface ForAccount)
        {


            InterfaceAccount[] account = ForAccount.Accounts;

            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                item = new TreeViewItem();
                item.Header = ForAccount.Accounts[i].DisplayOwnerAndNumber;
                if (ForAccount.Accounts[i].Categories == null)
                {
                    item.Items.Add("There is no any categories in this account");
                }
                else
                {

                    for (int j = 0; j < ForAccount.Accounts[i].Categories.Length; j++)
                    {
                        item.Items.Add(ForAccount.Accounts[i].Categories[j].CategoryName);
                    }

                }
                tree.Items.Add(item);
            }
        }

        private void AccountName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AccountName.Background = Brushes.DarkSeaGreen;
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AccountName.Background = Brushes.DarkSeaGreen;
        }

        private void NewCategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AccountName.Background = Brushes.DarkSeaGreen;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            bool checkAccount = true;
            bool checkCategory = true;
            int indexAcc = default;
            int indexCategory = default;
            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                if (ForAccount.Accounts[i].OwnerName == AccountName.Text)
                {
                    checkAccount = false;
                    indexAcc = i;
                }
                if (!checkAccount)
                {
                    for (int j = 0; j < ForAccount.Accounts[indexAcc].Categories.Length; j++)
                    {
                        if (ForAccount.Accounts[indexAcc].Categories[j].CategoryName == CategoryName.Text)
                        {
                            indexCategory = j;
                            checkCategory = false;
                            break;
                        }
                    }
                }
            }
            if (!checkCategory && !checkAccount)
            {
                ForAccount.UpdateCategoryInfo(indexAcc, indexCategory, new InterfaceCategory(NewCategoryName.Text));
                MessageBox.Show("Successfully updated");
            }
            else if (checkAccount || checkAccount || NewCategoryName.Text.Length < 2)
            {
                MessageBox.Show("Write correct name");
                if (checkAccount)
                {
                    AccountName.Background = Brushes.Red;
                }
                if (checkCategory)
                {
                    CategoryName.Background = Brushes.Red;
                }
                if (NewCategoryName.Text.Length < 2)
                {
                    NewCategoryName.Background = Brushes.Red;
                }
            }

        }
    }
}
