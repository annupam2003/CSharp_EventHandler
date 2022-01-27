using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel02
{
    //Declared Delegate
    public delegate void Calc(int a, int b); 
    public class Program
    {
        public static void Main()
        {
            SubscriberClass sb = new SubscriberClass();
            sb.MyHandler(50, 10);
            Console.ReadKey();
        }
    }
}
