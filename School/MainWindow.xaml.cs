using System;
using System.IO;
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

namespace SDD_Student
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static MainWindow LoginPage;
        public string userNameLogin = "";
        public string userClassLogin = "";
        public MainWindow()
        {
            InitializeComponent();
            NameBox.Focus();
            LoginPage = this;
        }
        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ClassBox.Focus();
            }
        }
        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {

            HomePage hp = new HomePage();
            if (ClassBox.Text == string.Empty && NameBox.Text == string.Empty)
            {
                MessageBox.Show("Please the Field", "User", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                //userNameLogin = NameBox.Text;
                //userClassLogin = ClassBox.Text;
                HomePage.homePage.NamePlace.Content = NameBox.Text;
                HomePage.homePage.ClassPlace.Content = ClassBox.Text;
                HomePage.homePage.AppBarName.Content = NameBox.Text;

                // Set for welcome page

                // move to next windo
                hp.Show();
                this.Close();

            }
        }
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
