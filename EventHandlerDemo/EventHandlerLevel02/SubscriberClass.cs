using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel02
{
    internal class SubscriberClass
    {
        
        PublisherClass pub = null;
        public SubscriberClass()
        {
            SumClass sum = new SumClass();  //Create a object for subscription
            SubClass sub = new SubClass();  //Create a object for subscription
            MulClass mul = new MulClass();  //Create a object for subscription
            DivClass div = new DivClass();  //Create a object for subscription


            pub = new PublisherClass();     //Create object of Publisher class.
            pub.NumberCalc += sum.Sum;      //Subcription with publisher event
            pub.NumberCalc += sub.Sub;      //Subcription with publisher event
            pub.NumberCalc += mul.Mul;      //Subcription with publisher event
            pub.NumberCalc += div.Div;      //Subcription with publisher event
        }
        public void MyHandler(int a,int b)
        {
            pub?.calcProcess(a, b);
        }
    }
}
