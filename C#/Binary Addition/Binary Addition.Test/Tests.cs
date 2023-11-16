using System;
using NUnit.Framework;

namespace Binary_Addition.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_1_2()
        {
            int a = 1;
            int b = 2;
            string result = Kata.AddBinary(a, b);
            string exResult = "11";
            Assert.AreEqual(result,exResult);
        }

        [Test]
        public void Test_51_12()
        {
            int a = 51;
            int b = 12;
            string result = Kata.AddBinary(a, b);
            string exResult = "111111";
            Assert.AreEqual(result,exResult);
        }

        [Test]
        public void Test_100_0()
        {
            int a = 100;
            int b = 0;
            string result = Kata.AddBinary(a, b);
            string exResult = "1100100";
            Assert.AreEqual(result,exResult);
        }
    }
}