using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using InterfaceService;

namespace Wallet
{
    public partial class Confirm : Window
    {
        AccountServiceForInterface ForAccount;
        public bool ConfirmCheck = false;
        int indexAcc;
        public Confirm(AccountServiceForInterface ForAccount, int indexAcc)
        {
            this.ForAccount = ForAccount;
            this.indexAcc = indexAcc;
            InitializeComponent();
        }

        private void Pas_box_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Pas_box.Background = Brushes.DarkSeaGreen;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

            string str = Pas_box.Password;
            if (Pas_box.Password == ForAccount.Accounts[indexAcc].AccountPassword)
            {
                this.DialogResult = true;
                Hide();
            }
            else
            {
                MessageBox.Show("Uncorrect password");

            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
