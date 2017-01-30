//https://projecteuler.net/problem=1
namespace ProjectEulerSolutions._001
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem1 : IEulerSolution
    {
        public static List<int> Multiples = new List<int>();

        public Action<int, int> FindMultiples = delegate(int multiple, int numbersBelow)
            {
                for (var i = 0; i < numbersBelow; i++)
                {
                    var testsum = multiple * i;
                    if (testsum < numbersBelow)
                    {
                        Multiples.Add(testsum);
                    }
                }
            };

        public List<int> Numbers = new List<int> { 3, 5 };

        public int NumbersBelow = 1000;

        public string Run()
        {
            this.Numbers.ForEach(x => this.FindMultiples(x, this.NumbersBelow));

            return Multiples.Distinct().Sum().ToString();
        }
    }
}
