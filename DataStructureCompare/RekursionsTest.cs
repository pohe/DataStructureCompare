using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCompare
{
    public class RekursionsTest
    {

        public static int Fibonacci(int n)
        {
            if (n < 3)
            {
                return 1;
            }
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }

            //return (n < 3) ? 1 : (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        public static int FibonacciIterativt(int number)
        {
            //Implementer denne selv
            int sum = 0, p1 = 1, p2 = 1;

            if (number <= 0)
                sum = 0;
            else if (number < 3)
                sum = 1;
            else
            {
                for (int i = 2; i < number; i++)
                {
                    sum = p1 + p2;
                    p2 = p1;
                    p1 = sum;
                }
            }
            return sum;

        }
    }
}
