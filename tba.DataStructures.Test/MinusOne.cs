using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tba.DataStructures.UnitTest
{
    [TestClass]
    public class MinusOneUnitTest
    {
        private int[] array;
        private MinusOne minusOne;

        [TestInitialize]
        public void MinusOneTestInit()
        {
            array = new int[5] { 1, 2, 3, 4, 5 };
            minusOne = new MinusOne(array);
        }

        [TestMethod]
        public void MinusOneCanCreate()
        {
            // Assert
            Assert.IsNotNull(minusOne);
        }

        [TestMethod]
        public void MinusOneCanStoreArray()
        {
            // Assert
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], minusOne.Array[i]);
            }
        }

        [TestMethod]
        public void MinusOneCanCalculate()
        {
            // Arrange
            int[] expected = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                expected[i] = array[i]-1;
            }

            // Act
            minusOne.Calculate();

            // Arrange
            // Assert
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], minusOne.Array[i]);
            }
        }
    }
}
