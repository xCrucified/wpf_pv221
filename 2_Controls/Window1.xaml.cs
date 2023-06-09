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
           SaveFile();
        }

        private void ReadFile()
        {

        }
        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                string textToWrite = @$"
Name: {nameTxtBoxSecond.Text}
Surname: {surnameTxtBoxSecond.Text}
Contact Information: {contactTxtBoxSecond}
Count People: {countPeopleTxtBoxSecond}
Type Class: {countPeopleTxtBoxSecond}
Duration of living: {livingTxtBoxSecond}.
";

                File.WriteAllText(filePath, textToWrite);
                MessageBox.Show("File was saved.");
            }
        }
    }
}
