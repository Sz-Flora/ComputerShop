using ComputerShop.Services;
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

namespace ComputerShop
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        MainWindow _mainWindow;
        IDatabase _database = new Users();
        public Page1(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (_database.GetData(usernameTextBox.Text, passwordTextBox.Password))
            {
                _mainWindow.MainFrame.Navigate(new Page3(_mainWindow));
            }
            else
                MessageBox.Show("Még nem regisztrált tag.");
        }

        private void regLink_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainFrame.Navigate(new Page2(_mainWindow));
        }
    }
}
