using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public static class PrimeNumbers
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " is not prime number");
                    break;
                }
                else
                {
                    Console.WriteLine(num + " is prime number");
                    break;
                }
            }
        }
    }
}
