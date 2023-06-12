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
        private double price = 10;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            counts++;
            price++;    

            if (counts > 12)
            {
                counts = 0;
                price = 0;
            }
            price = counts * counts;
            txtBoxCount.Text = counts.ToString();
        }

        private void applyBtn(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            char symb = '$';

            if (economRBtn.IsChecked == true)
            {
                price = price * 1.2;
                window1.classesTxtBoxSecond.Text = $"Econom class";
            }
            if (standartRBtn.IsChecked == true)
            {
                price = price * 1.8;
                window1.classesTxtBoxSecond.Text = $"Standart class";
            }
            if (premiumRBtn.IsChecked == true)
            {
                price = price * 2.4;
                window1.classesTxtBoxSecond.Text = $"Premium class";
            }

            if (calendar.SelectedDate != null) {
                window1.livingTxtBoxSecond.Text = $"From: {calendar.SelectedDates.First()}\nTo: {calendar.SelectedDates.Last()}";
            }

            window1.nameTxtBoxSecond.Text = nameTxtBox.Text;
            window1.surnameTxtBoxSecond.Text = surnameTxtBox.Text;
            window1.contactTxtBoxSecond.Text = contactTxtBox.Text;
            window1.countPeopleTxtBoxSecond.Text = counts.ToString();
            window1.priceTxtBoxSecond.Text = price.ToString() + symb;

            window1.Show();

        }
    }
}
