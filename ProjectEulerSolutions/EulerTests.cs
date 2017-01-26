using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


           
namespace ProjectEulerSolutions
{
    using ProjectEulerSolutions._001;
    using ProjectEulerSolutions._002;
    using ProjectEulerSolutions._003;

    [TestFixture]
    class EulerTests
    {
        private IEulerSolution EulerSolution;

        [Test]
        public void Test001() => Assert.AreEqual("233168", new Problem1().Run());
        [Test]
        public void Test002() => Assert.AreEqual("4613732", new Problem2().Run());
        [Test]
        public void Test003() => Assert.AreEqual("6857", new Problem3().Run());

    }
}
