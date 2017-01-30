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
        struct CollatzSequenceNumber
        {
            public long Number { get; set; }
            public long Chain { get; set; }
        } 

        public string Run()
        {

            return EnumerateNumbers().ToString();



        }

        public long EnumerateNumbers()
        {
            var result = 0;
            var heighetsNumber = 0;
            var collazList = new List<CollatzSequenceNumber>();
            
            foreach (long number in 1.Range(1000000))
            {
                long chain = CalculateChain(number);
                collazList.Add(new CollatzSequenceNumber() { Chain = chain, Number = number });
                
            }
            

            return collazList.OrderByDescending(x=> x.Chain).First().Number;
            
        }

        private int CalculateChain(long i)
        {
            var chain = 1;
            

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
