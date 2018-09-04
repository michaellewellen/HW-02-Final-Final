using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Monthly.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double interest;
            double principal;
            double term;
            double down;
            Double.TryParse(Principal.Text, out principal);
            Double.TryParse(Interest.Text, out interest);
            interest /= 1200;

            Double.TryParse(Term.Text, out term);
            term *= 12;
            Double.TryParse(Down.Text, out down);
            double temp = (principal - down);
            double expo = Math.Pow((1 + interest), term);
            double d = (expo - 1) / (interest * expo);
            double amount = temp / d;
            amount = Math.Round(amount, 2);
            string value = amount.ToString();
            value = "$" + value;
            Monthly.Text = (value);
        }
    }
}
