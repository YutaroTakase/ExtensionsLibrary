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

        [TestMethod()]
        public void ChunksTest()
        {
            var list1 = new int[] { 1, 2, 3 };
            var list2 = new int[] { 4, 5, 6 };
            var list3 = new int[] { 7, 8 };

            var chunks = list1.Concat(list2).Concat(list3).Chunks(3);
            CollectionAssert.AreEqual(list1, chunks.ElementAt(0).ToArray());
            CollectionAssert.AreEqual(list2, chunks.ElementAt(1).ToArray());
            CollectionAssert.AreEqual(list3, chunks.ElementAt(2).ToArray());
        }

        [TestMethod()]
        public void StringJoinTest()
        {
            var list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var list2 = string.Join(",", list1);

            var result = list1.StringJoin(",");

            Assert.AreEqual(list2, result);
        }

        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            var list1 = new int[] { 1 };
            Assert.IsFalse(list1.IsNullOrEmpty());

            list1 = new int[]{};
            Assert.IsTrue(list1.IsNullOrEmpty());

            list1 = null;
            Assert.IsTrue(list1!.IsNullOrEmpty());
        }
    }
}