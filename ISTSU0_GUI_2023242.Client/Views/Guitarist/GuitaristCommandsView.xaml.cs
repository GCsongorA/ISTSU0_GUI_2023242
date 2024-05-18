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
using ISTSU0_GUI_2023242.Client.ViewModels;
using ISTSU0_GUI_2023242.Client.ViewModels.Guitarist;
using ISTSU0_GUI_2023242.Client.Views.Guitarist;

namespace ISTSU0_GUI_2023242.Client.Views
{
    /// <summary>
    /// Interaction logic for GuitaristCommandsView.xaml
    /// </summary>
    public partial class GuitaristCommandsView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public GuitaristCommandsView()
        {
            InitializeComponent();
        }
        private void WhereGuitarist_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Bands = new ObservableCollection<ISTSU0_ADT_2023241.Models.Band>();
            ContentArea.Content = new WhereGuitaristView();
        }
        private void GetAll_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Guitarists = new ObservableCollection<ISTSU0_ADT_2023241.Models.Guitarist>();
            var result = restService.Get<ISTSU0_ADT_2023241.Models.Guitarist>($"/api/Guitarist/GetAll");
            foreach (var guitarist in result)
            {
                ViewModelBasic.Guitarists.Add(guitarist);
            }
            ContentArea.Content = new GuitaristDataGridView();
        }
        private void GetOne_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Guitarists = new ObservableCollection<ISTSU0_ADT_2023241.Models.Guitarist>();
            ContentArea.Content = new OneGuitarist();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new CreateGuitaristView();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new UpdateGuitaristView();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new DeleteGuitaristView();
        }
    }
}
