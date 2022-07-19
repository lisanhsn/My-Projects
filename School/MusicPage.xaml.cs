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
    /// Interaction logic for MusicPage.xaml
    /// </summary>
    public partial class MusicPage : Page
    {
        public static MusicPage musicpage;
        public MusicPage()
        {
            InitializeComponent();
            musicpage = this;
        }

        private void MusicAppWindow_Click(object sender, RoutedEventArgs e)
        {
            MusicAppWindow msApp = new MusicAppWindow();
            msApp.Show();

            MainWindow.LoginPage.Visibility = Visibility.Collapsed;
        }
    }
}
