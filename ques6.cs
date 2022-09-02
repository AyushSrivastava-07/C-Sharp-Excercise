using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class Multiplication
    {


        public static void Main2()
        {
            Console.WriteLine("Input the first no. to multiply");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second no. to multiply");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third no. to multiply");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output");
            int d = a * b * c;
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
