using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace SDD_Student.Apps
{
    /// <summary>
    /// Interaction logic for NotePadApp.xaml
    /// </summary>
    public partial class NotePadApp : Window
    {

        //bring the class from other file
        public static NotePadApp npApp;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //public string fileName = @"C:\Temp\Mahesh.txt";
        public int forFileNumber = 0;
        public NotePadApp()
        {
            InitializeComponent();
            npApp = this;
        }

        public int initailFontSize = 15;


        // open a existed file


        // btn to open window for open file
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
                NoteBox.Text = File.ReadAllText(openFileDialog.FileName);
            SaveBtn.Visibility = Visibility.Visible;
        }


        // for creating a new file
        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == true)
                saveFileDialog.Filter = "Text Files | *.txt";
                saveFileDialog.DefaultExt = "txt";
            File.WriteAllText(saveFileDialog.FileName, NoteBox.Text);
            SaveBtn.Visibility = Visibility.Visible;
        }


        //things will be loaded while user open the app
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Would you like create a new file or open existed file\n Press Yes to create new file\nPress No to open a file\n Press Cancel to close the window ", "User File Infomation", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    if (openFileDialog.ShowDialog() == true)
                        NoteBox.Text = File.ReadAllText(openFileDialog.FileName);
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Write note as you go \nDon't forget to click save");
                    break;
            }

            NotePadPage.npage.notepagetext.Text = "Go to taskbar to open the window";
            NotePadPage.npage.OpenNoteWindow.Visibility = Visibility.Hidden;
            SaveBtn.Visibility = Visibility.Hidden;
        }


        // exit button
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        // save  btn to save file
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.WriteAllText(saveFileDialog.FileName, NoteBox.Text);
            }
            catch
            {
                File.WriteAllText(openFileDialog.FileName, NoteBox.Text);
            }
        } 


        // close btn to exit the app
        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult opinion = MessageBox.Show("Are you sure to clear\nAnd Delete this file.", "User File Infomation", MessageBoxButton.YesNo);
                switch (opinion)
                {
                    case MessageBoxResult.Yes:
                        File.Delete(saveFileDialog.FileName);
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Press Exit to close this App");
                        break;
                }
            } catch( Exception)
            {
                MessageBox.Show("You have not opened a file");
            }
        }


        // window will open homepage again after user closed this app
        private void Window_Closed(object sender, EventArgs e)
        {
            HomePage.homePage.WindowState = WindowState.Normal;
            NotePadPage.npage.notepagetext.Text = "Use this simple note app to write your class notes.";
            NotePadPage.npage.OpenNoteWindow.Visibility = Visibility.Visible;
        }

        // going to addd random to text color each click/
        private void RandomColorBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] colors = { "Red", "Blue", "Yellow", "SkyBlue", "Teal", "DarkRed" };
                                //0    1        2            3         4         5
            Random rnd = new Random();
            int colorNum = rnd.Next(0, colors.Length);
            switch(colorNum)
            {
                case 0:
                    NoteBox.Foreground = Brushes.Red;
                    break;
                case 1:
                    NoteBox.Foreground = Brushes.Blue;
                    break;
                case 2:
                    NoteBox.Foreground = Brushes.Yellow;
                    break;
                case 3:
                    NoteBox.Foreground = Brushes.SkyBlue;
                    break;
                case 4:
                    NoteBox.Foreground = Brushes.Teal;
                    break;
                case 5:
                    NoteBox.Foreground = Brushes.DarkRed;
                    break;
                default:
                    NoteBox.Foreground = Brushes.Black;
                    break;
            }
    }

        private void BlackColorBtn_Click(object sender, RoutedEventArgs e)
        {
            NoteBox.Foreground = Brushes.Black;
        }

        private void BoldBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NoteBox.FontWeight == FontWeights.Bold)
            {
                NoteBox.FontWeight = FontWeights.Normal;
            }
            else
            {
                NoteBox.FontWeight = FontWeights.Bold;
            }
        }

        private void IncreaseFontSize_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                initailFontSize++;
                NoteBox.FontSize = initailFontSize;
            }
            catch (Exception problem)
            {
                MessageBox.Show("Font size now is " + initailFontSize.ToString()+"\nIt is in negative");
            }
        }

        private void DecreseFontSize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                initailFontSize--;
                NoteBox.FontSize = initailFontSize;
            } catch(Exception problem)
            {
                MessageBox.Show("It can't go lower than this\nFont size now is "+ initailFontSize.ToString());
            }
        }
    }
}
