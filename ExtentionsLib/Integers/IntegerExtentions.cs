using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsLib.Integers
{
    public static class IntegerExtentions
    {

        public static bool IsOdd(this long value) => value % 2 != 0;

        public static bool IsEven(this long value) => value % 2 == 0;

        public static bool IsOdd(this int value) => value % 2 != 0;

        public static bool IsEven(this int value) => value % 2 == 0;

        public static IEnumerable<long> Range(this long source, long length)
        {
            for (long i = source; i < length; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> Range(this int source, long length)
        {
            for (int i = source; i < length; i++)
            {
                yield return i;
            }
        }
    }
}
