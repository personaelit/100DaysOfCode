using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod, Description("Asserts object instantiation with a default constructor.")]
        public void CalcTest()
        {
            //NOTE: Some questions about necessity. 
            Assert.IsNotNull(new Calc());
        }

        //NOTE: this is a faulty test, but I am going to come back to that later.
        [TestMethod, Description("Asserts addition increases value.")]
        public void Calc_Add_Test()
        {
            //Arrange
            var calc = new Calc();
            //Act
            var result = calc.Add(2m, 2m);
            //Assert
            Assert.IsTrue(result > 2m);

        }


    }
}