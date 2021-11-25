using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsLibrary.Tests
{
    [TestClass()]
    public class IListExtensionsTests
    {
        [TestMethod()]
        public void ContainsIndexTest()
        {
            var array = new int[] { 1, 1 };

            Assert.IsTrue(array.ContainsIndex(0));
            Assert.IsTrue(array.ContainsIndex(1));
            Assert.IsFalse(array.ContainsIndex(2));
        }
    }
}