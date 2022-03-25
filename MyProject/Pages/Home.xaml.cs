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

namespace MyProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if ((txtSurname.Text=="Admin") && (txtName.Text=="Admin") && (PasswordBox.Password=="admin"))
            {
                AdminStatus();
                //MongoDataBase.AddAdminToDB("Admin", "Admin", "Admin", "admin");
            }
            else
            {
                MessageBox.Show("Такого пользователя нет в базе данных!");
            }
        }
        private void txtSurname_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSurname.Clear();
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
        }
        public void AdminStatus()
        {
            rbAdmin.IsChecked = true;
            rbAdmin.IsEnabled = true;
            MessageBox.Show("У вас есть права администратора!");
        }

        private void rbAdmin_Loaded(object sender, RoutedEventArgs e)
        {
            rbAdmin.IsEnabled = false;
            rbWorker.IsEnabled = false;
        }
    }
}
