using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Categorize_New_Member.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[][] data = { new int[] { 45, 12 }, new int[] { 55, 21 }, new int[] { 19, 2 }, new int[] { 104, 20 } };
            List<string> exResult = new List<string>() { "Open", "Senior", "Open", "Senior" };

            List<string> result = Kata.OpenOrSenior(data).ToList();
            Assert.AreEqual(exResult,result);
        }

        [Test]
        public void Test2()
        {
            int[][] data = { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } };
            List<string> exResult = new List<string>() { "Open", "Open", "Open", "Open" };
            List<string> result = Kata.OpenOrSenior(data).ToList();
            Assert.AreEqual(exResult,result);
        }

        [Test]
        public void Test3()
        {
            int[][] data = { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } };
            List<string> exResult = new List<string>() { "Senior", "Open", "Open", "Open" };
            List<string> result = Kata.OpenOrSenior(data).ToList();
            Assert.AreEqual(exResult,result);
        }
        
        [Test]
        public void Test4()
        {
            int[][] data = {new int[] { 45, 12 }};
            List<string> exResult = new List<string>() { "Open" };
            List<string> result = Kata.OpenOrSenior(data).ToList();
            Assert.AreEqual(exResult,result);
        }
    }
}