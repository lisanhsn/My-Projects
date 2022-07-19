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

namespace SDD_Student.Apps
{
    /// <summary>
    /// Interaction logic for Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        public static Calc calculatorApp;
        public Calc()
        {
            InitializeComponent();
            calculatorApp = this;
        }

        public string  placeHolder = "Enter data in the Box-1 and Box-2";
        public double boxOneData, boxTwoData, resultData;

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Content = 0;
            DataValueBox1.Clear();
            DataValueBox2.Clear();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubtractBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                boxOneData = Convert.ToDouble(DataValueBox1.Text);
                boxTwoData = Convert.ToDouble(DataValueBox2.Text);

                resultData = boxOneData - boxTwoData;
                ResultBox.Content = resultData.ToString();
            }
            catch
            {
                MessageBox.Show("Fill the two box with data\nOr in correct format and type");
            }
        }

        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                boxOneData = Convert.ToDouble(DataValueBox1.Text);
                boxTwoData = Convert.ToDouble(DataValueBox2.Text);

                resultData = boxOneData * boxTwoData;
                ResultBox.Content = resultData.ToString();
            }
            catch
            {
                MessageBox.Show("Fill the two box with data\nOr in correct format and type");
            }
        }

        private void DivisionBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                boxOneData = Convert.ToDouble(DataValueBox1.Text);
                boxTwoData = Convert.ToDouble(DataValueBox2.Text);

                resultData = boxOneData / boxTwoData;
                ResultBox.Content = resultData.ToString();
            }
            catch
            {
                MessageBox.Show("Fill the two box with data\nOr in correct format and type");
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            CalcPage.cp.CalPageText.Text = "Use this simple calculator app to calculate in math.";
            CalcPage.cp.OpenCalcWindow.Visibility = Visibility.Visible;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResultBox.Content = placeHolder;
            CalcPage.cp.CalPageText.Text = "Check on your takbar window";
            CalcPage.cp.OpenCalcWindow.Visibility = Visibility.Hidden;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                boxOneData = Convert.ToDouble(DataValueBox1.Text);
                boxTwoData = Convert.ToDouble(DataValueBox2.Text);

                resultData = boxOneData + boxTwoData;
                ResultBox.Content = resultData.ToString();
            } catch
            {
                MessageBox.Show("Fill the two box with data\nOr in correct format and type");
            }
        }
    }
}
