using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class Average
    {


        public static void Main2()
        {
            Console.WriteLine("Enter the first no.:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no.:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third no.:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth no.:");
            int d = Convert.ToInt32(Console.ReadLine());

            float avg = (a + b + c + d) / 4;
            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
