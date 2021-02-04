using InterfaceModels;
using InterfaceService;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace Wallet
{
    public partial class CreateAccount : Window
    {
        AccountServiceForInterface ForAccount;
        public CreateAccount(AccountServiceForInterface ForAccount)
        {
            this.ForAccount = ForAccount;
            InitializeComponent();
        }

        private void CreateAccount1_Click(object sender, RoutedEventArgs e)
        {
            string Owner = FirstName.Text + " " + LastName.Text;
            string Pass = Pas_box.Password;
            string Pass_confirm = Pas_confirm.Password;
            string CardNumb = CardNumber.Text;
            double Sum;
            if (TotalSum.Text == "")
            {
                Sum = 0;
            }
            else 
            {
            Sum= double.Parse(TotalSum.Text);

            }
            Regex ForCardNumb = new Regex(@"\d+");//Допілити регекс
            Regex regexName = new Regex(@"[A-Z]{1}[a-z]+");
            if (!regexName.IsMatch(LastName.Text))
            {
                LastName.ToolTip = "Write Last name in the correct form. Ex: Frynas";
                LastName.Background = Brushes.Red;

            }
            if (!regexName.IsMatch(FirstName.Text))
            {
                FirstName.ToolTip = "Wrie First name in the correct form. Ex: Vadym";
                FirstName.Background = Brushes.Red;
            }
            if (Pass != Pass_confirm)
            {
                Pas_confirm.ToolTip = "Passwords do not match";
                Pas_confirm.Background = Brushes.Red;
            }
            if (!ForCardNumb.IsMatch(CardNumb))
            {
                CardNumber.ToolTip = "Card number must consist from 16 number";
                CardNumber.Background = Brushes.Red;
            }
            if (regexName.IsMatch(LastName.Text) && regexName.IsMatch(FirstName.Text) && Pass == Pass_confirm && ForCardNumb.IsMatch(CardNumb))
            {

                ForAccount.AddAccount(new InterfaceAccount(Owner, CardNumb, Pass, Sum));
                MessageBox.Show("Account successfully added");

                MainWindow main = new MainWindow(ForAccount);
                main.Show();
                Hide();

            }

        }
        public async void BackToPrevious()
        {
            MessageBox.Show("Account successfully added");
            await Task.Delay(200);
            MainWindow main = new MainWindow();
            main.Show();
            Hide();

        }
        private void LastName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            LastName.Background = Brushes.DarkSeaGreen;
        }

        private void FirstName_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FirstName.Background = Brushes.DarkSeaGreen;
        }

        private void CardNumber_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CardNumber.Background = Brushes.DarkSeaGreen;
        }

        private void TotalSum_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TotalSum.Background = Brushes.DarkSeaGreen;
        }

        private void Pas_box_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Pas_box.Background = Brushes.DarkSeaGreen;
        }

        private void Pas_comfirm_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Pas_confirm.Background = Brushes.DarkSeaGreen;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ForAccount);
            main.Show();
            Hide();

        }
    }
}
