using ComputerShop.Services;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        MainWindow _mainWindow;
        IDatabase _database = new Users();
        public Page3(MainWindow mainWindow)
        {
            InitializeComponent();
            usersDataGrid.ItemsSource = _database.GetAllData();
            _mainWindow = mainWindow;
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            if(usersDataGrid.SelectedItem is DataRowView item)
            {
                MessageBox.Show(_database.DeleteUser(item["Id"]).ToString());
                usersDataGrid.ItemsSource = _database.GetAllData();
            }
        }

        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (usersDataGrid.SelectedItem is DataRowView item)
            {
                var user = new
                {
                    UserName = item["UserName"],
                    FullName = item["FullName"],
                    Email = item["Email"],
                    Time = item["RegTime"],
                    Id = item["Id"]
                };
                MessageBox.Show(_database.UpdateUser(user).ToString());
                usersDataGrid.ItemsSource = _database.GetAllData();
            }
        }
    }
}
