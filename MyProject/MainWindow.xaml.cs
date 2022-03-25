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
using MyProject.Pages;

namespace MyProject
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

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Home();
        }

        private void btnProjectregistry_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ProjectRegistry();
        }

        private void btnOperationCard_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new OperatingCard();
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Staff();
        }

        private void btnComponents_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Components();
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new TimeSheet();
        }

        private void MyFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Home();
            //MongoDataBase.AddAdminToDB("Admin", "Admin", "Admin", "admin");
        }
    }
}
