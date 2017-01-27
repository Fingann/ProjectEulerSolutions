using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsLib.String
{
    static public class StringExtentions
    {

        public static bool IsInteger(this string value)
        {
            int number;
            return int.TryParse(value, out number);
        }
    }
}
