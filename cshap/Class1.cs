using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csmath
{
    class program
    {
        static void main(string[] args)
        {
            int x = 48;
            int y = 28;
            if (x == y)
            {
                Console.WriteLine("equal");
            } else if(x > y) {
                Console.WriteLine("y is larger then x");
            } else if(y > x) {
                Console.WriteLine("x is bigger then y or other ");
            }
        }
    }
}
