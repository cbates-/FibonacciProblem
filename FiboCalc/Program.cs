using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace FibonacciCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    public class FiboCalc
    {
        public int Fib(int n)
        {
            if (n < 0) { throw new ArgumentException("Value cannot be negative."); }


            int f = 0;

            int fibA = 0, fibB = 0;
            if (n == 0)
            {
                return 0;
            }

            fibA = 0;
            fibB = 1;
            if (n == 1)
            {
                return fibB;
            }

            for (int i = 2; i < n + 1; i++)
            {
                f = fibA + fibB;
                fibA = fibB;
                fibB = f;
            }


            return f;
        }
    }
}
