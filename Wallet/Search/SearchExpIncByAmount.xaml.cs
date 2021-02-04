using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;
namespace Wallet

{
  
    public partial class SearchExpIncByAmount : Window
    {
        AccountServiceForInterface forAccount;
        TextBlock selectedItem;
        public SearchExpIncByAmount(AccountServiceForInterface forAccount)
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


        private void Search_Click(object sender, RoutedEventArgs e)
        {



            if (Sum.Text != "" && double.Parse(Sum.Text) != 0 && selectedItem != null)
            {
                if (selectedItem.Text == "Income")
                {
                    MessageBox.Show(forAccount.SearchIncomeBySum(double.Parse(Sum.Text)));
                }
                else if (selectedItem.Text == "Expence")
                {
                    MessageBox.Show(forAccount.SearchOutcomeBySum(double.Parse(Sum.Text)));
                }
                else
                {
                    MessageBox.Show(forAccount.SearchIncomeBySum(double.Parse(Sum.Text)) + forAccount.SearchOutcomeBySum(double.Parse(Sum.Text)));
                }
            }
            else
            {
                if (Sum.Text == "")
                {
                    Sum.Background = Brushes.Red;
                }
                else if (double.Parse(Sum.Text) == 0)
                {
                    Sum.Background = Brushes.Red;
                }
                if (selectedItem == null)
                {
                    IncExp.Background = Brushes.Red;
                    {
                        MessageBox.Show("Write correctly");
                    }
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

        private void Sum_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Sum.Background = Brushes.DarkSeaGreen;
        }
    }
}
