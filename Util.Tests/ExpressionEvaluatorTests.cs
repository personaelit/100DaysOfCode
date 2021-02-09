using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util;
using static Util.ExpressionEvaluator;
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
            Assert.ThrowsException<ArgumentException>(() =>
                 expressionEvaluator = new ExpressionEvaluator("invalid string"));
        }

        [TestMethod, Description("Asserts that a formatted expression has no spaces.")]
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

        [TestMethod, Description("Asserts that an expression containg a '+' returns the Calc.Opertations.Add")]
        public void EE_Test_ExpressionsWithPlusReturnsEnumAdd()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act
            expressionEvaluator = new ExpressionEvaluator("2+2");
            //assert
            Assert.IsTrue(expressionEvaluator.Operation == Operations.Add);
        }

        [TestMethod, Description("Asserts that an expression containg a '-' returns the Calc.Opertations.Subtract")]
        public void EE_Test_ExpressionsWithHyphenReturnsEnumSubtract()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act
            expressionEvaluator = new ExpressionEvaluator("2-2");
            //assert
            Assert.IsTrue(expressionEvaluator.Operation == Operations.Subtract);
        }

        [TestMethod, Description("Asserts that an expression containg a '*' returns the Calc.Opertations.Multiply")]
        public void EE_Test_ExpressionsWithAsteriskReturnsEnumMultiply()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act
            expressionEvaluator = new ExpressionEvaluator("2*2");
            //assert
            Assert.IsTrue(expressionEvaluator.Operation == Operations.Multipy);
        }

        [TestMethod, Description("Asserts that an expression containg a '/' returns the Calc.Opertations.Multiply")]
        public void EE_Test_ExpressionsWithForwardSlashReturnsEnumDivide()
        {
            //arrange
            ExpressionEvaluator expressionEvaluator;
            //act
            expressionEvaluator = new ExpressionEvaluator("2/2");
            //assert
            Assert.IsTrue(expressionEvaluator.Operation == Operations.Divide);
        }

        [TestMethod, Description("Asserts that the left operand can be assigned.")]
        public void EE_Text_LeftOperandAssignment()
        {
            //arrange
            IExpressionEvaluator evaluator;
            //act
            evaluator = new ExpressionEvaluator("2+2");
            //assert
            evaluator.Left = 2m;
        }
    }
}