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
using System.Xml.Linq;

namespace ISTSU0_GUI_2023242.Client.Views.Guitarist
{
    /// <summary>
    /// Interaction logic for CreateGuitaristView.xaml
    /// </summary>
    public partial class CreateGuitaristView : UserControl
    {
        RestService restService = new RestService("http://localhost:5082");
        public CreateGuitaristView()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.Post<ISTSU0_ADT_2023241.Models.Guitarist, CreateGuitaristDto>(new CreateGuitaristDto { Age = int.Parse(txbAge.Text), Name = txbName.Text, BandId = Guid.Parse(txbBandId.Text) }, $"/api/Guitarist/Create");
            MessageBox.Show("Data added successfully!");
        }
    }
}
