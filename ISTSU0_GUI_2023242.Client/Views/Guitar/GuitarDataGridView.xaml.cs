using ISTSU0_GUI_2023242.Client.ViewModels.Band;
using ISTSU0_GUI_2023242.Client.ViewModels.Guitar;
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
    /// Interaction logic for GuitarDataGridView.xaml
    /// </summary>
    public partial class GuitarDataGridView : UserControl
    {
        GuitarDataGridViewModel viewModel;
        public GuitarDataGridView()
        {
            InitializeComponent();
            viewModel = new GuitarDataGridViewModel(this);
            DataContext = viewModel;
        }
    }
}
