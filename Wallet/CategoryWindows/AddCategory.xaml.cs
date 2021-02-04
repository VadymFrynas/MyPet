using InterfaceModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{

    public partial class AddCategory : Window
    {
        AccountServiceForInterface ForAccount;
        int index = 0;
        bool check;
        public AddCategory(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            List<InterfaceAccount> MyList = new List<InterfaceAccount>(ForAccount.Accounts);
            list.ItemsSource = MyList;
            list.DisplayMemberPath = "DisplayOwnerAndNumber";

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (!check)
            {
                if (CategoryName.Text.Length == 0)
                {
                    CategoryName.ToolTip = "Write something as name";
                    CategoryName.Background = Brushes.Red;

                }
                else
                {
                    ForAccount.AddCategory(index, new InterfaceCategory(CategoryName.Text));
                    MessageBox.Show("Successfully added");
                }

            }
            else
            {
                MessageBox.Show("You should to choose one of account");
            }
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = list.SelectedIndex;
            check = false;
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryName.Background = Brushes.DarkSeaGreen;

        }
    }
}
