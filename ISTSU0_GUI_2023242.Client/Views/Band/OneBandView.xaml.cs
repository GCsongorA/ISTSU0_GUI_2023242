using System;
using System.Collections.Generic;
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
using ISTSU0_ADT_2023241.Models;
using ISTSU0_GUI_2023242.Client.ViewModels;

namespace ISTSU0_GUI_2023242.Client.Views.Band
{
    /// <summary>
    /// Interaction logic for OneBandView.xaml
    /// </summary>
    public partial class OneBandView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public OneBandView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.GetSingle<ISTSU0_ADT_2023241.Models.Band>($"/api/Band/GetOne/{txbBandGuid.Text}");
            ViewModelBasic.Bands.Add(result);
            DataGrid.ItemsSource = ViewModelBasic.Bands;
        }
    }
}
