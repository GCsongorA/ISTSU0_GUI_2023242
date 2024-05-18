using ISTSU0_GUI_2023242.Client.ViewModels;
using ISTSU0_GUI_2023242.Client.ViewModels.Guitar;
using ISTSU0_GUI_2023242.Client.Views.Guitar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ISTSU0_GUI_2023242.Client.Views
{
    /// <summary>
    /// Interaction logic for GuitarCommandsView.xaml
    /// </summary>
    public partial class GuitarCommandsView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public GuitarCommandsView()
        {
            InitializeComponent();
        }

        private void GetAll_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Guitars = new ObservableCollection<ISTSU0_ADT_2023241.Models.Guitar>();
            var result = restService.Get<ISTSU0_ADT_2023241.Models.Guitar>($"/api/Guitar/GetAll");
            foreach (var guitar in result)
            {
                ViewModelBasic.Guitars.Add(guitar);
            }
            ContentArea.Content = new GuitarDataGridView();
        }
        private void GetOne_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Guitars = new ObservableCollection<ISTSU0_ADT_2023241.Models.Guitar>();
            ContentArea.Content = new OneGuitarView();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new CreateGuitarView();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new UpdateGuitarView();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new DeleteGuitarView();
        }
    }
}
