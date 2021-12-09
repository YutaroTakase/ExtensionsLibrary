using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsLibrary.Tests;

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

        list1 = Array.Empty<int>();
        Assert.IsTrue(list1.IsNullOrEmpty());

        list1 = null;
        Assert.IsTrue(list1!.IsNullOrEmpty());
    }
}
