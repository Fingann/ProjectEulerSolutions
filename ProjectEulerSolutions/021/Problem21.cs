using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._021
{
    class Problem21 : IEulerSolution
    {

        public string Run()
        {
            
                
                var amicablePairs = FindAmicablePairs(10000);

            int sum = 0 ;
            foreach (var AmicablePair in amicablePairs)
            {

                sum += AmicablePair.Item1 + AmicablePair.Item2;


            }
            return sum.ToString();
        }

        public IEnumerable<Tuple<int, int>> FindAmicablePairs (int maxNumber)
        {

            var amicablePairs = Enumerable.Range(0, maxNumber).Select(x => new Tuple<int, int>(x, SumProperDivisors(x))).Where(x => SumProperDivisors(x.Item2) == x.Item1);
            

            return amicablePairs;
        }




        public int SumProperDivisors(int number)
        {
            return FindProperDivisors(number).Sum();
        }

        public List<int> FindProperDivisors(int number)
        {
            var tempList = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    tempList.Add(i);
                }
            }
            return tempList;
        }
    }
}
