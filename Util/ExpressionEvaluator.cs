using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Util
{
    public class ExpressionEvaluator : IExpressionEvaluator
    {
        public enum Operations { Add, Subtract, Multipy, Divide }

        string _expression;

        public string FormattedExpression { get; private set; }

        public bool IsValidExpression { get; private set; }

        public Operations Operation { get; private set;}

        public ExpressionEvaluator(string expression)
        { 
            _expression = expression;
            //WARNING: Straightline code.
            format();
            validate();
            //TODO: Tokenize here
            setOperator();
        }

        private void setOperator()
        {
            //QUICK HACK: string.contains.
            //TODO: Use the tokens.
            if (_expression.Contains("+"))  Operation = Operations.Add;
            if (_expression.Contains("-")) Operation = Operations.Subtract;
            if (_expression.Contains("*")) Operation = Operations.Multipy;
            if (_expression.Contains("/")) Operation = Operations.Divide;

        }

        private void format()
        {
            _expression = _expression.Replace(" ", "");
            FormattedExpression = _expression;
        }

        /// <summary>
        /// Validates the epression. For the sake of this exercise a valid expression matches:
        /// [number][+|-|*|/][number]
        /// </summary>
        private void validate()
        {
            //CONSIDER: instead of throw, use a TryParse pattern.
            Regex regex = new Regex(@"\d*[+-/*]\d*");
            if (!regex.Match(_expression, 0, _expression.Length).Success)
            {
                throw new ArgumentException($"The expression \"{_expression}\" is not valid.");
            }
        }

        private void tokenizer()
        {
            throw new NotImplementedException();
            //for(int i = 0; i<_expression.Length; i++)
            //{

            //}
        }
    }
}
