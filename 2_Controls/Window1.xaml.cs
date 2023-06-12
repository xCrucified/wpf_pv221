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

            string data = $"{nameTxtBoxSecond.Text} \n {surnameTxtBoxSecond.Text} \n {classesTxtBoxSecond.Text} \n {contactTxtBoxSecond.Text} \n {countPeopleTxtBoxSecond.Text} \n {livingTxtBoxSecond.Text} \n ${priceTxtBoxSecond.Text}";

            string filePath = "data.txt";

            try
            {
                File.WriteAllText(filePath, data);

                MessageBox.Show("Successfully.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error : ");
            }
        }
    }
}