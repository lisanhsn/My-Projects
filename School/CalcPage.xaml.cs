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
    /// Interaction logic for CalcPage.xaml
    /// </summary>
    public partial class CalcPage : Page
    {
        public static CalcPage cp;
        public CalcPage()
        {
            InitializeComponent();
            cp = this;
        }

        private void OpenCalcWindow_Click(object sender, RoutedEventArgs e)
        {
            Apps.Calc cl = new Apps.Calc();
            cl.Show();
        }

    }
}
