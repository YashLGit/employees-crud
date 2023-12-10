using System;
using System.Linq;

namespace TryOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = NumPrimeArrangements(100);
            Console.WriteLine(r);
        }

        // Corrected to be static
        public static int NumPrimeArrangements(int num)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int primesCount = primes.Count(p => p <= num);

            long f1 = fact(num - primesCount);
            long f2 = fact(primesCount);

            return (int)((f1 * f2) % 1000000007);

            long fact(int n) => n > 1 ? (n * fact(n - 1)) % 1000000007 : 1;
        }
    }
    
}
