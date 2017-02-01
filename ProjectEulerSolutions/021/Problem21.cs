using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._021
{
    using System.Xml.Serialization;

    class Problem21 : IEulerSolution
    {

        public string Run()
        {
            
                
                var amicablePairs = GetPairs(10000);

            int sum = 0 ;
            foreach (var AmicablePair in amicablePairs)
            {

                sum += AmicablePair.Item1 + AmicablePair.Item2;


            }
            return sum.ToString();
        }

        private static IEnumerable<Tuple<int, int>> GetPairs(int max)
        {
            

            List<int> divsums =
                Enumerable.Range(0, max + 1).Select(i => ProperDivisors(i).Sum()).ToList();

           
            for (int i = 1; i < divsums.Count; i++)
            {
                int sum = divsums[i];
                if (i < sum && sum <= divsums.Count && divsums[sum] == i)
                {
                    yield return new Tuple<int, int>(i, sum);
                }
            }
        }




        public int SumProperDivisors(int number)
        {
            return ProperDivisors(number).Sum();
        }

        private static IEnumerable<int> ProperDivisors(int number)
        {
            return
                Enumerable.Range(1, number / 2)
                    .Where(divisor => number % divisor == 0);
        }
    }
}
