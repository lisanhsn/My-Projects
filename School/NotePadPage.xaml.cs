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
    /// Interaction logic for NotePadPage.xaml
    /// </summary>
    public partial class NotePadPage : Page
    {
        public static NotePadPage npage;
        public NotePadPage()
        {
            InitializeComponent();
            npage = this;
        }

        private void OpenNoteWindow_Click(object sender, RoutedEventArgs e)
        {
            Apps.NotePadApp npp = new Apps.NotePadApp();
            npp.Show();
            HomePage.homePage.WindowState = WindowState.Minimized;
        }
    }
}
