using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel01
{
    internal class PublisherClass
    {
        public delegate void Notify();
        public event Notify ProcessComplete;

        public void StartProcess()
        {
            Console.WriteLine("Start Process");
            //some process
            OnProcessComplete();
        }

        protected virtual void OnProcessComplete()
        {
            ProcessComplete.Invoke();
        }
    }
}
