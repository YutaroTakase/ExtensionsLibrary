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
    }
}