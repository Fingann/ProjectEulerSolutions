namespace ProjectEulerSolutions._022
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Problem22 : IEulerSolution
    {
        private readonly Func<string, int, Tuple<string, long>> SumNameValue =
            (a, b) =>
                {
                    long nameScore = Encoding.ASCII.GetBytes(a.ToCharArray())
                                   .Select(x => int.Parse(x.ToString()) - 64)
                                   .Aggregate((i, j) => i + j) * (b + 1);

                    return new Tuple<string, long>(a, nameScore);
                };

        public string Run()
        {
            //b is index
            var nameScores = this.SortNames()
                .Select((a, b) => this.SumNameValue(a, b));

            var sum = nameScores
                .Select(x=> x.Item2)
                .Aggregate((a, b) => a + b);

            return sum.ToString();
        }

        public IEnumerable<string> SortNames()
        {
            var text = string.Empty;

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ProjectEulerSolutions._022.p022_names.txt";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
            }

            // Sorting the names
            return Regex.Matches(text, "\\w+").Cast<Match>().Select(match => match.Value).OrderBy(x => x);
        }
    }
}