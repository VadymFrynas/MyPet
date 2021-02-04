using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;


namespace Wallet
{
    public partial class GetStatisticByPeriod : Window
    {
        AccountServiceForInterface ForAccount;
        TextBlock selectedItem;
        public GetStatisticByPeriod(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            PickerStart.SelectedDate = DateTime.Today;
            PickerEnd.SelectedDate = DateTime.Today;
        }

        private void PickerStart_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PickerStart.Background = Brushes.DarkSeaGreen;
        }

        private void PickerEnd_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PickerEnd.Background = Brushes.DarkSeaGreen;
        }

        private void GetStats_Click(object sender, RoutedEventArgs e)
        {
            if (PickerStart.SelectedDate.Value.Date != new DateTime(2020, 01, 01) && PickerEnd.SelectedDate.Value.Date > PickerStart.SelectedDate.Value.Date && selectedItem != null)
            {
                if (selectedItem.Text == "Income")
                {
                    MessageBox.Show(ForAccount.GetStatisticIncExpByPeriod(PickerStart.SelectedDate.Value.Date, PickerEnd.SelectedDate.Value.Date, "Income"));
                }
                else if (selectedItem.Text == "Expence")
                {
                    MessageBox.Show(ForAccount.GetStatisticIncExpByPeriod(PickerStart.SelectedDate.Value.Date, PickerEnd.SelectedDate.Value.Date, "Expence"));
                }
                else
                {
                    MessageBox.Show(ForAccount.GetStatisticIncExpByPeriod(PickerStart.SelectedDate.Value.Date, PickerEnd.SelectedDate.Value.Date, "Income")
                        + ForAccount.GetStatisticIncExpByPeriod(PickerStart.SelectedDate.Value.Date, PickerEnd.SelectedDate.Value.Date, "Expence"));
                }
            }
            else
            {
                if (PickerStart.SelectedDate.Value.Date == new DateTime(2020, 01, 01))
                {
                    PickerStart.Background = Brushes.Red;
                }
                if (PickerEnd.SelectedDate.Value.Date == new DateTime(2020, 01, 01))
                {
                    PickerEnd.Background = Brushes.Red;
                }
                if (PickerEnd.SelectedDate.Value.Date < PickerStart.SelectedDate.Value.Date)
                {
                    PickerEnd.Background = Brushes.Red;
                }
                if (selectedItem == null)
                {
                    IncExp.Background = Brushes.Red;
                }
                MessageBox.Show("Choose correctly");
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
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
