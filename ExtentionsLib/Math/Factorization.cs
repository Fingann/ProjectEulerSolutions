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


       


        public static int SumProperDivisors(int number)
        {
            return ProperDivisors(number).Sum();
        }

        public static  IEnumerable<int> ProperDivisors(int number)
        {
            return
                Enumerable.Range(1, number / 2)
                    .Where(divisor => number % divisor == 0);
        }

        public static bool IsPerfectNumber(int number)
        {
            return SumProperDivisors(number) == number;
        }

        public static bool IsAbundantNumber(this int number)
        {
            return SumProperDivisors(number) > number;
        }
        public static bool IsDeficientNumber(this int number)
        {
            return SumProperDivisors(number) < number;
        }


        public static IEnumerable<int> GetAbundantNumbers(int limit)
        {
            return Enumerable.Range(1, limit).Select(x => x).Where(x => x.IsAbundantNumber()).ToList();
        }
        public static IEnumerable<Tuple<int, int>> GetAmicablePairs(int limit)
        {


            List<int> divsums =
                Enumerable.Range(0, limit + 1).Select(i => ProperDivisors(i).Sum()).ToList();

            for (int i = 1; i < divsums.Count; i++)
            {
                int sum = divsums[i];
                if (i < sum && sum <= divsums.Count && divsums[sum] == i)
                {
                    yield return new Tuple<int, int>(i, sum);
                }
            }
        }

        // Eric Lippert’s Blog
        // Computing a Cartesian Product with LINQ
        // http://blogs.msdn.com/b/ericlippert/archive/2010/06/28/computing-a-cartesian-product-with-linq.aspx
        public static IEnumerable<IEnumerable<T>> CartesianProduct<T>(this IEnumerable<IEnumerable<T>> sequences)
        {
            // base case: 
            IEnumerable<IEnumerable<T>> result = new[] { Enumerable.Empty<T>() };
            foreach (var sequence in sequences)
            {
                var s = sequence; // don't close over the loop variable 
                                  // recursive case: use SelectMany to build the new product out of the old one 
                result =
                    from seq in result
                    from item in s
                    select seq.Concat(new[] { item });
            }
            return result;
        }
    }
}
