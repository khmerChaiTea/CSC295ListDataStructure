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
            MyArrayList list = new MyArrayList();
            // Act
            list.Append(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void Append_MultipleElements_ShouldAddToEnd()
        {
            // Arrange
            MyArrayList list = new MyArrayList();
            // Act
            list.Append(4);
            list.Append(1);
            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[1], 1);
        }
    }
}