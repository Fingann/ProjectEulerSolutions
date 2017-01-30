namespace ProjectEulerSolutions._012
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem12 : IEulerSolution
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

        public int CalculateNumberofFactors(long number)
        {
            var factors = getFactors(number);
            return factors.Count();
        }

        public long IterateTriangleNumbers(int minimumFactorisations)
        {
            
            var numberofFactorsFound = false;
            var nextTriangleNumber = 0;
            var count = 1;
            while (!numberofFactorsFound)
            {
                nextTriangleNumber += count;

                var faktors = this.CalculateNumberofFactors(nextTriangleNumber);
                if (faktors > minimumFactorisations) numberofFactorsFound = true;
                count++;
            }

            return nextTriangleNumber;
        }

        public string Run()
        {
            
            return this.IterateTriangleNumbers(500).ToString();
        }
    }
}