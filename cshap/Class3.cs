using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace penis
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("type in sum");
            string value = Console.ReadLine();
            Console.WriteLine("did you type this: \n" + value);

            Console.WriteLine("hey kiddie whats your age :)))");
            string age = Console.ReadLine();
            int paris = Convert.ToInt32(age);
            if (paris < 18)
            {
                Console.WriteLine("shawty looking bad asf tho");
            }
            else if (paris == 12)
            {
                Console.WriteLine("ZAMN");
            }
            else { Console.WriteLine("zad ;'("); }
        }
    }
}