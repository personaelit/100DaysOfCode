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
            ExpressionEvaluator expressionEvaluator;
            Assert.ThrowsException<Exception>(() =>
                 expressionEvaluator = new ExpressionEvaluator("invalid string"));
        }

    }
}