using ISTSU0_GUI_2023242.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTSU0_GUI_2023242.Client.ViewModels.Guitarist
{
    public class GuitaristDataGridViewModel:ViewModelBasic
    {
        public GuitaristDataGridViewModel(GuitaristDataGridView view)
        {
            view.DataGrid.ItemsSource = Guitarists;
        }
    }
}
