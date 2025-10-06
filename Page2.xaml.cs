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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        MainWindow _mainWindow;
        IDatabase _database = new Users();
        public Page2(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_database.AddRecord(usernameTextBox.Text, passwordTextBox.Password, emailTextBox.Text, fullnameTextBox.Text).ToString());
            _mainWindow.MainFrame.Navigate(new Page1(_mainWindow));
        }
    }
}
