using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace NUnitTests
{
    public class Class1
    {
        double x = 6;
        double y = 4;
        [Test]
        public void Test1()
        {
            double xy = x + y;
            Assert.AreEqual(nunit.NUnitTest.sum(x, y), xy);
        }
        [Test]
        public void Test2()
        {
            double xy = x - y;
            Assert.AreEqual(nunit.NUnitTest.sub(x, y), xy);
        }
        [Test]
        public void Test3()
        {
            double xy = x * y;
            Assert.AreEqual(nunit.NUnitTest.mul(x, y), xy);
        }
        [Test]
        public void Test4()
        {
            double xy = x / y;
            Assert.AreEqual(nunit.NUnitTest.div(x, y), xy);
        }

    }
}
