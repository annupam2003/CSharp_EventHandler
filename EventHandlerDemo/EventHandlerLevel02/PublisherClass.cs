using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel02
{
    
    internal class PublisherClass
    {
        //Declared Events of Delegate Type
        public event Calc NumberCalc;   

        // Event Raised
        public void calcProcess(int a, int b)
        {
            Console.WriteLine($"Calcuation Start of Two Number \nFirst:{a} \nSecond:{b}");
            NumberCalc?.Invoke(a, b);
        }
    }
}
