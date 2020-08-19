using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT02;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT02.Tests
{
    [TestClass()]
    public class BT02Tests
    {
        [TestMethod]
        public void Testcase01()
        {
            BT02 n = new BT02();
            bool result = n.UCLN(8, 9);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase02()
        {
            BT02 n = new BT02();
            bool result = n.UCLN(-10, 9);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase03()
        {
            BT02 n = new BT02();
            bool result = n.UCLN(6,10);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase04()
        {
            BT02 n = new BT02();
            bool result = n.UCLN(-110, 1);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase05()
        {
            BT02 n = new BT02();
            bool result = n.UCLN(30, 5);
            Assert.IsTrue(result);
        }
    }
}