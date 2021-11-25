using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsLibrary.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            var value = "";
            Assert.IsTrue(value.IsNullOrEmpty());

            value = "value";
            Assert.IsFalse(value.IsNullOrEmpty());
        }

        [TestMethod()]
        public void IsNullOrWhiteSpaceTest()
        {
            var value = "";
            Assert.IsTrue(value.IsNullOrWhiteSpace());

            value = " ";
            Assert.IsTrue(value.IsNullOrWhiteSpace());

            value = "　";
            Assert.IsTrue(value.IsNullOrWhiteSpace());

            value = "value";
            Assert.IsFalse(value.IsNullOrWhiteSpace());
        }

        [TestMethod()]
        public void ToIntTest()
        {
            var value = "1";
            Assert.AreEqual(1, value.ToInt());
        }

        [TestMethod()]
        public void ToIntOrDefaultTest()
        {
            var value = "";
            Assert.AreEqual(0, value.ToIntOrDefault());

            value = "";
            Assert.AreEqual(10, value.ToIntOrDefault(10));

            value = "1";
            Assert.AreEqual(1, value.ToIntOrDefault());
        }

        [TestMethod()]
        public void ToIntOrNullTest()
        {
            var value = "";
            Assert.AreEqual(null, value.ToIntOrNull());

            value = "1";
            Assert.AreEqual(1, value.ToIntOrNull());
        }
    }
}