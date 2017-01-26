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
    }
}
