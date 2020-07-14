using NUnit.Framework;
using System;

namespace HammingDistance
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(8, Program.FindHammingDistance("helloworld", "worldhello"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(10, Program.FindHammingDistance("", "worldhello"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(10, Program.FindHammingDistance("helloworld", ""));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(0, Program.FindHammingDistance("", ""));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(6, Program.FindHammingDistance("1!1!1!", "2@2@2@"));
        }

        [Test]
        public void Test6()
        {
            Assert.Throws<ArgumentException>(() => Program.FindHammingDistance("helloworl", "worldhello"));
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(0, Program.FindHammingDistance("hello", "hello"));
        }

    }
}