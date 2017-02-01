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
    using ProjectEulerSolutions._004;
    using ProjectEulerSolutions._005;
    using ProjectEulerSolutions._006;
    using ProjectEulerSolutions._007;
    using ProjectEulerSolutions._008;
    using ProjectEulerSolutions._010;
    using ProjectEulerSolutions._011;
    using ProjectEulerSolutions._012;
    using ProjectEulerSolutions._013;
    using ProjectEulerSolutions._014;
    using ProjectEulerSolutions._015;
    using ProjectEulerSolutions._016;
    using ProjectEulerSolutions._017;
    using ProjectEulerSolutions._018;
    using ProjectEulerSolutions._020;
    using ProjectEulerSolutions._021;

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
        [Test]
        public void Test004() => Assert.AreEqual("906609", new Problem4().Run());
        [Test]
        public void Test005() => Assert.AreEqual("232792560", new Problem5().Run());
        [Test]
        public void Test006() => Assert.AreEqual("25164150", new Problem6().Run());
        [Test]
        public void Test007() => Assert.AreEqual("104743", new Problem7().Run());
        [Test]
        public void Test008() => Assert.AreEqual("23514624000", new Problem8().Run());
        [Test]
        public void Test010() => Assert.AreEqual("142913828922", new Problem10().Run());
        [Test]
        public void Test011() => Assert.AreEqual("70600674", new Problem11().Run());
        [Test]
        public void Test012() => Assert.AreEqual("76576500", new Problem12().Run());
        [Test]
        public void Test013() => Assert.AreEqual("5537376230", new Problem13().Run());
        [Test]
        public void Test014() => Assert.AreEqual("837799", new Problem14().Run());
        [Test]
        public void Test015() => Assert.AreEqual("137846528820", new Problem15().Run());
        [Test]
        public void Test016() => Assert.AreEqual("1366", new Problem16().Run());
        [Test]
        public void Test017() => Assert.AreEqual("21124", new Problem17().Run());
        [Test]
        public void Test018() => Assert.AreEqual("1074", new Problem18().Run());
        [Test]
        public void Test020() => Assert.AreEqual("648", new Problem20().Run());
        [Test]
        public void Test021() => Assert.AreEqual("31626", new Problem21().Run());
        [Test]
        public void Test022() => Assert.AreEqual("871198282", new Problem21().Run());
    }
}
