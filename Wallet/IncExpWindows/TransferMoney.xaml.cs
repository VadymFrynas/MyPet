using InterfaceModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{
   
    public partial class TransferMoney : Window
    {
        AccountServiceForInterface ForAccount;
        public TransferMoney(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            List<InterfaceAccount> MyList = new List<InterfaceAccount>(ForAccount.Accounts);
            list.ItemsSource = MyList;
            list.DisplayMemberPath = "DisplayOwnerAndNumber";
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            int FirstIndex = 0;
            int SecondIndex = 0;
            bool CheckFirst = true;
            bool CheckSecond = true;
            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                if (ForAccount.Accounts[i].OwnerName == FirstAcc.Text)
                {
                    CheckFirst = false;
                    FirstIndex = i;
                }
                if (ForAccount.Accounts[i].OwnerName == SecondAcc.Text)
                {
                    CheckSecond = false;
                    SecondIndex = i;
                }
            }
            if (!CheckFirst && !CheckSecond && Sum.Text != "" && double.Parse(Sum.Text) != 0)
            {
                string str = ForAccount.TransferFromAccToAcc(FirstIndex, SecondIndex, double.Parse(Sum.Text));
                MessageBox.Show(str);
            }
            else
            {
                if (CheckFirst)
                {
                    FirstAcc.Background = Brushes.Red;
                }
                else if (CheckSecond)
                {
                    SecondAcc.Background = Brushes.Red;
                }
                else
                {
                    Sum.Background = Brushes.Red;
                }
            }
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = list.SelectedIndex;
            MessageBox.Show("Total sum on this account - " + ForAccount.Accounts[index].TotalMoney.ToString() + " uan.");
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void SecondAcc_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SecondAcc.Background = Brushes.DarkSeaGreen;
        }

        private void FirstAcc_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FirstAcc.Background = Brushes.DarkSeaGreen;
        }

        private void Sum_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FirstAcc.Background = Brushes.DarkSeaGreen;
        }
    }
}
