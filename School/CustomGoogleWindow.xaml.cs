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
using System.Windows.Shapes;

namespace SDD_Student
{
    /// <summary>
    /// Interaction logic for CustomGoogleWindow.xaml
    /// </summary>
    public partial class CustomGoogleWindow : Window
    {

        public static CustomGoogleWindow cusGoogle;
        public CustomGoogleWindow()
        {
            InitializeComponent();
            cusGoogle = this;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            CGoogPage.ggg.CGLabel.Text = "Use this for search Information";
            CGoogPage.ggg.OpenCustomGoogleWindow.Visibility = Visibility.Visible;
            HomePage.homePage.WindowState = WindowState.Normal;
        }

        // this will open my custon google page to edgebrowser.
        private void OpenGoogle_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", @"https://cse.google.com/cse?cx=6cf6531ec4b3514c5");
        }
    }
}
