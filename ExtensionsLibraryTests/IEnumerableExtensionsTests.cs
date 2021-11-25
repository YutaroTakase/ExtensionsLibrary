using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary.Tests
{
    [TestClass()]
    public class IEnumerableExtensionsTests
    {
        [TestMethod()]
        public void ToDistinctDictionaryTest()
        {
            var list = new List<TestObject>()
            {
                new TestObject() { Id = 1, Value = "value" },
                new TestObject() { Id = 1, Value = "value" },
                new TestObject() { Id = 2, Value = "value" }
            };

            var result = list.ToDistinctDictionary(x => x.Id);
            Assert.AreEqual(2, result.Count);
            CollectionAssert.AreEqual(list.Select(x => x.Id).Distinct().ToList(), result.Keys);
        }

        [TestMethod()]
        public void ToDistinctDictionaryTest1()
        {
            var list = new List<TestObject>()
            {
                new TestObject() { Id = 1, Value = "value" },
                new TestObject() { Id = 1, Value = "value" },
                new TestObject() { Id = 2, Value = "value" }
            };

            var result = list.ToDistinctDictionary(x => x.Id, x => x.Value);
            Assert.AreEqual(2, result.Count);
            CollectionAssert.AreEqual(list.Select(x => x.Id).Distinct().ToList(), result.Keys);
            CollectionAssert.AreEqual(list.ToDistinctDictionary(x => x.Id).Select(x => x.Value.Value).ToList(), result.Values);
        }

        private class TestObject
        {
            public int Id { get; set; }
            public string Value { get; set; } = "";
        }
    }
}