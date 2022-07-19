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

namespace SDD_Student
{
    /// <summary>
    /// Interaction logic for CGoogPage.xaml
    /// </summary>
    public partial class CGoogPage : Page
    {
        public static CGoogPage ggg;
        public CGoogPage()
        {
            InitializeComponent();
            ggg = this;
        }

        private void OpenCustomGoogleWindow_Click(object sender, RoutedEventArgs e)
        {
            CustomGoogleWindow cg = new CustomGoogleWindow();
            cg.Show();
            HomePage.homePage.WindowState = WindowState.Minimized;
            OpenCustomGoogleWindow.Visibility = Visibility.Hidden;
            CGLabel.Text = "Check on your minimize taskbar";

        }
    }
}
