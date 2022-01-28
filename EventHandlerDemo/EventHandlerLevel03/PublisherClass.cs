using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel03
{
    internal class PublisherClass
    {
        public event CustomHandler<CustomArgs> CustomEvent;

        public void EventReise(string Name, int Age)
        {
            CustomArgs cm = new CustomArgs();
            cm.Name = Name;
            cm.Age = Age;
            CustomEvent?.Invoke(this, cm);
        }
    }
}
