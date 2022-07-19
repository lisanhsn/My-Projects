using System;
using System.IO;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {

        public static HomePage homePage;
        // for Clock
        System.Windows.Threading.DispatcherTimer Time = new System.Windows.Threading.DispatcherTimer();

        //
        public HomePage()
        {

            InitializeComponent();
            homePage = this;
            MenuFrame.Navigate(new System.Uri("wPage.xaml", UriKind.RelativeOrAbsolute));

            //IMPORTANT//
            //// Data relatated


            // for the clock
            Time.Tick += new EventHandler(Timer_Click);
            Time.Interval = new TimeSpan(0, 0, 1);
            Time.Start();


        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            // clock setUp
            DateTime d;
            d = DateTime.Now;
            ShowTime.Content = d.Hour + " : " + d.Minute + " : " + d.Second;
        }

        private void CodeBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("CodeEditorPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void NoteBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("NotePadPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CalculatorBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("CalcPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void DefBrowserBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("DBrowserPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MyBrowserBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("CBrowserPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GoogleBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("OGoogPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MyGoogleBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("CGoogPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MyMusic_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("MusicPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MyAbout_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new System.Uri("AboutPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }


}
