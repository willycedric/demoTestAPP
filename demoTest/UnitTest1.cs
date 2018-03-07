using System;
using NUnit.Framework;

namespace demoTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestValuesEquals()
        {
            Assert.AreEqual(1, 1);
        }

        [TestCase]
        public void TestValuesAreNotEqual()
        {
            Assert.AreNotEqual(1, 2);
        }
    }
}
