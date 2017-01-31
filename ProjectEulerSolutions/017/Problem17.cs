namespace ProjectEulerSolutions._017
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Problem17 : IEulerSolution
    {
        public List<string> tens = new List<string>
                                       {
                                           "zero",
                                           "ten",
                                           "twenty",
                                           "thirty",
                                           "forty",
                                           "fifty",
                                           "sixty",
                                           "seventy",
                                           "eighty",
                                           "ninety"
                                       };

        public List<string> unit = new List<string>
                                       {
                                           "zero",
                                           "one",
                                           "two",
                                           "three",
                                           "four",
                                           "five",
                                           "six",
                                           "seven",
                                           "eight",
                                           "nine",
                                           "ten",
                                           "eleven",
                                           "twelve",
                                           "thirteen",
                                           "fourteen",
                                           "fifteen",
                                           "sixteen",
                                           "seventeen",
                                           "eighteen",
                                           "nineteen"
                                       };

        public string NumberToString(int number)
        {
            var sb = new StringBuilder();
            var result = string.Empty;

            var numberList = number.ToString().Select(x => int.Parse(x.ToString())).ToList();
            switch (numberList.Count)
            {
                case 3:

                    sb.Append($"{this.unit[numberList[0]]} hundred");

                    switch (numberList[1])
                    {
                        case 0:
                        case 1:
                            var overten = int.Parse(numberList[1] + numberList[2].ToString());
                            if (overten == 0) return sb.ToString();
                            sb.Append($" and {this.unit[overten]}");
                            return sb.ToString();
                            break;
                        default:
                            sb.Append($" and {this.tens[numberList[1]]}");
                            break;
                    }

                    switch (numberList[2])
                    {
                        case 0:
                            break;
                        default:
                            sb.Append($"-{this.unit[numberList[2]]}");
                            break;
                    }

                    break;

                case 2:

                    switch (numberList[0])
                    {
                        case 0:
                        case 1:
                            var overten = int.Parse(numberList[0] + numberList[1].ToString());
                            if (overten == 0) return sb.ToString();
                            sb.Append($"{this.unit[overten]}");
                            return sb.ToString();
                            break;
                        default:
                            sb.Append($"{this.tens[numberList[0]]}");
                            break;
                    }

                    switch (numberList[1])
                    {
                        case 0:
                            break;
                        default:
                            sb.Append($"-{this.unit[numberList[1]]}");
                            break;
                    }

                    break;
                case 1:
                    sb.Append(this.unit[numberList[0]]);
                    break;
                case 4:
                    sb.Append("one thousand");
                    break;
            }

            return sb.ToString();
        }

        public string Run()
        {
            var numbers = new List<string>();
            for (var i = 1; i <= 1000; i++) numbers.Add(this.NumberToString(i));

            var sum = 0;
            foreach (var number in numbers)
            {
                var chars = new Regex("[a-zA-Z]").Matches(number);
                sum += chars.Count;
            }

            return sum.ToString();
        }
    }
}
