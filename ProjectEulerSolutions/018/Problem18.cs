using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._018
{
    using ExtentionsLib.String;

    class Problem18: IEulerSolution
    {
        public string triangle2 = @"3
7 4
2 4 6
8 5 9 3";

        public string triangle = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

        public string Run()
        {
            var list = this.CreateList();
            return this.FindMaximumPath(list).ToString();
            
        }

        public int FindMaximumPath(List<List<int>> list)
        {
            var templist = list;
            var bottomRow = list.Count;
            var currentRow = bottomRow - 2;
            
            while (currentRow != 0)
            {
                var NumbersOnRow = list[currentRow].Count -1;
                
                for (var i = 0; i <= NumbersOnRow; i++)
                {
                    templist[currentRow][i] = Math.Max(
                        list[currentRow + 1][i + 1] + templist[currentRow][i],
                        list[currentRow + 1][i] + templist[currentRow][i]);
                }
                ;
                currentRow--;
            }

            return templist[0][0] + Math.Max(templist[1][0], templist[1][1]);
        }


        public int IterateListGreedy(List<List<int>> list)
        {
            
            var topNumber = list[0][0];
            var sum = topNumber;
            var count = 1;
            var currentPossision = 0;

            while (count != list.Count)
            {
                if (sum + list[count][currentPossision] > sum + list[count][currentPossision + 1])
                {
                    sum += list[count][currentPossision];
                }
                else
                {
                    sum += list[count][currentPossision + 1];
                    currentPossision++;
                }

                count++;
            }
                


            return sum;
        }


        public List<List<int>> CreateList()
        {
            var digits = triangle.

                // split string into rows
                Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Select(
                    line =>

                            // split row into columns
                            line.Split(' ')

                                // ignore any whitespace
                                .Where(token => token.IsInteger())

                                // convert string to number
                                .Select(token => int.Parse(token)).ToList()).ToList();
            return digits;
        }
    }
}
