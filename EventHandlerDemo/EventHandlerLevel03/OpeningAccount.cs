using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel03
{
    internal class OpeningAccount
    {
        public void IsElegibleForAccount(object sender, CustomArgs args)
        {
            string name=args.Name; 
            int age=args.Age;
            Console.WriteLine($"Hi {name} you are {(age > 18 ? "" :"not")} elegble for Opning account");
        }
    }
}
