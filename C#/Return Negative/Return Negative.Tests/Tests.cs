using System;
using NUnit.Framework;

namespace Return_Negative.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int data = 1;
            int exResult = -1;
            Assert.AreEqual(exResult,Kata.MakeNegative(data));
        }
        
        [Test]
        public void Test2()
        {
            int data = 0;
            int exResult = 0;
            Assert.AreEqual(exResult,Kata.MakeNegative(data));
        }
        
        [Test]
        public void Test3()
        {
            int data = -2141;
            int exResult = -2141;
            Assert.AreEqual(exResult,Kata.MakeNegative(data));
        }
        
        [Test]
        public void Test4()
        {
            int data = 835980354;
            int exResult = -835980354;
            Assert.AreEqual(exResult,Kata.MakeNegative(data));
        }
    }
}