using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{
    public partial class SearchExpInctByCategory : Window
    {
        AccountServiceForInterface ForAccount;
        TextBlock selectedItem;
        public SearchExpInctByCategory(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryName.Background = Brushes.DarkSeaGreen;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }


        private void Search_Click(object sender, RoutedEventArgs e)
        {
            bool CheckCategories = true;
            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                if (ForAccount.Accounts[i].Categories != null)
                {
                    for (int j = 0; j < ForAccount.Accounts[i].Categories.Length; j++)
                    {
                        if (ForAccount.Accounts[i].Categories[j].CategoryName == CategoryName.Text)
                        {
                            CheckCategories = false;
                            break;
                        }
                    }

                }
            }




            if (CategoryName.Text.Length > 1 && !CheckCategories && selectedItem != null)
            {
                if (selectedItem.Text == "Income")
                {
                    MessageBox.Show(ForAccount.SearchIncomeByCategory(CategoryName.Text));
                }
                else if (selectedItem.Text == "Expence")
                {
                    MessageBox.Show(ForAccount.SearchOutcomeByCategory(CategoryName.Text));
                }
                else
                {
                    MessageBox.Show(ForAccount.SearchIncomeByCategory(CategoryName.Text) + ForAccount.SearchOutcomeByCategory(CategoryName.Text));
                }
            }
            else
            {
                if (CategoryName.Text.Length < 1)
                {
                    CategoryName.Background = Brushes.Red;
                }
                if (selectedItem == null)
                {
                    IncExp.Background = Brushes.Red;
                }
                if (CheckCategories)
                {
                    CategoryName.Background = Brushes.Red;
                    MessageBox.Show("Such category doesn't exist");
                }
            }
        }

        private void IncExp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (TextBlock)IncExp.SelectedItem;
        }
        private void IncExp_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IncExp.Background = Brushes.DarkSeaGreen;
        }
    }
}
