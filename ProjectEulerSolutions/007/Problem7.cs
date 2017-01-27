namespace ProjectEulerSolutions._007
{
    using System.Collections.Generic;
    using System.Linq;

    using ExtentionsLib.Math;

    internal class Problem7 : IEulerSolution
    {
        public string Run()
        {
            return this.FindPrimeNumber(10001).ToString();
        }

        private int FindPrimeNumber(int posision)
        {
            var primeArray = new List<int>();
            var count = 2;
            while (primeArray.Count != posision)
            {
                if (PrimeTool.IsPrime(count)) primeArray.Add(count);
                count++;
            }

            return primeArray.Max();
        }
    }
}