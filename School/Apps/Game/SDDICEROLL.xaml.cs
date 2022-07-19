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
    /// Interaction logic for SDDICEROLL.xaml
    /// </summary>
    public partial class SDDICEROLL : Window
    {
        public static SDDICEROLL game = new SDDICEROLL();

        Random rnd = new Random();
        // some variable;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public SDDICEROLL()
        {
            InitializeComponent();
            game = this;
            // keeping the score zero at begin of program
            PlayerOneScore.Content = playerOneScore.ToString();
            PlayerTwoScore.Content = playerTwoScore.ToString();
            check();

        }
        // all images
        public static string img1=  "/Apps/Game/Assets/DiceFace/D1.PNG";
        public static string img2 = "/Apps/Game/Assets/DiceFace/D2.PNG";
        public static string img3 = "/Apps/Game/Assets/DiceFace/D3.PNG";
        public static string img4 = "/Apps/Game/Assets/DiceFace/D4.PNG";
        public static string img5 = "/Apps/Game/Assets/DiceFace/D5.PNG";
        public static string img6 = "/Apps/Game/Assets/DiceFace/D6.PNG";
        public static string img7 = "/Apps/Game/Assets/DiceFace/DC1.PNG";
        public static string img8 = "/Apps/Game/Assets/DiceFace/DC2.PNG";
        public static string img9 = "/Apps/Game/Assets/DiceFace/DC3.PNG";
        public static string img10 = "/Apps/Game/Assets/DiceFace/DC4.PNG";
        public static string img11 = "/Apps/Game/Assets/DiceFace/DC5.PNG";
        public static string img12 = "/Apps/Game/Assets/DiceFace/DC6.PNG";
        public static string wait = "/Apps/Game/Assets/DiceFace/wait.png";
        public static string deaultImg = "/Apps/Game/Assets/DefaultDice.png";
        public static string resultimg = "/Apps/Game/Assets/DiceFace/Result.png";
        public static string soundD = "/Apps/Game/Assets/Dice.mp3";


        // Some data and Variables

        private async void  RollOne_Click(object sender, RoutedEventArgs e)
        {
            // a looping switch funtion to have a random animation of dice faces.
            int dfaceNumber = 1;
            for (int j = 1; j <= 13; j++)
            {

                dfaceNumber = rnd.Next(1, 12);
                //Counting.Content = dfaceNumber.ToString();
                await Task.Delay(25);
                // changing an image 13 time within 25 miliseconds.
                switch (dfaceNumber)
                {
                    case 1:
                        DiceBox.Source = new BitmapImage(new Uri(img1, UriKind.Relative));
                        Counting.Content = "0";
                        break;
                    case 2:
                        DiceBox.Source = new BitmapImage(new Uri(img2, UriKind.Relative));
                        Counting.Content = "00";
                        break;
                    case 3:
                        DiceBox.Source = new BitmapImage(new Uri(img3, UriKind.Relative));
                        Counting.Content = "000";
                        break;
                    case 4:
                        DiceBox.Source = new BitmapImage(new Uri(img4, UriKind.Relative));
                        Counting.Content = "0000";
                        break;
                    case 5:
                        DiceBox.Source = new BitmapImage(new Uri(img5, UriKind.Relative));
                        Counting.Content = "00000";
                        break;
                    case 6:
                        DiceBox.Source = new BitmapImage(new Uri(img6, UriKind.Relative));
                        Counting.Content = "000000";
                        break;
                    case 7:
                        DiceBox.Source = new BitmapImage(new Uri(img7, UriKind.Relative));
                        Counting.Content = "0000000";
                        break;
                    case 8:
                        DiceBox.Source = new BitmapImage(new Uri(img8, UriKind.Relative));
                        Counting.Content = "00000000";
                        break;
                    case 9:
                        DiceBox.Source = new BitmapImage(new Uri(img9, UriKind.Relative));
                        Counting.Content = "000000000";
                        break;
                    case 10:
                        DiceBox.Source = new BitmapImage(new Uri(img10, UriKind.Relative));
                        Counting.Content = "0000000000";
                        break;
                    case 11:
                        DiceBox.Source = new BitmapImage(new Uri(img11, UriKind.Relative));
                        Counting.Content = "00000000000";
                        break;
                    case 12:
                        DiceBox.Source = new BitmapImage(new Uri(img12, UriKind.Relative));
                        Counting.Content = "000000000000";
                        break;
                }
            }
            DiceBox.Source = new BitmapImage(new Uri(wait, UriKind.Relative));
            await Task.Delay(200);

            // for making a random a choice;
            switch (dfaceNumber)
            {
                case 1:
                    playerOneScore += 1;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 2:
                    playerOneScore += 2;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 3:
                    playerOneScore += 3;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 4:
                    playerOneScore += 4;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 5:
                    playerOneScore += 5;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 6:
                    playerOneScore += 6;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 7:
                    playerOneScore += 1;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 8:
                    playerOneScore += 2;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;

                case 9:
                    playerOneScore += 3;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 10:
                    playerOneScore += 4;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 11:
                    playerOneScore += 5;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
                case 12:
                    playerOneScore += 6;
                    PlayerOneScore.Content = playerOneScore.ToString();
                    break;
            }
            DiceBox.Source = new BitmapImage(new Uri(deaultImg, UriKind.Relative));
            Counting.Content = "0";

            // reducing the turn
            PlayerOneTurn.Content = (Convert.ToInt32(PlayerOneTurn.Content) - 1).ToString();

            // Some trick to make the game for more playable for the user
            RollOne.Visibility = Visibility.Hidden;
            PlayerOneSwitch.Visibility = Visibility.Hidden;
            RollTwo.Visibility = Visibility.Visible;
            PlayerTwoSwitch.Visibility = Visibility.Visible;
            check();
        }

        private async void RollTwo_Click(object sender, RoutedEventArgs e)
        {

            // a looping switch funtion to have a random animation of dice faces.
            int dfaceNumber = 1;
            for (int j = 1; j <= 13; j++)
            {

                dfaceNumber = rnd.Next(1, 12);
                //Counting.Content = dfaceNumber.ToString();
                await Task.Delay(25);
                switch (dfaceNumber)
                {
                    case 1:
                        DiceBox.Source = new BitmapImage(new Uri(img1, UriKind.Relative));
                        Counting.Content = "0";
                        break;
                    case 2:
                        DiceBox.Source = new BitmapImage(new Uri(img2, UriKind.Relative));
                        Counting.Content = "00";
                        break;
                    case 3:
                        DiceBox.Source = new BitmapImage(new Uri(img3, UriKind.Relative));
                        Counting.Content = "000";
                        break;
                    case 4:
                        DiceBox.Source = new BitmapImage(new Uri(img4, UriKind.Relative));
                        Counting.Content = "0000";
                        break;
                    case 5:
                        DiceBox.Source = new BitmapImage(new Uri(img5, UriKind.Relative));
                        Counting.Content = "00000";
                        break;
                    case 6:
                        DiceBox.Source = new BitmapImage(new Uri(img6, UriKind.Relative));
                        Counting.Content = "000000";
                        break;
                    case 7:
                        DiceBox.Source = new BitmapImage(new Uri(img7, UriKind.Relative));
                        Counting.Content = "0000000";
                        break;
                    case 8:
                        DiceBox.Source = new BitmapImage(new Uri(img8, UriKind.Relative));
                        Counting.Content = "00000000";
                        break;
                    case 9:
                        DiceBox.Source = new BitmapImage(new Uri(img9, UriKind.Relative));
                        Counting.Content = "000000000";
                        break;
                    case 10:
                        DiceBox.Source = new BitmapImage(new Uri(img10, UriKind.Relative));
                        Counting.Content = "0000000000";
                        break;
                    case 11:
                        DiceBox.Source = new BitmapImage(new Uri(img11, UriKind.Relative));
                        Counting.Content = "00000000000";
                        break;
                    case 12:
                        DiceBox.Source = new BitmapImage(new Uri(img12, UriKind.Relative));
                        Counting.Content = "000000000000";
                        break;
                }
            }
            DiceBox.Source = new BitmapImage(new Uri(wait, UriKind.Relative));
            await Task.Delay(200);

            // for making a random a choice;
            switch (dfaceNumber)
            {
                case 1:
                    playerTwoScore += 1;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 2:
                    playerTwoScore += 2;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 3:
                    playerTwoScore += 3;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 4:
                    playerTwoScore += 4;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 5:
                    playerTwoScore += 5;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 6:
                    playerTwoScore += 6;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 7:
                    playerTwoScore += 1;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 8:
                    playerTwoScore += 2;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;

                case 9:
                    playerTwoScore += 3;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 10:
                    playerTwoScore += 4;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 11:
                    playerTwoScore += 5;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
                case 12:
                    playerTwoScore += 6;
                    PlayerTwoScore.Content = playerTwoScore.ToString();
                    break;
            }
            DiceBox.Source = new BitmapImage(new Uri(deaultImg, UriKind.Relative));
            Counting.Content = "0";

            // reducing the turn
            PlayerTwoTurn.Content = (Convert.ToInt32(PlayerTwoTurn.Content) - 1).ToString();

            // Some trick to make the game for more playable for the user
            RollOne.Visibility = Visibility.Visible;
            PlayerOneSwitch.Visibility = Visibility.Visible;
            RollTwo.Visibility = Visibility.Hidden;
            PlayerTwoSwitch.Visibility = Visibility.Hidden;
            check();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // openning the login window
            Logging llg = new Logging();
            llg.Show();
            FocusManager.SetIsFocusScope(llg, true);
            RollTwo.Visibility = Visibility.Hidden;
            PlayerTwoSwitch.Visibility = Visibility.Hidden;
            ResultWindow.Visibility = Visibility.Hidden;

        }


        // Checking the turn of each player.
        private void check()
        {
            // checking the turn;
            if (Convert.ToInt32(PlayerOneTurn.Content) == 0 && Convert.ToInt32(PlayerTwoTurn.Content) == 0)
            {
                DiceBox.Source = new BitmapImage(new Uri(resultimg, UriKind.Relative));
                RollTwo.Visibility = Visibility.Hidden;
                ResultWindow.Visibility = Visibility.Visible;
                PlayerTwoSwitch.Visibility = Visibility.Hidden;
                PlayerOneSwitch.Visibility = Visibility.Hidden;
                RollOne.Visibility = Visibility.Hidden;
            }
        }

        private void ResultWindow_Click(object sender, RoutedEventArgs e)
        {
            ResultBoxWin.winOrLose.Show();
            PlayerOneScore.Content = 0.ToString();
            PlayerTwoScore.Content = 0.ToString();
            playerOneScore = 0;
            playerTwoScore = 0; 
            PlayerOneSwitch.Visibility = Visibility.Visible;
            PlayerTwoSwitch.Visibility = Visibility.Hidden;
            ResultWindow.Visibility = Visibility.Hidden;
            RollOne.Visibility = Visibility.Visible;
            RollTwo.Visibility = Visibility.Hidden;
            PlayerOneTurn.Content = 10.ToString();
            PlayerTwoTurn.Content = 10.ToString();
            DiceBox.Source = new BitmapImage(new Uri(deaultImg, UriKind.Relative));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            CBrowserPage.GamePage.GameText.Text = "A Game for make you feel competitor";
            CBrowserPage.GamePage.OpenDiceGame.Visibility = Visibility.Visible;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ResultBoxWin.winOrLose.Close();
            Logging llg = new Logging();
            llg.Close();
            HomePage.homePage.WindowState = WindowState.Normal;
        }
    }
}
