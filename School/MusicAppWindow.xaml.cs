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
using System.Windows.Threading;
using Microsoft.Win32;

namespace SDD_Student
{
    /// <summary>
    /// Interaction logic for MusicAppWindow.xaml
    /// </summary>
    public partial class MusicAppWindow : Window
    {
        private MediaPlayer musicPlayer = new MediaPlayer();
        public MusicAppWindow()
        {
            InitializeComponent();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                musicPlayer.Open(new Uri(openFileDialog.FileName));

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (musicPlayer.Source != null)
                TimeLine.Content = String.Format("{0} / {1}", musicPlayer.Position.ToString(@"mm\:ss"), musicPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                TimeLine.Content = "File Not Found";
                TimeLine.Background = Brushes.Red;

        }
        private void ButtonClose1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BringHomeWindow_Click(object sender, RoutedEventArgs e)
        {
            HomePage.homePage.WindowState = WindowState.Normal;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HomePage.homePage.WindowState = WindowState.Minimized;
            MusicPage.musicpage.MusicAppWindow.Visibility = Visibility.Hidden;
            MusicPage.musicpage.NeVtoTaskBar.Text = "Click on the taskbar window to reopen";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            HomePage.homePage.WindowState = WindowState.Normal;
            MusicPage.musicpage.MusicAppWindow.Visibility = Visibility.Visible;
            MusicPage.musicpage.NeVtoTaskBar.Text = "Use this to listen music in free time for break time.";

            MessageBox.Show("Due to time\nThere is only one song\nFor every button\n\n");
        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {
            musicPlayer.Pause();
        }

        private void SongOneBtn_Click(object sender, RoutedEventArgs e)
        {
            RecentSong.Content = "Song 1";
            musicPlayer.Play();
        }

        private void SongTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            RecentSong.Content = "Song 2";
            musicPlayer.Play();
        }

        private void SongThrBtn_Click(object sender, RoutedEventArgs e)
        {
            RecentSong.Content = "Song 3";
            musicPlayer.Play();
        }

        private void SongFourBtn_Click(object sender, RoutedEventArgs e)
        {
            RecentSong.Content = "Song 4";
            musicPlayer.Play();
        }

    }
}
