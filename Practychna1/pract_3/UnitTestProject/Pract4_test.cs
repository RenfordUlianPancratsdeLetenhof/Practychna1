using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practychna1.pract4;

namespace Practychna1.pract4.Tests
{
    [TestClass]
    public class IntArrayTests
    {
        [TestMethod]
        public void Calculation_ReturnsCorrectUniqueCount()
        {
            // Arrange
            int[] inputArray = { 4, 3, 5, 1, 2, 1, 5 };
            IntArray intArray = new IntArray(inputArray.Length);

            // Act
            intArray.a = inputArray;
            int uniqueCount = intArray.calculation();

            // Assert
            Assert.AreEqual(5, uniqueCount); 
        }

        [TestMethod]
        public void Calculation_ReturnsZeroForEmptyArray()
        {
            // Arrange
            IntArray intArray = new IntArray(0);

            // Act
            int uniqueCount = intArray.calculation();

            // Assert
            Assert.AreEqual(0, uniqueCount); 
        }

        
    }
}