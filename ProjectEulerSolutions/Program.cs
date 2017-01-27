using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions
{
    using ProjectEulerSolutions._001;
    using ProjectEulerSolutions._002;
    using ProjectEulerSolutions._003;
    using ProjectEulerSolutions._004;
    using ProjectEulerSolutions._005;
    using ProjectEulerSolutions._006;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Problem6().Run());
            Console.ReadKey();
        }
    }

}
