using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class Pgm
    {


        public static void Main()
        {
            Console.WriteLine("Enter the first no.:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no.:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third no.:");
            int z = Convert.ToInt32(Console.ReadLine());

            int d = (x + y) * z;
            int e = x*y + y*z;
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
