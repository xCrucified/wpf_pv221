using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

namespace _2_Controls
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void cancelBtnCLick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void applyBtnCLick(object sender, RoutedEventArgs e)
        {

            string data = $"Name: {nameTxtBoxSecond.Text}\nSurname: {surnameTxtBoxSecond.Text}\nClass: {classesTxtBoxSecond.Text}\nContact information: {contactTxtBoxSecond.Text}\nPeople's: {countPeopleTxtBoxSecond.Text}\nLiving duration: {livingTxtBoxSecond.Text}\nPrice: ${priceTxtBoxSecond.Text}";

            string filePath = "data.txt";

            try
            {
                File.WriteAllText(filePath, data);

                MessageBox.Show("Successfully.");
                Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error : ");
            }
        }
    }
}