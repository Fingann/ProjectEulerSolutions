using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._015
{
    class Problem15 : IEulerSolution
    {
        public string Run()
        {
            const int gridSize = 20;
            long paths = 1;

            for (int i = 0; i < gridSize; i++)
            {
                paths *= (2 * gridSize) - i;
                paths /= i + 1;
            }
            return paths.ToString();
        }

       

   


        

    }
}
