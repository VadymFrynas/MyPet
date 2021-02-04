using InterfaceModels;
using InterfaceService;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Wallet
{
    /// <summary>
    /// Логика взаимодействия для ShowAllAccount.xaml
    /// </summary>
    public partial class ShowAllAccount : Window
    {
        AccountServiceForInterface ForAccount;
        int index;
        public ShowAllAccount(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            List<InterfaceAccount> MyList = new List<InterfaceAccount>(ForAccount.Accounts);
            list.ItemsSource = MyList;
            list.DisplayMemberPath = "DisplayOwnerAndNumber";

        }



        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ForAccount.InfoAboutAcc(index));
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = list.SelectedIndex;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }
    }
}
