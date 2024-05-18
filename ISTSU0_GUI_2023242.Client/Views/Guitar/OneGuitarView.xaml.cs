using ISTSU0_GUI_2023242.Client.ViewModels;
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

namespace ISTSU0_GUI_2023242.Client.Views.Guitar
{
    /// <summary>
    /// Interaction logic for OneGuitarView.xaml
    /// </summary>
    public partial class OneGuitarView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public OneGuitarView()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.GetSingle<ISTSU0_ADT_2023241.Models.Guitar>($"/api/Band/GetOne/{txbGuitarGuid.Text}");
            ViewModelBasic.Guitars.Add(result);
            DataGrid.ItemsSource = ViewModelBasic.Guitars;
        }
    }
}
