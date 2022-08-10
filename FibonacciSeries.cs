using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public static class FibonacciSeries
    {
        public static void DisplayFibonacciSeries()
        {
            int n = 10, firstTerm = 0, secondTerm = 1;
            Console.WriteLine("Fabonacci series till " + n + " terms:");

            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine(firstTerm + ",");
                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;

            }
        }
    }
}
