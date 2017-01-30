namespace ProjectEulerSolutions._005
{
    internal class Problem5 : IEulerSolution
    {
        public int FindEvenlyDivisibleNumber(int maxDivisible)
        {
            var found = false;
            var evenlyDivisiblenumber = 1;
            var count = 1;

            while (!found)
            {
                for (var i = maxDivisible; i > 0; i--)
                {
                    if (count % i != 0) break;

                    if (i != 1) continue;

                    evenlyDivisiblenumber = count;
                    found = true;
                }

                count++;
            }

            return evenlyDivisiblenumber;
        }

        public string Run()
        {
            return this.FindEvenlyDivisibleNumber(20).ToString();
        }
    }
}