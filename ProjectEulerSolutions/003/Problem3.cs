//https://projecteuler.net/problem=3 
namespace ProjectEulerSolutions._003
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem3 : IEulerSolution
    {
        public List<long> FindFactors(long number)
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

        public string Run()
        {
            var factors = this.FindFactors(600851475143);
            return factors.Max(factor => factor).ToString();
        }
    }
}