using System;
using NUnit.Framework;

namespace Sum_Strings_as_Numbers.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_127_256_return_383()
        {
            string a = "127";
            string b = "256";
            string exResult = "383";
            Assert.AreEqual(exResult,Kata.sumStrings(a,b));
        }
        
        [Test]
        public void Test_456654456_3213214321412_return_3213670975868()
        {
            string a = "456654456";
            string b = "3213214321412";
            string exResult = "3213670975868";
            Assert.AreEqual(exResult,Kata.sumStrings(a,b));
        }

        [Test]
        public void Test_Empty_5_return_5()
        {
            string a = "";
            string b = "5";
            string exResult = "5";
            Assert.AreEqual(exResult,Kata.sumStrings(a,b));
        }
    }
}