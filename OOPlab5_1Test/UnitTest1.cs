using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOPlab5;
using OOPlab5._1;

namespace OOPlab5_1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Time time = new Time(2, 30);
            Assert.AreEqual(time.Minutes(), 150);
        }
    }
}
