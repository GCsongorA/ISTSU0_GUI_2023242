using ISTSU0_ADT_2023241.Endpoint.Dtos;
using ISTSU0_ADT_2023241.Models;
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
using System.Xml.Linq;

namespace ISTSU0_GUI_2023242.Client.Views
{
    /// <summary>
    /// Interaction logic for UpdateBandView.xaml
    /// </summary>
    public partial class UpdateBandView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public UpdateBandView()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.Put<ISTSU0_ADT_2023241.Models.Band, UpdateBandDto>(new UpdateBandDto { Genre = (Enum.Parse<Genre>(txbGenre.Text)), Name = txbName.Text }, $"/api/Band/Update/{txbBandGuid.Text}");
            MessageBox.Show("Data updated successfully!");
        }
    }
}
