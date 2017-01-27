using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._010
{
    using ExtentionsLib.Math;

    class Problem10: IEulerSolution
    {
        public string Run()
        {
            var list = this.FindAllPrimesBelow(2000000);

            return list.Sum().ToString();
        }


        private List<long> FindAllPrimesBelow(int limit)
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
