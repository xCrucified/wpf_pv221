using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        private int counts = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            counts++;

            if (counts > 12)
            {
                counts = 0;
            }
            txtBoxCount.Text = counts.ToString();
        }

        private void showSelectionBtn(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate != null)
                MessageBox.Show($"From: {calendar.SelectedDates.First()}\nTo: {calendar.SelectedDates.Last()}", "Selected Dates");
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
