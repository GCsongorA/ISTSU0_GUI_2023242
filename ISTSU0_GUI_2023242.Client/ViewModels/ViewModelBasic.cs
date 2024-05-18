using ISTSU0_ADT_2023241.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ISTSU0_GUI_2023242.Client.ViewModels
{
    public class ViewModelBasic : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public static ObservableCollection<ISTSU0_ADT_2023241.Models.Band> Bands { get; set; } = new ObservableCollection<ISTSU0_ADT_2023241.Models.Band>();
        public static ObservableCollection<ISTSU0_ADT_2023241.Models.Guitar> Guitars { get; set; } = new ObservableCollection<ISTSU0_ADT_2023241.Models.Guitar>();
        public static ObservableCollection<ISTSU0_ADT_2023241.Models.Guitarist> Guitarists { get; set; } = new ObservableCollection<ISTSU0_ADT_2023241.Models.Guitarist>();
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
