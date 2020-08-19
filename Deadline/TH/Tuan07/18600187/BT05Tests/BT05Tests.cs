using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT05;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT05.Tests
{
    [TestClass()]
    public class BT05Tests
    {
        [TestMethod()]
        public void TestCase01()
        {
            BT05 n = new BT05();
            bool result = n.BT05_KTtangdan(6);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void TestCase02()
        {
            BT05 n = new BT05();
            bool result = n.BT05_KTtangdan(123);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void TestCase03()
        {
            BT05 n = new BT05();
            bool result = n.BT05_KTtangdan(456);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void TestCase04()
        {
            BT05 n = new BT05();
            bool result = n.BT05_KTtangdan(5423);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void TestCase05()
        {
            BT05 n = new BT05();
            bool result = n.BT05_KTtangdan(-10000000000);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void TestCase06()
        {
            BT05 n = new BT05();
            bool result = n.BT05_KTtangdan(10000000000);
            Assert.IsTrue(result);
        }
    }
}