using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtentionsLib.Math;

namespace ProjectEulerSolutions._014
{
    using System.Net.Http.Headers;

    using ExtentionsLib.Integers;

    class Problem14: IEulerSolution
    {
        public string Run()
        {

            return EnumerateNumbers().ToString();



        }

        public int EnumerateNumbers()
        {
            var result = 0;
            var umb = 0

            foreach (var number in 1.Range(10000))
            {
                result = Math.Max(result, Selector(number));
            }
            

            return 1.Range(1000000).Select()
        }

        private int Selector(int i)
        {
           
          

            var chain = 0;
            var CollatzNumber = i;
            var finished = false;

            var sequence = i;
            while (sequence != 1)
            {
                if (sequence.IsEven())
                {
                    sequence = sequence / 2;
                }
                else
                {
                    sequence = sequence * 3 + 1;
                }
                chain++;
            }

            return chain;
        }

    }
}
