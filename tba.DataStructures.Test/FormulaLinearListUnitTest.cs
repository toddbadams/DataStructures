using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tba.DataStructures.UnitTest
{
    [TestClass]
    public class FormulaLinearListUnitTest
    {
        private FormulaLinearList linearList;
        private const int maxSize = 10;

        [TestInitialize]
        public void FormulaLinearListInit()
        {
            this.linearList = new FormulaLinearList(maxSize);
        }

        [TestMethod]
        [Ignore]
        public void FormualLinearListCanCreate()
        {
            // Assert
            Assert.IsNotNull(this.linearList);
        }

        [TestMethod]
        [Ignore]
        public void FormulaLinearListIsEmpty()
        {
            // Assert
            Assert.IsTrue(this.linearList.IsEmpty);
        }

        [TestMethod]
        [Ignore]
        public void FormulaLinearListHasZeroLength()
        {
            // Assert
            Assert.AreEqual(0, this.linearList.Length);
        }

        [TestMethod]
        [Ignore]
        public void FormulaLinearListCanInsert()
        {
            // Act
            this.linearList.Insert(4);

            // Assert
            Assert.AreEqual(1, this.linearList.Length);
        }

        [TestMethod]
        [Ignore]
        public void FormulaLinearListCanFind()
        {
            //  Arrange
            int expected = 4;
            this.linearList.Insert(expected);

            // Act
            int result = this.linearList.Find(1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [Ignore]
        public void FormulaLinearListCanSearch()
        {
            //  Arrange
            int[] valuesToInsert = new int[5] { 1, 3, 5, 7, 9 };
            int valueToSearchIndex = 3;
            for(int i=0; i<valuesToInsert.Length; i++)
                this.linearList.Insert(valuesToInsert[i]);

            // Act
            int result = this.linearList.Search(valuesToInsert[valueToSearchIndex]);

            // Assert
            Assert.AreEqual(valueToSearchIndex, result);
        }

        [TestMethod]
        [Ignore]
        public void FormulaLinearListCanDelete()
        {
            //  Arrange
            int[] valuesToInsert = new int[5] { 1, 3, 5, 7, 9 };
            int valueToDeleteIndex = 3;
            for (int i = 0; i < valuesToInsert.Length; i++)
                this.linearList.Insert(valuesToInsert[i]);

            // Act
            this.linearList.Delete(valuesToInsert[valueToDeleteIndex]);

            // Assert
            Assert.AreEqual(valuesToInsert.Length - 1, this.linearList.Length);
        }


    }
}
