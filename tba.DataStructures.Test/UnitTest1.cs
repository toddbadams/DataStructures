using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tba.DataStructures.Test
{
    [TestClass]
    public class HashUnitTest
    {
        [TestMethod]
        public void HashSetTest()
        {
            var foo = new HashExample(10000);

            Assert.IsNotNull(foo);
        }
    }
}
