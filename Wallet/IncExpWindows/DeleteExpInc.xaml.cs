using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;


namespace Wallet
{
    public partial class DeleteExpInc : Window
    {
        AccountServiceForInterface ForAccount;
        static TreeViewItem item;
        static TreeViewItem item2;
        TextBlock selectedItem;
        public DeleteExpInc(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
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
                        item2 = new TreeViewItem();
                        item2.Header = ForAccount.Accounts[i].Categories[j].CategoryName;
                        if (ForAccount.Accounts[i].Categories[j].Incomes != null)
                        {
                            for (int k = 0; k < ForAccount.Accounts[i].Categories[j].Incomes.Length; k++)
                            {
                                item2.Items.Add(ForAccount.Accounts[i].Categories[j].Incomes[k].ToString());
                            }
                        }
                        if (ForAccount.Accounts[i].Categories[j].Outcomes != null)
                        {
                            for (int k = 0; k < ForAccount.Accounts[i].Categories[j].Outcomes.Length; k++)
                            {
                                item2.Items.Add(ForAccount.Accounts[i].Categories[j].Outcomes[k].ToString());
                            }
                        }
                        item.Items.Add(item2);

                    }

                }
                tree.Items.Add(item);
            }
        }
        private void ExpIncName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ExpIncName.Background = Brushes.DarkSeaGreen;
        }

        private void CategoryName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryName.Background = Brushes.DarkSeaGreen;
        }

        private void AccountName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AccountName.Background = Brushes.DarkSeaGreen;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            bool checkAccount = true;
            bool checkCategory = true;
            bool checkIncOut = true;
            int indexAcc = default;
            int indexCategory = default;
            int indexIncOut = default;
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
                                if (!checkCategory)
                                {
                                    if (selectedItem.Text == "Income")
                                    {
                                        if (ForAccount.Accounts[indexAcc].Categories[j].Incomes != null)
                                        {
                                            for (int k = 0; k < ForAccount.Accounts[indexAcc].Categories[j].Incomes.Length; k++)
                                            {
                                                if (ForAccount.Accounts[indexAcc].Categories[j].Incomes[k].IncomeName == ExpIncName.Text)
                                                {
                                                    indexIncOut = k;
                                                    checkIncOut = false;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    if (selectedItem.Text == "Expence")
                                    {
                                        if (ForAccount.Accounts[indexAcc].Categories[j].Outcomes != null)
                                        {
                                            for (int k = 0; k < ForAccount.Accounts[indexAcc].Categories[j].Outcomes.Length; k++)
                                            {
                                                if (ForAccount.Accounts[indexAcc].Categories[j].Outcomes[k].OutcomeName == ExpIncName.Text)
                                                {
                                                    indexIncOut = k;
                                                    checkIncOut = false;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!checkCategory && !checkAccount && !checkIncOut && selectedItem != null)
            {
                Confirm confirm = new Confirm(ForAccount, indexAcc);
                if (confirm.ShowDialog() == true)
                {
                    if (selectedItem.Text == "Income")
                    {
                        ForAccount.DeleteIncome(indexAcc, indexCategory, indexIncOut + 1);
                    }
                    else if (selectedItem.Text == "Expence")
                    {
                        ForAccount.DeleteOutcome(indexAcc, indexCategory, indexIncOut + 1);
                    }
                    MessageBox.Show("Successfully deleted");
                }
            }
            else if (checkAccount || checkAccount || checkIncOut || selectedItem == null)
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
                if (checkIncOut)
                {
                    ExpIncName.Background = Brushes.Red;
                }
                if (selectedItem == null)
                {
                    IncExp.Background = Brushes.Red;
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
    }
}
