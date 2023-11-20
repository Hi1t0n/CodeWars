using System;
using NUnit.Framework;

namespace Sum_of_angles.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Sum_of_angles_3()
        {
            int data = 3;
            int exResult = 180;
            Assert.AreEqual(exResult,Kata.Angle(data));
        }

        [Test]
        public void Sum_of_angles_4()
        {
            int data = 4;
            int exresult = 360;
            Assert.AreEqual(exresult,Kata.Angle(data));
        }
        
        [Test]
        public void Sum_of_angles_5()
        {
            int data = 5;
            int exresult = 540;
            Assert.AreEqual(exresult,Kata.Angle(data));
        }
    }
}