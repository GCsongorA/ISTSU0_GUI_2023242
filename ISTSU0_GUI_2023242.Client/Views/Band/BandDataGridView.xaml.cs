using ISTSU0_GUI_2023242.Client.ViewModels;
using ISTSU0_ADT_2023241.Models;
using ISTSU0_GUI_2023242.Client.ViewModels.Band;
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

namespace ISTSU0_GUI_2023242.Client.Views
{
    /// <summary>
    /// Interaction logic for BandDataGridView.xaml
    /// </summary>
    public partial class BandDataGridView : UserControl
    {
        BandDataGridViewModel viewModel;
        public BandDataGridView()
        {
            InitializeComponent();
            viewModel = new BandDataGridViewModel(this);
            DataContext = viewModel;
        }
    }
}
