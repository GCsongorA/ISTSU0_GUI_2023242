using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;
using ISTSU0_ADT_2023241.Models;
using ISTSU0_GUI_2023242.Client.ViewModels;
using ISTSU0_GUI_2023242.Client.ViewModels.Band;
using ISTSU0_GUI_2023242.Client.Views.Band;

namespace ISTSU0_GUI_2023242.Client.Views
{
    /// <summary>
    /// Interaction logic for BandCommandsView.xaml
    /// </summary>
    public partial class BandCommandsView : UserControl
    {
        public BandCommandsView()
        {
            InitializeComponent();
        }
        RestService restService = new RestService("http://localhost:5082");

        private void MultipleGuitarists_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new MultipleGuitaristsView();
        }
        private void WhatGuitars_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new WhatGuitarsView();
        }
        private void GetAll_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Bands = new ObservableCollection<ISTSU0_ADT_2023241.Models.Band>();
            var result = restService.Get<ISTSU0_ADT_2023241.Models.Band>($"/api/Band/GetAll");
            foreach ( var band in result )
            {
                ViewModelBasic.Bands.Add(band);
            }
            ContentArea.Content = new BandDataGridView();
        }
        private void GetOne_Click(object sender, RoutedEventArgs e)
        {
            ViewModelBasic.Bands = new ObservableCollection<ISTSU0_ADT_2023241.Models.Band>();
            ContentArea.Content = new OneBandView();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new CreateBandView();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new UpdateBandView();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new DeleteBandView();
        }
    }
}
