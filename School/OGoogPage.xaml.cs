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
    /// Interaction logic for OGoogPage.xaml
    /// </summary>
    public partial class OGoogPage : Page
    {
        public OGoogPage()
        {
            InitializeComponent();
        }

        private void OpenGooglePage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome", @"www.google.com");
            }
            catch
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application", @"www.google.com");
            }
        }
    }
}
