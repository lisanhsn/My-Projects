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
    /// Interaction logic for ResultBoxWin.xaml
    /// </summary>
    public partial class ResultBoxWin : Window
    { 
        public static ResultBoxWin winOrLose = new ResultBoxWin();
        public ResultBoxWin()
        {
            InitializeComponent();
            winOrLose = this;
        }

        public static string p1Img = "/Apps/Game/Assets/ResultAssets/Player1.png";
        public static string p2Img = "/Apps/Game/Assets/ResultAssets/Player2.png";

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Logging llg = new Logging();
            llg.Show();
            FocusManager.SetIsFocusScope(llg, true);
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(SDDICEROLL.game.PlayerOneScore.Content) > Convert.ToInt32(SDDICEROLL.game.PlayerOneScore.Content))
            {
                ResultScore.Content = SDDICEROLL.game.PlayerOneScore.Content.ToString();
                winerImage.Source = new BitmapImage(new Uri(p1Img, UriKind.Relative) );
                winerName.Content = SDDICEROLL.game.P1Name.Content;
            }

            else
            {
                ResultScore.Content = SDDICEROLL.game.PlayerTwoScore.Content.ToString();
                winerImage.Source = new BitmapImage(new Uri(p2Img, UriKind.Relative));
                winerName.Content = SDDICEROLL.game.P2Name.Content;
            }
        }
    }
}
