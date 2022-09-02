using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class swapp
    {


        public static void Main2()
        {
            int firstNum = 5;
            int secondNum = 6;
            Console.WriteLine("before swapping");
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            int swap = firstNum;
            firstNum = secondNum;
            secondNum = swap;
            Console.WriteLine("after swapping");
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.ReadKey();



        }
    }
}
