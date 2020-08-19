using Microsoft.VisualStudio.TestTools.UnitTesting;
using BTCN_186000187;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTCN_186000187.Tests
{
    [TestClass()]
    public class BT01Tests
    {
        [TestMethod()]
        public void Testcase01()
        {
            BT01 n = new BT01();
            bool result = n.Sn_BT01(-1000000000000);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void Testcase02()
        {
            BT01 n = new BT01();
            bool result = n.Sn_BT01(20);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void Testcase03()
        {
            BT01 n = new BT01();
            bool result = n.Sn_BT01(9999);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void Testcase04()
        {
            BT01 n = new BT01();
            bool result = n.Sn_BT01(10000000);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void Testcase05()
        {
            BT01 n = new BT01();
            bool result = n.Sn_BT01(1000000000000);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void Testcase06()
        {
            BT01 n = new BT01();
            bool result = n.Sn_BT01(-3000);
            Assert.IsTrue(result);
        }
    }
}