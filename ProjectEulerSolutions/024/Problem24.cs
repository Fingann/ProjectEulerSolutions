using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions._024
{
    using System.Collections;
    using System.Security.Cryptography.X509Certificates;

    using ExtentionsLib.Math;

    class Problem24: IEulerSolution
    {
        

        public string Run()
        {
            List<int> digits = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> num = new List<int>() { 1, 2, 3};

            var query = digits.SelectMany(x => num, (x, y) => new { x, y, z });



            
           
            throw new NotImplementedException();
        }
    }
}
