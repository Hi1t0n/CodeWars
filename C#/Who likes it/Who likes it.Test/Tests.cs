using System;
using NUnit.Framework;

namespace Who_likes_it.Test
{
    [TestFixture]
    public class Tests
    {
        /*
         * case 0: return "no one likes this";
            case 1: return $"{name[0]} likes this";
            case 2: return $"{name[0]} and {name[1]} like this";
            case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
            default: return $"{name[0]}, {name[1]} and {name.Length - 2} other like this";
         */
        [Test]
        public void arrayLength0()
        {
            string[] name = new string[0];
            string res = Kata.Likes(name);
            string exResult = "no one likes this";
            Assert.AreEqual(res, exResult);
        }
        
        [Test]
        public void arrayLength1()
        {
            string[] name = new string[]{"Mike"};
            string res = Kata.Likes(name);
            string exResult = $"{name[0]} likes this";
            Assert.AreEqual(res, exResult);
        }
        
        [Test]
        public void arrayLength2()
        {
            string[] name = new string[]{"Mike","Nikita"};
            string res = Kata.Likes(name);
            string exResult = $"{name[0]} and {name[1]} like this";
            Assert.AreEqual(res, exResult);
        }
        
        [Test]
        public void arrayLength3()
        {
            string[] name = new string[]{"Mike","Nikita","Mikola"};
            string res = Kata.Likes(name);
            string exResult = $"{name[0]}, {name[1]} and {name[2]} like this";
            Assert.AreEqual(res, exResult);
        }
        
        [Test]
        public void arrayLength4()
        {
            string[] name = new string[]{"Mike","Nikita","Mikola","Andrey"};
            string res = Kata.Likes(name);
            string exResult = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            Assert.AreEqual(res, exResult);
        }
    }
}