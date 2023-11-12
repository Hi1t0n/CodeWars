using System;
using NUnit.Framework;

namespace Sum_a_list_but_ignore_and_duplicates
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] arrData = { 1, 1, 2, 3 };
            int result = Kata.SumNoDuplicates(arrData);
            int exResult = 5;
            Assert.AreEqual(result,exResult);
        }

        [Test]
        public void Test2()
        {
            int[] arrData = { 1, 1, 2, 2, 3 };
            int result = Kata.SumNoDuplicates(arrData);
            int exResult = 3;
            Assert.AreEqual(result,exResult);
        }

        [Test]
        public void Test3()
        {
            int[] arrData = { 3, 4, 3, 6 };
            int result = Kata.SumNoDuplicates(arrData);
            int exResult = 10;
            Assert.AreEqual(result, exResult);
        }

        [Test]
        public void Test4()
        {
            int[] arrData = { 10, 10, 1, 4, 10, 3, 9, 6, 10, 10, 9, 9, 10, 5, 6, 10, 4, 1 };
            int result = Kata.SumNoDuplicates(arrData);
            int exResult = 8;
            Assert.AreEqual(result,exResult);
        }
    }
}