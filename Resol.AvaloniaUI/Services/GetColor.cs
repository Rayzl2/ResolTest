﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol.AvaloniaUI.Services
{
    public class GetColor
    {
        public string generate() {
            var random = new Random();
            var color = String.Format("#{0:X6}", random.Next(0x1000000));
            return color;
        }
    }
}
