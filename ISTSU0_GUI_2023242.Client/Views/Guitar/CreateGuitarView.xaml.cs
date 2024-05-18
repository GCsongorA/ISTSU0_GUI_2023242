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

namespace ISTSU0_GUI_2023242.Client.Views.Guitar
{
    /// <summary>
    /// Interaction logic for CreateGuitarView.xaml
    /// </summary>
    public partial class CreateGuitarView : UserControl
    {
        RestService restService = new RestService("http://localhost:5082");
        public CreateGuitarView()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.Post<ISTSU0_ADT_2023241.Models.Guitar, CreateGuitarDto>(new CreateGuitarDto { Model = txbModel.Text, Brand = txbBrand.Text, BodyType = Enum.Parse<BodyType>(txbBodyType.Text), GuitaristId =  Guid.Parse(txbGuitarist.Text)}, $"/api/Guitar/Create");
            MessageBox.Show("Data added successfully!");
        }
    }
}
