using NUnit.Framework;

namespace Detected_Pangram.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string data = "AbCdEfGhIjKlM zYxWvUtSrQpOn";
            Assert.AreEqual(true,Kata.IsPangram(data));
        }

        [Test]
        public void Test2()
        {
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.AreEqual(false,Kata.IsPangram(data));
        }

        [Test]
        public void Test3()
        {
            string data = "";
            Assert.AreEqual(false,Kata.IsPangram(data));
        }
    }
}