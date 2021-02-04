using InterfaceModels;
using InterfaceService;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Wallet
{
    public partial class AccountDeleting : Window
    {
        AccountServiceForInterface ForAccount;
        static int index = default;
        public AccountDeleting(AccountServiceForInterface ForAccount)
        {
            InitializeComponent();
            this.ForAccount = ForAccount;

            List<InterfaceAccount> MyList = new List<InterfaceAccount>(ForAccount.Accounts);
            list.ItemsSource = MyList;
            list.DisplayMemberPath = "DisplayOwnerAndNumber";


        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = list.SelectedIndex + 1;
            list.ToolTip = list.SelectedItem.ToString();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (index == default)
            {
                MessageBox.Show("You should to choose an account");
            }
            else
            {
                ForAccount.DeleteAccount(index);
                MessageBox.Show("Account successfully deleted");
                MainWindow main = new MainWindow(ForAccount);
                main.Show();
                Hide();
            }
        }

        private void list_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            list.ToolTip = list.SelectedItem.ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }
    }
}
