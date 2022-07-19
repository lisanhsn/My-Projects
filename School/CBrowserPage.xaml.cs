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
    /// Interaction logic for CBrowserPage.xaml
    /// </summary>
    public partial class CBrowserPage : Page
    {
        public static CBrowserPage GamePage = new CBrowserPage();
        public CBrowserPage()
        {
            InitializeComponent();
            GamePage = this;
        }

        private void OpenDiceGame_Click(object sender, RoutedEventArgs e)
        {
            Apps.Game.SDDICEROLL gm = new Apps.Game.SDDICEROLL();
            gm.Show();
            HomePage.homePage.WindowState = WindowState.Minimized;
            GameText.Text = "See your game in Taskbar";
            OpenDiceGame.Visibility = Visibility.Hidden;
        }
    }
}
