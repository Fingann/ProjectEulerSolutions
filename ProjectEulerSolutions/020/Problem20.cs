using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._020
{
    using System.Numerics;

    class Problem20: IEulerSolution
    {
        public string Run()
        {
           
            
            return Factorial(100).Select(toInt).Aggregate((a, b) => a + b).ToString();
        }


        public int toInt(char c)
        {
            return int.Parse(c.ToString());
        }

        public string Factorial(int x)
        {
            BigInteger sum = BigInteger.One;
            for (int i = 1; i <= x; i++)
            {
                sum *= i;
            }
            return sum.ToString();
        }

    }
}
