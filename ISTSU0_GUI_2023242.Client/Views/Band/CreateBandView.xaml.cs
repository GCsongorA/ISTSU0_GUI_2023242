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
    /// Interaction logic for CreateBandView.xaml
    /// </summary>
    public partial class CreateBandView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public CreateBandView()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.Post<ISTSU0_ADT_2023241.Models.Band, CreateBandDto>(new CreateBandDto { Genre = (Enum.Parse<Genre>(txbGenre.Text)), Name = txbName.Text }, $"/api/Band/Create");
            MessageBox.Show("Data added successfully!");
        }
    }
}
