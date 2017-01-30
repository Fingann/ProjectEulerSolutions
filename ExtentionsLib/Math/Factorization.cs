using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsLib.Math
{
    using Math = System.Math;

    static public  class Factorization
    {
        public static IEnumerable<long> getFactors(long x)
        {
            for (long i = 1; i * i <= x; i++)
                if (x % i == 0)
                {
                    yield return i;
                    if (i != x / i)
                    {
                        yield return x / i;
                    }
                }
        }

        public static List<long> FindFactors(long number)
        {
            var factors = new List<long>();

            while (number > 1)
            {
                var nextFactor = 2;
                if (number % nextFactor > 0)
                {
                    nextFactor = 3;
                    do
                    {
                        if (number % nextFactor == 0) break;

                        nextFactor += 2;
                    }
                    while (nextFactor < number);
                }

                number /= nextFactor;
                factors.Add(nextFactor);
            }

            return factors;
        }
    }
}
