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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Problem4().Run());
            Console.ReadKey();
        }
    }

}
