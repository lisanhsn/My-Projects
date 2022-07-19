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

namespace NumSorting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }
        // Method Created for Run and calculate everything
        
        // Created a List
        List<int> numbers = new List<int>();
        // using Random class
        Random random = new Random();

        // Generating the Number List
        public void GenerateList(int LenOfList)
        {
            for (int i = 0; i < LenOfList; i++)
            {
                numbers.Add(random.Next(0, 100));  
            }
        }
        // END of GeneratList method///

        // Finding the Max Value getMaxValue method
        public void getMaxValue(List<int> theList)
        {
            int Max = theList[0];
            int MaxIndex = 0;
            int i = 1;
            while (i < theList.Count)
            {
                if (theList[i] > Max)
                {
                    Max = theList[i];
                    MaxIndex = i;
                }
                i = i + 1;
            }
            OutMaxValue.Text = OutMaxValue.Text + Max.ToString();
        }
        //End getMaxValue Method

        // Finding the Max Value getMinValue method
        public void getMinValue(List<int> inTheList)
        {
            int Min = inTheList[0];
            int MinIndex = 0;
            int m = 0;
            while (m < inTheList.Count)
            {
                if ( inTheList[m] < Min)
                {
                    Min = inTheList[m];
                    MinIndex = m;
                }
                m = m + 1;
            }
           //OutMinValue.Text = OutMinValue.Text + Min.ToString();

        }
        //End getMinValue Method

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GenerateNumber_Click(object sender, RoutedEventArgs e)
        {
            GenerateList(int.Parse(LenghtOfList.Text));
            foreach (int num in numbers)
            {
                listOut.Text = listOut.Text + Environment.NewLine + num.ToString();
            }
        }

        private void GetMaxValue_Click(object sender, RoutedEventArgs e)
        {
            getMaxValue(numbers);
        }
    }
}
