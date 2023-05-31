using Resol.AvaloniaUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resol.AvaloniaUI.Services;
using System.IO;
using Avalonia.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Resol.AvaloniaUI.Services
{

    public class Database
    {
        public IEnumerable<Generating> GetItems() => new[]
        {
            new Generating {  },
            new Generating {  },
            new Generating {  },
        };
        
    }
}
