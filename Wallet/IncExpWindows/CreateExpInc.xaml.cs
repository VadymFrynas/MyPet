using InterfaceModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;


namespace Wallet
{
    public partial class CreateExpInc : Window
    {
        AccountServiceForInterface ForAccount;
        static TreeViewItem item;
        TextBlock selectedItem;
        public CreateExpInc(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
            Picker.SelectedDate = DateTime.Today;
            Show(treeView, ForAccount);
        }
        static public void Show(TreeView tree, AccountServiceForInterface ForAccount)
        {
            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                item = new TreeViewItem();
                item.Header = ForAccount.Accounts[i].DisplayOwnerAndNumber;
                if (ForAccount.Accounts[i].Categories == null)
                {
                    item.Items.Add("There is no any categories in this account");
                }
                else
                {

                    for (int j = 0; j < ForAccount.Accounts[i].Categories.Length; j++)
                    {
                        item.Items.Add(ForAccount.Accounts[i].Categories[j].CategoryName);
                    }

                }
                tree.Items.Add(item);
            }
        }
        private void IncExp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = (TextBlock)IncExp.SelectedItem;

        }



        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            bool checkAccount = true;
            bool checkCategory = true;
            int indexAcc = default;
            int indexCategory = default;
            for (int i = 0; i < ForAccount.Accounts.Length; i++)
            {
                if (ForAccount.Accounts[i].OwnerName == AccountName.Text)
                {
                    checkAccount = false;
                    indexAcc = i;
                }
                if (!checkAccount)
                {
                    if (ForAccount.Accounts[indexAcc].Categories != null)
                    {
                        for (int j = 0; j < ForAccount.Accounts[indexAcc].Categories.Length; j++)
                        {
                            if (ForAccount.Accounts[indexAcc].Categories[j].CategoryName == CategoryName.Text)
                            {
                                indexCategory = j;
                                checkCategory = false;
                                break;
                            }
                        }
                    }
                }
            }
            if (!checkCategory && !checkAccount && IncExpName.Text.Length > 1 && Sum.Text != "" && selectedItem != null && Picker.SelectedDate.Value.Date != new DateTime(2020, 01, 01))
            {
                Confirm confirm = new Confirm(ForAccount, indexAcc);

                if (confirm.ShowDialog() == true)
                {
                    if (selectedItem.Text == "Income")
                    {
                        ForAccount.AddIncome(indexAcc, indexCategory, new InterfaceIncome(IncExpName.Text, double.Parse(Sum.Text), Picker.SelectedDate.Value.Date));
                    }
                    else if (selectedItem.Text == "Expence")
                    {
                        ForAccount.AddOutcome(indexAcc, indexCategory, new InterfaceOutcome(IncExpName.Text, double.Parse(Sum.Text), Picker.SelectedDate.Value.Date));

                    }
                    MessageBox.Show("Successfully added");
                }
            }
            else if (checkAccount || checkAccount || IncExpName.Text.Length < 1 || Sum.Text == null || selectedItem == null || Picker.SelectedDate.Value.Date == default)
            {
                MessageBox.Show("Write correctly");
                if (checkAccount)
                {
                    AccountName.Background = Brushes.Red;
                }
                if (checkCategory)
                {
                    CategoryName.Background = Brushes.Red;
                }
                if (IncExpName.Text.Length < 1)
                {
                    IncExpName.Background = Brushes.Red;
                }
                if (selectedItem == null)
                {
                    IncExp.Background = Brushes.Red;
                }
                if (Sum.Text == "")
                {
                    Sum.Background = Brushes.Red;
                }
                if (Picker.SelectedDate.Value.Date == new DateTime(2020, 01, 01))
                {
                    Picker.Background = Brushes.Red;
                }
            }

        }

        private void AccountName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AccountName.Background = Brushes.DarkSeaGreen;
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryName.Background = Brushes.DarkSeaGreen;
        }

        private void IncExpName_PreviewMouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            IncExpName.Background = Brushes.DarkSeaGreen;

        }

        private void Sum_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Sum.Background = Brushes.DarkSeaGreen;
        }

        private void IncExp_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IncExp.Background = Brushes.DarkSeaGreen;
        }

        private void Picker_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Picker.Background = Brushes.DarkSeaGreen;
        }
    }
}
