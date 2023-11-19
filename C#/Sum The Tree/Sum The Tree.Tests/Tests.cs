using System;
using NUnit.Framework;

namespace Sum_The_Tree.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var data = new Node(10, new Node(1), new Node(2));
            var exResult = 13;
            Assert.AreEqual(exResult,Kata.SumTree(data));
        }

        [Test]
        public void Test2()
        {
            var data = new Node(10, new Node(1, null, new Node(15)),new Node(9,new Node(5,null,new Node(5))));
            var exResult = 45;
            Assert.AreEqual(exResult,Kata.SumTree(data));
        }
    }
}