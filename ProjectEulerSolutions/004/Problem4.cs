namespace ProjectEulerSolutions._004
{
    using System;
    using System.Linq;

    internal class Problem4 : IEulerSolution
    {
        private Func<string, bool> isPalindrome => item =>
            {
                var subject = item.AsEnumerable();
                return subject.SequenceEqual(subject.Reverse());
            };

        public Tuple<int, int> FindPalindromeProduct(int maxNumber)
        {
            var palindromeTuple = new Tuple<int, int>(0, 0);
            var largestPalindrome = 0;

            for (var i = 0; i < maxNumber; i++)
                for (var n = 0; n < maxNumber; n++)
                {
                    var multiple = i * n;

                    if (!isPalindrome(multiple.ToString())) continue;

                    if (multiple <= largestPalindrome) continue;

                    largestPalindrome = multiple;
                    palindromeTuple = new Tuple<int, int>(i, n);
                }

            return palindromeTuple;
        }

        public string Run()
        {
            var palindrome = FindPalindromeProduct(999);
            var sum = palindrome.Item1 + palindrome.Item2;
            return (palindrome.Item1 * palindrome.Item2).ToString();
        }
    }
}