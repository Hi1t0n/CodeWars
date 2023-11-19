using System;
using NUnit.Framework;

namespace Unique_in_Order.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var data = "AABBAADD";
            var exResult = "ABAD";
            Assert.AreEqual(exResult,Kata.UniqueInOrder(data));
        }

        [Test]
        public void Test2()
        {
            var data = "";
            var exResult = "";
            Assert.AreEqual(exResult,Kata.UniqueInOrder(data));
        }
        
        [Test]
        public void Test3()
        {
            var data = "AaaaDDdBbC";
            var exResult = "AaDdBbC";
            Assert.AreEqual(exResult, Kata.UniqueInOrder(data));
        }

        [Test]
        public void Test4()
        {
            var data = "1122113344121BbAaaa";
            var exResult = "12134121BbAa";
            Assert.AreEqual(exResult, Kata.UniqueInOrder(data));
        }

        [Test]
        public void Test5()
        {
            int[] data = new int[] { 1, 1, 2, 2, 3, 3, 4 };
            var exResult = new int[] { 1, 2, 3, 4 };
            Assert.AreEqual(exResult,Kata.UniqueInOrder(data));
        }
    }
}


