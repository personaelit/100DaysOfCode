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
        [TestMethod, Description("Asserts object instantiation with IExpressionEvaluator param.")]
        public void Calc_Constructor_Test()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator("2+2");
            //act
            Calc calc = new Calc(expressionEvaluator);
            //assert
            Assert.IsNotNull(calc);
        }

        [TestMethod, Description("Asserts calculation changes the value.")]
        public void Calc_Add_Test()
        {
            //arrange
            Calc calc = new Calc(new ExpressionEvaluator("2.2*100"));
            //act
            calc.PerformCalulation();
            //assert
            //TODO: What do we do about indempotent operations???
            Assert.AreNotEqual(calc.Left, calc.Result, "");
        }
    }
}