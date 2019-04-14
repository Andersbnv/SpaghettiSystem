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

namespace StregSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User Kurt = new User(0001, "Kurt", "Nørmark", "Kurt.noer@gmail.com", 420.69);

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            MessageBox.Show(Kurt.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Balance: " + Kurt.Balance.ToString() +  "kr");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double newBalance;
            double desiredAmount = 10;

            newBalance = Kurt.Balance + desiredAmount;            
            MessageBox.Show("Ny balance: " + newBalance.ToString() + "kr");          
        }
    }
}
