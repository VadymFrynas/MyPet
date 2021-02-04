using InterfaceModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using InterfaceService;


namespace Wallet
{
    /// <summary>
    /// Логика взаимодействия для ShowCategoriesList.xaml
    /// </summary>
    public partial class ShowCategoriesList : Window
    {
        AccountServiceForInterface ForAccount;
        int index;
        public ShowCategoriesList(AccountServiceForInterface ForAccount)
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
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ForAccount.ShowAllCategories(index));
        }
    }
}
