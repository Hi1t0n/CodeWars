using System;
using NUnit.Framework;

namespace Count_of_positives_sum_of_negatives.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] exResult = new int[] { 10, -65 };
            int[] data = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15};
            Assert.AreEqual(exResult,Kata.CountPositivesSumNegatives(data));
        }
        
        [Test]
        public void Test2()
        {
            int[] exResult = new int[] { 8, -50 };
            int[] data = new int[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14};
            Assert.AreEqual(exResult,Kata.CountPositivesSumNegatives(data));
        }
        
        [Test]
        public void Test3()
        {
            int[] exResult = new int[] { };
            int[] data = new int[0];
            Assert.AreEqual(exResult,Kata.CountPositivesSumNegatives(data));
        }
        
        [Test]
        public void Test4()
        {
            int[] exResult = new int[] { };
            int[] data = null;
            Assert.AreEqual(exResult,Kata.CountPositivesSumNegatives(data));
        }
    }
}