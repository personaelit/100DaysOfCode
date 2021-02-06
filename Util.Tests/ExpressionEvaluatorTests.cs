using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Util.Tests
{
    [TestClass()]
    public class ExpressionEvaluatorTests
    {
        [TestMethod, Description("Asserts that ExpressionEvaluator can be instantiated with a string param.")]
        public void ExpressionEvaluatorTest()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act
            expressionEvaluator = new ExpressionEvaluator("this is a string.");
            //assert
            Assert.IsNotNull(expressionEvaluator);
        }

        [TestMethod, Description("Asserts that ExpressionEvaluator throws an exception when string is not a valid expression.")]
        public void EE_Test_ThrowOnInvalidString()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act and assert
            Assert.ThrowsException<Exception>(() =>
                 expressionEvaluator = new ExpressionEvaluator("invalid string"));
        }

        [TestMethod, Description("Asserts that a formated expression has no spaces.")]
        public void EE_Test_FormatHasNoSpaces()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act
            string validExpressionWithSpaces = "2 + 2";
            expressionEvaluator = new ExpressionEvaluator(validExpressionWithSpaces);
            //assert
            Assert.IsFalse(expressionEvaluator.FormattedExpression.Contains(" "));
        }
    }
}