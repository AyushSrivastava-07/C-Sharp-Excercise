using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class Arithmetic
    {


        public static void Main2()
        {
            Console.WriteLine("Input the first no.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second no.");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);
            int d = a - b;
            Console.WriteLine(d);
            int e = a * b;
            Console.WriteLine(e);
            int f = a / b;
            Console.WriteLine(f);
            int g = a % b;
            Console.WriteLine(g);
            Console.ReadKey();

        }
    }
}
