using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerLevel03
{
    public delegate void CustomHandler<CustomArgs>(object sender, CustomArgs args);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            OpeningAccount acc = new OpeningAccount();
            Voting vot = new Voting();
            PublisherClass pub = new PublisherClass();
            pub.CustomEvent += acc.IsElegibleForAccount;
            pub.CustomEvent += vot.IsElegibleForVoting;

            bool con= false;
            do
            {
                Console.WriteLine("Enter the name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                var age = Convert.ToInt32( Console.ReadLine());

                pub.EventReise(name, age);

                Console.WriteLine("do you want to continue");
                con = Console.ReadLine().ToUpper().Equals("Y");
            } while (con);

        }
    }
}
