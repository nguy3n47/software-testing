using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT03;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT03.Tests
{
    [TestClass()]
    public class BT03Tests
    {
        [TestMethod]
        public void Testcase01()
        {
            BT03 n = new BT03();
            bool result = n.BT03CN2muk(16);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase02()
        {
            BT03 n = new BT03();
            bool result = n.BT03CN2muk(6);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase03()
        {
            BT03 n = new BT03();
            bool result = n.BT03CN2muk(-16);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase04()
        {
            BT03 n = new BT03();
            bool result = n.BT03CN2muk(17);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase05()
        {
            BT03 n = new BT03();
            bool result = n.BT03CN2muk(-36);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase06()
        {
            BT03 n = new BT03();
            bool result = n.BT03CN2muk(0);
            Assert.IsTrue(result);
        }
    }
}