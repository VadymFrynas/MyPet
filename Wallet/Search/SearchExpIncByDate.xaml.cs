using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{
    public partial class SearchExpIncByDate : Window
    {
        AccountServiceForInterface forAccount;
        TextBlock selectedItem;
        public SearchExpIncByDate(AccountServiceForInterface forAccount)
        {
            this.forAccount = forAccount;
            InitializeComponent();
            Picker.SelectedDate = DateTime.Today;
        }

        private void IncExp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (TextBlock)IncExp.SelectedItem;
        }

        private void IncExp_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IncExp.Background = Brushes.DarkSeaGreen;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (Picker.SelectedDate.Value.Date != new DateTime(2020, 01, 01) && selectedItem != null)
            {
                if (selectedItem.Text == "Income")
                {
                    MessageBox.Show(forAccount.SearchIncomeByDate(Picker.SelectedDate.Value.Date));
                }
                else if (selectedItem.Text == "Expence")
                {
                    MessageBox.Show(forAccount.SearchOutcomeByDate(Picker.SelectedDate.Value.Date));
                }
                else
                {
                    MessageBox.Show(forAccount.SearchIncomeByDate(Picker.SelectedDate.Value.Date) + forAccount.SearchOutcomeByDate(Picker.SelectedDate.Value.Date));
                }
            }
            else
            {
                if (Picker.SelectedDate.Value.Date == new DateTime(2020, 01, 01))
                {
                    Picker.Background = Brushes.Red;
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
            MainWindow main = new MainWindow(forAccount);
            main.Show();
            Hide();
        }

        private void Picker_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Picker.Background = Brushes.DarkSeaGreen;
        }
    }
}
