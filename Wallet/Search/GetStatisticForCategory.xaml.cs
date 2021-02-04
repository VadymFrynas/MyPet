using InterfaceService;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Wallet
{
  
    public partial class GetStatisticForCategory : Window
    {
        AccountServiceForInterface ForAccount;
        TextBlock selectedItem;
        public GetStatisticForCategory(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
        }

        private void GetStats_Click(object sender, RoutedEventArgs e)
        {

            bool checkCategory = true;
            int indexCategory = default;
            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                if (ForAccount.Accounts[i].Categories != null)
                {
                    for (int j = 0; j < ForAccount.Accounts[i].Categories.Length; j++)
                    {
                        if (ForAccount.Accounts[i].Categories[j].CategoryName == CategoryName.Text)
                        {
                            indexCategory = j;
                            checkCategory = false;
                            break;
                        }
                    }
                }
            }
            if (!checkCategory && CategoryName.Text != "" && selectedItem != null)
            {
                if (selectedItem.Text == "Income")
                {
                    MessageBox.Show(ForAccount.GetStatisticForCategory(CategoryName.Text, "Income"));
                }
                else if (selectedItem.Text == "Expence")
                {
                    MessageBox.Show(ForAccount.GetStatisticForCategory(CategoryName.Text, "Expence"));
                }
                else
                {
                    MessageBox.Show(ForAccount.GetStatisticForCategory(CategoryName.Text, "Income")
                        + ForAccount.GetStatisticForCategory(CategoryName.Text, "Expence"));
                }
            }
            else
            {
                if (CategoryName.Text != "")
                {
                    CategoryName.Background = Brushes.Red;
                }
                if (checkCategory)
                {
                    CategoryName.Background = Brushes.Red;
                }
                if (selectedItem == null)
                {
                    IncExp.Background = Brushes.Red;
                }
                MessageBox.Show("Write correctly");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryName.Background = Brushes.DarkSeaGreen;
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
