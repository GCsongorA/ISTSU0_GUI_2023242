using ISTSU0_GUI_2023242.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTSU0_GUI_2023242.Client.ViewModels.Guitar
{
    public class GuitarDataGridViewModel: ViewModelBasic
    {
        public GuitarDataGridViewModel(GuitarDataGridView view) 
        {
            view.DataGrid.ItemsSource = Guitars;
        }
    }
}
