using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDataStructure.Tests
{
    [TestClass()]
    public class MyArrayListTests
    {
        [TestMethod()]
        public void Append_SingleElement_ShouldAddToEnd()
        {
            // Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Append(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void Append_MultipleElements_ShouldAddToEnd()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Append(4);
            list.Append(1);
            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[1], 1);
        }

        [TestMethod()]
        public void Append_AddMoreElementsThanSizeAllows_ShouldAddToEnd()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Append(4);
            list.Append(1);
            list.Append(7);
            list.Append(1);
            list.Append(8);
            list.Append(0);
            list.Append(9);
            list.Append(41);
            list.Append(70);
            list.Append(91);
            list.Append(32);
            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[list.Size - 1], 32);
        }

        [TestMethod()]
        public void AddStart_ListIsEmpty_ShouldAddToStart()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.AddStart(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void AddStart_ListHasValues_ShouldAddToStart()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            list.Append(10);
            list.Append(5);
            // Act
            list.AddStart(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void Insert_ListIsEmpty_ShouldAddToStart()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Insert(5, 0);
            // Assert
            Assert.AreEqual(5, list.List[0]);
        }

        [TestMethod()]
        public void Insert_ListIsEmptyIndexIsValid_ShouldThroeException()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            // Act
           
            // Assert
            Assert.ThrowsException<IndexOutOfRangeException>(
                () => list.Insert(5, 2),
                "Index is invalid");
        }

        [TestMethod()]
        public void Insert_ListHasValues_ShouldInsertAtCorrectPosition()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            list.Append(5);
            list.Append(3);
            list.Append(2);
            // Act
            list.Insert(8, 1);

            // Assert
            Assert.AreEqual(5, list.List[0]);
            Assert.AreEqual(8, list.List[1]);
            Assert.AreEqual(3, list.List[2]);
        }

        [TestMethod()]
        public void DeleteStart_ListHasValue_ShouldDeleteFirstElement()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            list.Append(5);
            list.Append(3);
            list.Append(2);

            // Act
            list.DeleteStart();

            // Assert
            Assert.AreEqual(3, list.List[0]);
            Assert.AreEqual(2, list.List[1]);
            Assert.AreEqual(0, list.List[2]);
            Assert.IsTrue(list.Size == 2);
        }

        [TestMethod()]
        public void DeleteStart_ListIsFull_ShouldDeleteFirstElement()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>(3);
            list.Append(5);
            list.Append(3);
            list.Append(2);

            // Act
            list.DeleteStart();

            // Assert
            Assert.AreEqual(3, list.List[0]);
            Assert.AreEqual(2, list.List[1]);
            Assert.AreEqual(0, list.List[2]);
            Assert.IsTrue(list.Size == 2);
        }

        [TestMethod()]
        public void DeleteEnd_ListHasValue_ShouldDeleteFromEnd()
        {
			// Arrange
			MyArrayList<int> list = new MyArrayList<int>();
            list.Append(5);
            list.Append(3);
            list.Append(2);

            // Act
            list.DeleteEnd();

            // Assert
            Assert.IsTrue(list.Size == 2);
            Assert.AreEqual(5, list.List[0]);
            Assert.AreEqual(3, list.List[1]);
            Assert.AreEqual(0, list.List[2]);
        }
    }
}