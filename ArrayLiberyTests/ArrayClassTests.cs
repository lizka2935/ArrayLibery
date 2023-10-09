using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArrayLibery;

namespace ArrayLiberyTests
{
    [TestClass]
    public class ArrayClassTests
    {
        [TestMethod]
        public void ArrayString_NinusSeven_ReturnMinusSeven()
        {
            //Arrange
            int[] number = { 1, 3, 5, 2, 6, 9, 2, 0, -7, 3 };
            int exe = -7;
            //Act
            ArrayClass obj = new ArrayClass();
            double actual = obj.ArrayString(number);
            //Assertt
            Assert.AreEqual(exe, actual);
        }

        [TestMethod]
        public void ArrayString_Zero_ReturnZero()
        {
            //Arrange
            int[] number = { 1, 3, 5, 2, 6, -9, -2, 0, 7, 3 };
            int exe = 18;
            //Act
            ArrayClass obj = new ArrayClass();
            double actual = obj.ArrayString(number);
            //Assertt
            Assert.AreEqual(exe, actual);
        }

    }


    
}
