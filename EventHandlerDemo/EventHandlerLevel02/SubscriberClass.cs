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
            SumClass sum = new SumClass();
            SubClass sub = new SubClass();
            MulClass mul = new MulClass();
            DivClass div = new DivClass();

            pub = new PublisherClass();
            pub.NumberCalc += sum.Sum;
            pub.NumberCalc += sub.Sub;
            pub.NumberCalc += mul.Mul;
            pub.NumberCalc += div.Div;
        }
        public void MyHandler(int a,int b)
        {
            pub?.calcProcess(a, b);
        }
    }
}
