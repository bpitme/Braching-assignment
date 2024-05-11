using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.ReadLine();

            // new line //
            int packageweight = 40;
            int packagewidth = 10;

            if (packageweight == packagewidth)
            {
                Console.WriteLine("it is exactaly package");
            }
            else
            {
                Console.WriteLine("it is not exactaly package ");
            }
            Console.ReadLine();//

            int packageheight = 12;
            int packagelength = 11;

            if (packageheight >= 12 && packagelength <= 11)
            {
                Console.WriteLine("Your estimated total for shipping this package is: $528.00 Thank you!");
            }
            else
            {
                Console.WriteLine("you'r package can not be shipping");
            }
            Console.ReadLine();
        }
    }
}

           
            
                    
                     
