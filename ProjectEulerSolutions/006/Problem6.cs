using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._006
{
    class Problem6: IEulerSolution
    {
        public string Run()
        {
            return FindTheDiffrence(1, 100).ToString();
        }


        public double FindTheDiffrence(int lowestNumber, int highestNumber)
        {
            var sumOfSqueres = FindSumOfSqueres(lowestNumber, highestNumber);
            var squareOfSum = FindSquereOfTheSum(lowestNumber, highestNumber);
            return squareOfSum - sumOfSqueres;
        }

        public double FindSumOfSqueres(int lowestNumber, int highestNumber)
        {
            double tempSum = 0;

            for ( int i = lowestNumber; i <= highestNumber; i++)
            {
                tempSum += i * i;
            }
            Console.WriteLine("FindSumOfSqueres:" + tempSum);
            return tempSum;
        }

        public double  FindSquereOfTheSum(int lowestNumber, int highestNumber)
        {
            double tempSum = 0;

            for (int i = lowestNumber; i <= highestNumber; i++)
            {
                tempSum += i;
            }
            Console.WriteLine("FindSquereOfTheSum:" + tempSum * tempSum);
            return tempSum * tempSum;
        }
    }
}
