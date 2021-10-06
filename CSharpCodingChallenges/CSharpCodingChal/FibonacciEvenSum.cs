using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingChal
{
    class FibonacciEvenSum
    {

        static void Main(string[] args)
        {
            List<long> sum = new List<long>();

            int first = 0;

            for (int i = 1; i < 4000000; i+=first)
            {
                //Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    sum.Add(i);
                }
                first = i - first;
                //Console.WriteLine(Fibonacci(i));
            }

            Console.WriteLine($"The total sum is {sum.Sum()}");






            /*
             * class code VVV
             */

            //int j = 0;
            //int sum = 0;

            //for (int i = 1; i < 4000000; i += j)
            //{
            //    Console.WriteLine(i);
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    j = i - j;
            //}

            //Console.WriteLine($"The sum of all even values is {sum}");
        }
    }
}
