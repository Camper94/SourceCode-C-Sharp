using System;
using System.Collections.Generic;
namespace Library
{
    public class LibraryTest
    {
         public string PrimeFactors(int num)
         {
            List<int> result = new List<int>();

            // Take out the 2s.
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Take out other primes.
            int factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // This is a factor.
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Go to the next odd number.
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (num > 1) result.Add(num);

            return string.Join(" ", result.ToArray());
        } 
    }
}
