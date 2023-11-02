using System;
using NUnit.Framework;

namespace Persistent_Bugger.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Persistence_39()
        {
            int value = 39;
            long result = Persist.Persistence(value);
            long exResult = 3;
            Assert.AreEqual(result, exResult);
        }
        [Test]
        public void Persistence_4()
        {
            int value = 4;
            long result = Persist.Persistence(value);
            long exResult = 0;
            Assert.AreEqual(result, exResult);
        }
        [Test]
        public void Persistence_25()
        {
            int value = 25;
            long result = Persist.Persistence(value);
            long exResult = 2;
            Assert.AreEqual(result, exResult);
        }
        [Test]
        public void Persistence_999()
        {
            int value = 999;
            long result = Persist.Persistence(value);
            long exResult = 4;
            Assert.AreEqual(result, exResult);
        }

        [Test]
        public void Persistence_1234()
        {
            int value = 1234;
            long result = Persist.Persistence(value);
            long exResult = 2;
            Assert.AreEqual(result,exResult);
        }
        
        [Test]
        public void Persistence_5678()
        {
            int value = 5678;
            long result = Persist.Persistence(value);
            long exResult = 2;
            Assert.AreEqual(result,exResult);
        }
        
        [Test]
        public void Persistence_1111()
        {
            int value = 1111;
            long result = Persist.Persistence(value);
            long exResult = 1;
            Assert.AreEqual(result,exResult);
        }
        
        [Test]
        public void Persistence_987654()
        {
            int value = 987654;
            long result = Persist.Persistence(value);
            long exResult = 2;
            Assert.AreEqual(result,exResult);
        }
    }
}