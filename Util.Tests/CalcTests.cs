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
        [TestMethod, Description("Asserts object instantiation with two decimal params.")]
        public void CalcTest()
        {
            //arrange
            Calc calc;
            //act
            calc = new Calc(2m, 2m);
            //assert
            Assert.IsNotNull(calc);
        }

        [TestMethod, Description("Asserts addition changes the value.")]
        public void Calc_Add_Test()
        {
            //arrange
            var calc = new Calc(2m, 2m);
            //act
            var result = calc.Add();
            //assert
            Assert.AreNotEqual(2m, result);
        }
    }
}