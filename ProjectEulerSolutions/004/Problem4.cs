using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._004
{
    using System.Collections;
    using System.Runtime.ExceptionServices;
    using System.Security.Cryptography.X509Certificates;

    class Problem4: IEulerSolution
    {
        

        public string Run()
        {

            var palindrome = FindPalindromeProduct(999);
            var sum = (palindrome.Item1) + (palindrome.Item2);
            return String.Format("{0},{1}",palindrome.Item1, palindrome.Item2) ;
        }

        public Tuple<int, int> FindPalindromeProduct(int maxNumber)
        {

            Tuple<int, int> palindromeTuple = new Tuple<int, int>(0,0);
              var largestPalindrome = 0;
           
            //var firstNumber = maxNumber;
            //var secoundNumber = maxNumber;
            //var count = 0;

            for (int i = 0; i < maxNumber; i++)
            {
                for (int n = 0; n < maxNumber; n++)
                {
                    var multiple = i * n;
                    if (isPalindrome(multiple.ToString()))
                    {
                        if (multiple > largestPalindrome)
                        {
                            largestPalindrome = multiple;
                            palindromeTuple = new Tuple<int, int>(i, n);

                        }
                    }


                }
            }

            //while (firstNumber > 0)
            //{
            //    while (secoundNumber > 0)
            //    {
            //        var multiple = firstNumber * secoundNumber;
            //        if (isPalindrome(multiple.ToString()))
            //        {
            //            if (multiple > largestPalindrome)
            //            {
            //                largestPalindrome = multiple;
            //                palindromeTuple = new Tuple<int, int>(firstNumber, secoundNumber);
                          
            //            }
            //            count++;
            //        }
            //        secoundNumber = secoundNumber -1;
            //    }

            //    firstNumber = firstNumber -1;
            //}



           return palindromeTuple;
        }

        private Func<string, bool> isPalindrome => item =>
            {
                
                var subject = item.AsEnumerable();
               return subject.SequenceEqual(subject.Reverse());
            };
    }
}
