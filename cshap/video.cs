using System;
using System.Collections.Generic;
using System.Linq;
    
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace video
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you subbed?");
            string result = Console.ReadLine();
            if (result == "yes")
            {
                Console.WriteLine("thank you");
            } else if (result == "no")
            { 
                Console.WriteLine("thank you for not subscribing, it is a big advantage");
            } else if (result == null) { 
                Console.WriteLine("you good"); 
            }
        }
    }
}