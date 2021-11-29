using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace ExtensionsLibrary.Tests
{
    [TestClass()]
    public class ObjectExtensionsTests
    {
        [TestMethod()]
        public void DeepCopyTest()
        {
            var object1 = new 
            {
                name = "name",
                value = 12
            };

            var object2 = object1.DeepCopy<object>();

            Assert.AreEqual(JsonSerializer.Serialize(object1), JsonSerializer.Serialize(object2));
        }
    }
}