using InterfaceModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using InterfaceService;

namespace Wallet
{
  
    public partial class ShowSum : Window
    {
        AccountServiceForInterface ForAccount;
        int index;
        public ShowSum(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            List<InterfaceAccount> MyList = new List<InterfaceAccount>(ForAccount.Accounts);

            list.ItemsSource = MyList;
            list.DisplayMemberPath = "DisplayOwnerAndNumber";


        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = list.SelectedIndex;
            MessageBox.Show("Total sum on this account - " + ForAccount.Accounts[index].TotalMoney.ToString() + " uan.");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void list_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }


    }
}
