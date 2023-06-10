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
        ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            this.DataContext = viewModel;
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Delete();
            
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Add();
        }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Color> listColor = new ObservableCollection<Color>();
        public IEnumerable ListColor => listColor;

        public void Add()
        {
            listColor.Add(this.CurrentColor);
        }
        public void Delete()
        {
            listColor.Remove(SelectedColor);
        }

        public Color SelectedColor { get; set; }
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
       
    }
}