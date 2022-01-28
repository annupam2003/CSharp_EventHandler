using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel03
{
    internal class CustomArgs:EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
