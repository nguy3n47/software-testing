using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerfectNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectNumber.Tests
{
    [TestClass]
    public class PerfectNumberTests
    {
        [TestMethod]
        public void check_PNTest()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest1()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(28);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest2()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(496);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest3()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(8128);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest4()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(12);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest5()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(7);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest6()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(-10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest7()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(-6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest8()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(7);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest9()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void check_PNTest10()
        {
            PerfectNumber n = new PerfectNumber();
            bool result = n.check(3);
            Assert.IsTrue(result);
        }
    }
}
