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
    /// Interaction logic for DeleteGuitarView.xaml
    /// </summary>
    public partial class DeleteGuitarView : UserControl
    {
        RestService restService = new RestService("http://localhost:5082");
        public DeleteGuitarView()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            restService.Delete(txbGuitarGuid.Text, $"/api/Guitar/Delete");
            MessageBox.Show("Data removed successfully!");
        }
    }
}
