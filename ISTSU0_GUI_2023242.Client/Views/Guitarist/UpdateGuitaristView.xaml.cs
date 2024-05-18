using ISTSU0_ADT_2023241.Endpoint.Dtos;
using ISTSU0_ADT_2023241.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

namespace ISTSU0_GUI_2023242.Client.Views.Guitarist
{
    /// <summary>
    /// Interaction logic for UpdateGuitaristView.xaml
    /// </summary>
    public partial class UpdateGuitaristView : UserControl
    {
        RestService restService = new RestService("http://localhost:5082");
        public UpdateGuitaristView()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.Put<ISTSU0_ADT_2023241.Models.Guitarist, UpdateGuitaristDto>(new UpdateGuitaristDto { BandId = Guid.Parse(txbBandGuid.Text), Age = int.Parse(txbAge.Text) }, $"/api/Guitarist/Update/{txbGuitaristGuid.Text}");
            MessageBox.Show("Data updated successfully!");
        }
    }
}
