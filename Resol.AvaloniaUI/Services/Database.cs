using Resol.AvaloniaUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resol.AvaloniaUI.Services;


namespace Resol.AvaloniaUI.Services
{

    public class Database
    {
        public IEnumerable<Generating> GetItems() => new[]
        {
            new Generating { hexcolor = "Red" },
            new Generating { hexcolor = "Red" },
            new Generating { hexcolor = "Red" },
        };


    }
}
