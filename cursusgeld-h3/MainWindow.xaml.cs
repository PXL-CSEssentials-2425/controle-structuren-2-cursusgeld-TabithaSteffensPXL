using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cursusgeld_h3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testNumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(yearTextBox.Text, out int year))
            {

                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    isLeapYearLabel.Content = "Is een schrikkeljaar";
                    isValidNumberLabel.Content = "Is Numeriek";
                }
                else if (year % 4 != 0 || year % 400 != 0)
                {
                    isLeapYearLabel.Content = "Is geen schrikkeljaar";
                    isValidNumberLabel.Content = "Is Numeriek";
                }
            }
            else
            {
                isLeapYearLabel.Content = "Is geen schrikkeljaar";
                isValidNumberLabel.Content = "Is niet numeriek!";
            }
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(yearTextBox.Text, out int year))
            {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    isLeapYearLabel.Content = "Is een schrikkeljaar";
                }
                else if (year % 4 != 0 || year % 400 != 0)
                {
                    isLeapYearLabel.Content = "Is geen schrikkeljaar";
                    isValidNumberLabel.Content = "Is Numeriek";
                }
            }

            int amountHours = int.Parse(lessonHoursTextBox.Text);
            if (isLeapYearLabel.Content == "Is een schrikkeljaar")
            {
                double registrationMoney = (double)(amountHours * 1.5 + 1.5);
                registrationMoneyTextBox.Text = registrationMoney.ToString();
            }
            else
            {
                double registrationMoney = (double)(amountHours * 1.5);
                registrationMoneyTextBox.Text = registrationMoney.ToString();
            }
            
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}