using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _03_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow:Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Color> listColor = new();

        private byte alpha;
        private byte red;
        private byte green;
        private byte blue;

        public byte Alpha
        {
            get { return alpha; }
            set
            {
                alpha = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }
        public byte Red
        {
            get { return red; }
            set
            {
                red = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }
        public byte Green
        {
            get { return green; }
            set
            {
                green = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }
        public byte Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Color CurrentColor => Color.FromArgb(Alpha, Red, Green, Blue);
        private void addClick()
        {
            Color color = CurrentColor; // Приклад кольору (червоний)

            // Конвертація в шістнадцятковий код з використанням великих літер (наприклад, "#FF0000")
            color.GetHashCode();

            // Конвертація в шістнадцятковий код з використанням малих літер (наприклад, "#ff0000")
            
        }
 

    }

}