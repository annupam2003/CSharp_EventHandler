using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel02
{
    internal class SubClass
    {
        public void Sub(int a, int b) => Console.WriteLine($"Sub of Two Number is { a - b }");
    }
}
