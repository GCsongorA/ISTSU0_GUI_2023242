using ISTSU0_GUI_2023242.Client.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISTSU0_GUI_2023242.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Band_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new BandCommandsView();
        }

        private void Guitarist_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new GuitaristCommandsView();
        }
        private void Guitar_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new GuitarCommandsView();
        }
    }
}