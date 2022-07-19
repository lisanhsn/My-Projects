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

namespace SDD_Student.Apps.Game
{
    /// <summary>
    /// Interaction logic for Logging.xaml
    /// </summary>
    public partial class Logging : Window
    {
        public static Logging lg = new Logging();
        public Logging()
        {
            InitializeComponent();
            lg = this;
        }

        private void GetInGame_Click(object sender, RoutedEventArgs e)
        {
            SDDICEROLL.game.P1Name.Content = NameOne.Text;
            SDDICEROLL.game.P1Name.Foreground = Brushes.Black;
            SDDICEROLL.game.P2Name.Content = NameTwo.Text;
            SDDICEROLL.game.P1Name.Foreground = Brushes.Black;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NameOne.Focus();
        }
    }
}
