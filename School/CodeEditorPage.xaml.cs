using System;
using System.Diagnostics;
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
    /// Interaction logic for CodeEditorPage.xaml
    /// </summary>
    public partial class CodeEditorPage : Page
    {
        public static CodeEditorPage cdp = new CodeEditorPage();
        public CodeEditorPage()
        {
            InitializeComponent();
            cdp = this;
        }

        private void OpenCodeWindow_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome", @"https://replit.com/");
        }
    }
}
