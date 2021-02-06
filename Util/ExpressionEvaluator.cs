using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Util
{
    public class ExpressionEvaluator
    {
        string _expression;

        public string FormattedExpression { get; private set; }

        public ExpressionEvaluator(string expression)
        { 
            _expression = expression;
            Format();
            Validate();
        }

        private void Format()
        {
            _expression = _expression.Replace(" ", "");
            FormattedExpression = _expression;
        }

        /// <summary>
        /// Validates the epression. For the sake of this exercise a valid expression matches:
        /// [number][+|-|*|/][number]
        /// </summary>
        private void Validate()
        {
            //CONSIDER: instead of throw, use a TryParse pattern.
            Regex regex = new Regex(@"\d*[+-/*]\d*");
            if (!regex.Match(_expression, 0, _expression.Length).Success)
            {
                throw new ArgumentException($"The expression \"{_expression}\" is not valid.");
            }
        }

        private void Tokenizer()
        {
            for(int i = 0; i<_expression.Length; i++)
            {

            }
        }
    }
}
