using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._016
{
    using System.Numerics;

    class Problem16: IEulerSolution
    {
        public string Run()
        {
            
            return SumOfDigits(BigInteger.Pow(2, 1000)).ToString();
        }



        public BigInteger SumOfDigits(BigInteger digits)
        {
            BigInteger Sum = new BigInteger();
            var digitsAsArray = (digits).ToString();
            foreach (var digit in digitsAsArray)
            {
                var digitasBigInt = new BigInteger(int.Parse(digit.ToString()));

                Sum += digitasBigInt;
                BigInteger.Add(digitasBigInt
                    ,
                    Sum);
               
            }


            return Sum;
        }
    }
}
