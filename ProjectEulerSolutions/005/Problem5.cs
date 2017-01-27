using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._005
{
    class Problem5 : IEulerSolution
    {
        public string Run()
        {
            return FindEvenlyDivisibleNumber(20).ToString();
        }


        public int FindEvenlyDivisibleNumber( int maxDivisible)
        {
            bool found = false;
            var evenlyDivisiblenumber = 1;
            var count = 1;

            while (!found)
            {
                for (int i = maxDivisible; i > 0; i--)
                {
                    if ((count % i) != 0)
                    {
                        break;
                    }

                    if (i != 1) continue;

                    evenlyDivisiblenumber = count;
                    found = true;
                }

                count++;
            }


            return evenlyDivisiblenumber;
        }


    }
}
