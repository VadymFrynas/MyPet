using InterfaceModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using InterfaceService;

namespace Wallet
{
    public partial class UpdateAccount : Window
    {
        AccountServiceForInterface ForAccount;

        List<InterfaceAccount> list;

        public UpdateAccount(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();

            list = new List<InterfaceAccount>(ForAccount.Accounts);
            MyGrid.ItemsSource = list;
        }

        private void SaveUpdating_Click(object sender, RoutedEventArgs e)
        {
            
            InterfaceAccount[] accounts = list.ToArray();
            for (int i = 0; i < accounts.Length; i++)
            {
                ForAccount.UpdateAccount(i, accounts[i]);

            }
            MessageBox.Show("Successfully updated");
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void MyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
