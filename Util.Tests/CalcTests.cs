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

        [TestMethod, Description("Asserts multipication changes the value.")]
        public void Calc_MultipicationNonZero_Test()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator("2.2*100");
            Calc calc = new Calc(expressionEvaluator);
            //act
            decimal result = calc.PerformCalulation();
            //assert
            Assert.AreNotEqual(expressionEvaluator.Left, result, "The result is the same as the left input.");
        }

        [TestMethod, Description("Asserts that multiplying by 0 returns 0.")]
        public void Calc_MultipicationZero_Test()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator("2.2*0");
            Calc calc = new Calc(expressionEvaluator);
            //act
            decimal result = calc.PerformCalulation();
            //assert
            Assert.IsTrue(result ==0, "The result is not 0.");
        }

        [TestMethod, Description("Asserts that dividing by 0 returns an error.")]
        public void Calc_DivideByZero_Test()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator("3/0");
            Calc calc = new Calc(expressionEvaluator);
            //act
            //assert
            Assert.ThrowsException<DivideByZeroException>(()=>calc.PerformCalulation());
        }

    }
}