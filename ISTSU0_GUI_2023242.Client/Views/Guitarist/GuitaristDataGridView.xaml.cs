using ISTSU0_GUI_2023242.Client.ViewModels.Guitar;
using ISTSU0_GUI_2023242.Client.ViewModels.Guitarist;
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
    /// Interaction logic for GuitaristDataGridView.xaml
    /// </summary>
    public partial class GuitaristDataGridView : UserControl
    {
        GuitaristDataGridViewModel viewModel;
        public GuitaristDataGridView()
        {
            InitializeComponent();
            viewModel = new GuitaristDataGridViewModel(this);
            DataContext = viewModel;
        }
    }
}
