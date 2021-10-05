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


            for (int i = 0; i < 39; i++)
            {
                long result = Fibonacci(i);
                //*Console.WriteLine(Fibonacci(i))*;
                sum.Add(result);
            }

            Console.WriteLine(sum[sum.Count - 1]);
        }

        private static long Fibonacci(int n)
        {
            long first = 0;
            long second = 1;

            long evens = 0;

            for (int i = 0; i < n; i++)
            {
                long next = first;
                first = second;
                second = next + second;
                if (first % 2 == 0)
                {
                    evens += first;
                }
            }
            return evens;
        }
    }
}
