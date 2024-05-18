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

namespace ISTSU0_GUI_2023242.Client.Views
{
    /// <summary>
    /// Interaction logic for DeleteBandView.xaml
    /// </summary>
    public partial class DeleteBandView : UserControl
    {
        static RestService restService = new RestService("http://localhost:5082");
        public DeleteBandView()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            restService.Delete(txbBandGuid.Text, $"/api/Band/Delete");
            MessageBox.Show("Data removed successfully!");
        }
    }
}
