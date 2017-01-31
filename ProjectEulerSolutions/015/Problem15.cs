namespace ProjectEulerSolutions._015
{
    internal class Problem15 : IEulerSolution
    {
        public string Run()
        {
            // binomialkoeffesient
            const int gridSize = 20;
            long paths = 1;

            for (var i = 0; i < gridSize; i++)
            {
                paths *= 2 * gridSize - i;
                paths /= i + 1;
            }

            return paths.ToString();
        }
    }
}