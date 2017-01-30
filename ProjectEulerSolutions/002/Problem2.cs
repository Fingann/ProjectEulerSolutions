namespace ProjectEulerSolutions._002
{
    using System.Collections.Generic;
    using System.Linq;

    using ExtentionsLib.Integers;

    internal class Problem2 : IEulerSolution
    {
        public List<long> GenerateFinonacciNumbers(int ammountOfNumbers, int startNumberA = 1, int startNumberB = 2)
        {
            var fibonacciNumbers = new List<long> { startNumberA, startNumberB };

            for (var i = 2; i < ammountOfNumbers; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1]);
            }

            return fibonacciNumbers;
        }

        public string Run()
        {
            // 40 generates a fibonacchi number over 4000000
            var s = this.GenerateFinonacciNumbers(40).Where(number => number.IsEven() && (number < 4000000)).Sum();
            return s.ToString();
        }
    }
}