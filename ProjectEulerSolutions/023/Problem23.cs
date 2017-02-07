using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._023
{
    using ExtentionsLib.Math;
    class Problem23: IEulerSolution
    {
        public string Run()
        {
            var limit = 28123;
            var abundantNumbers = Factorization.GetAbundantNumbers(limit).ToList();

            var summedNumbers = GetAbundentNumberersSummed(abundantNumbers, limit);


            var sum = SumNumbersNotInList(summedNumbers, limit);



            return sum.ToString();
        }

        public int SumNumbersNotInList(bool[] AbundentNumberersSummed, int limit)
        {
            var tempSum = 0;
            // Sum the numbers which are not sums of two abundant numbers
            for (var i = 1; i <= limit; i++)
            {
                if (!AbundentNumberersSummed[i])
                {
                    tempSum += i;
                }
            }
            return tempSum;

        }

        public bool[] GetAbundentNumberersSummed(List<int> AbundandNumbersList, int limit )
        {
            var canBeSumedWithAbundent = new bool[limit + 1];
 
            // Make all the sums of two abundant numbers
            for (var i = 0; i < AbundandNumbersList.Count; i++)
            {
                for (var j = i; j < AbundandNumbersList.Count; j++)
                {
                    if (AbundandNumbersList[i] + AbundandNumbersList[j] <= limit)
                    {
                        canBeSumedWithAbundent[AbundandNumbersList[i] + AbundandNumbersList[j]] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return canBeSumedWithAbundent;
        }


    }
}
