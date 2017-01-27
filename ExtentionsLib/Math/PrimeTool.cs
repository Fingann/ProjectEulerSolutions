using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsLib.Math
{
    public static class PrimeTool
    {

        public static Func<int, bool> IsPrime = candidate =>
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }

            return candidate != 1;


        };

        private static List<long> FindAllPrimesBelow(int limit)
        {
            var primes = new List<long>();
            for (int i = 0; i <= limit; i++)
            {
                if (PrimeTool.IsPrime(i)) primes.Add(i);

            }

            return primes;
        }

    }
}
