using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{

    public partial class SearchByCategory : Window
    {
        AccountServiceForInterface forAccount;
        public SearchByCategory(AccountServiceForInterface forAccount)
        {
            this.forAccount = forAccount;
            InitializeComponent();

        }




        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(forAccount);
            main.Show();
            Hide();
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryName.Background = Brushes.DarkSeaGreen;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (CategoryName.Text.Length > 1)
            {
                MessageBox.Show(forAccount.SearchCategory(CategoryName.Text));
            }
            else
            {
                CategoryName.Background = Brushes.Red;
            }
        }
    }
}
