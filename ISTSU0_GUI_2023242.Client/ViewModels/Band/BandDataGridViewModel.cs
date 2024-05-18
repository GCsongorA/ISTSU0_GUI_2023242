using ISTSU0_GUI_2023242.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTSU0_GUI_2023242.Client.ViewModels.Band
{
    public class BandDataGridViewModel:ViewModelBasic
    {
        public BandDataGridViewModel(BandDataGridView view) 
        {
            view.DataGrid.ItemsSource = Bands;
        }
    }
}
