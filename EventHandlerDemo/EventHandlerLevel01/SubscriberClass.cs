using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel01
{
    internal class SubscriberClass
    {
        public static void Main()
        {
            PublisherClass subscriber = new PublisherClass();
            subscriber.ProcessComplete += Sub_ProcessComplete;
            subscriber.ProcessComplete += Sub_ProcessComplete2;
            subscriber.StartProcess();
            Console.ReadKey();
        }

        public static void Sub_ProcessComplete()
        {
            Console.WriteLine("Completed Process");
        }
        public static void Sub_ProcessComplete2()
        {
            Console.WriteLine("Completed Process 2 ");
        }
    }
}

/*
        **https://www.tutorialsteacher.com/csharp/csharp-event**
        **************Declare an Event********************
        *An event can be declared in two steps:

         // 1. Declare a delegate.

         public delegate void Notify();  
                    
         public class ProcessBusinessLogic 
         {
                // 2. Declare a variable of the delegate with event keyword.
                public event Notify ProcessCompleted; 
         }
 */
