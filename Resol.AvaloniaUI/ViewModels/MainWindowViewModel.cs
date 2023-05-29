using Resol.AvaloniaUI.Services;
using System.Collections.Generic;
using System;
using Resol.AvaloniaUI.ViewModels;
using System.Collections.ObjectModel;
using Resol.AvaloniaUI.Models;

namespace Resol.AvaloniaUI.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new GeneratingViewModel(db.GetItems());


        }

        public GeneratingViewModel List { get; }




    }
}