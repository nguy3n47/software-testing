using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT04;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT04.Tests
{
    [TestClass()]
    public class BT04Tests
    {
        
        [TestMethod]
        public void Testcase01()
        {
            BT04 n = new BT04();
            bool result = n.SNT(-10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Testcase02()
        {
            BT04 n = new BT04();
            bool result = n.SNT(5);
            Assert.IsTrue(result);
        }

        

        [TestMethod]
        public void Testcase03()
        {
            BT04 n = new BT04();
            bool result = n.SNT(20);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Testcase04()
        {
            BT04 n = new BT04();
            bool result = n.SNT(-56);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Testcase05()
        {
            BT04 n = new BT04();
            bool result = n.SNT(0);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Testcase06()
        {
            BT04 n = new BT04();
            bool result = n.SNT(1);
            Assert.IsTrue(result);
        }
    }
}