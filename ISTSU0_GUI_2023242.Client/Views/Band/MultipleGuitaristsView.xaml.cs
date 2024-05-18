﻿using System;
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

namespace ISTSU0_GUI_2023242.Client.Views.Band
{
    /// <summary>
    /// Interaction logic for MultipleGuitaristsView.xaml
    /// </summary>
    public partial class MultipleGuitaristsView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public MultipleGuitaristsView()
        {
            InitializeComponent();
        }
        public string Text { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = restService.GetSingle<bool>($"/api/Band/DoesThisBandHaveMultipleGuitarists/{txbBandid.Text}");
            Text = result ? "Yes" : "No";
            TxtBlock.Text = Text;
        }
    }
}
