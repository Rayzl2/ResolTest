using Resol.AvaloniaUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol.AvaloniaUI.ViewModels
{
    public class GeneratingViewModel : ViewModelBase
    {
        public GeneratingViewModel(IEnumerable<Generating> items) =>
            Items = new ObservableCollection<Generating>(items);


        public ObservableCollection<Generating> Items { get; }
    }
}
