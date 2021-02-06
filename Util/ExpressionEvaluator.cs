using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Util
{
    public class ExpressionEvaluator : IExpressionEvaluator
    {
        string _expression;

        public string FormattedExpression { get; private set; }
        public bool IsValidExpression { get; private set; }

        public Calc.Operations Operation { get; set;}

        public ExpressionEvaluator(string expression)
        { 
            _expression = expression;
            //WARNING: Straightline code.
            Format();
            Validate();
            //TODO: Tokenize here
            GetOperator();
        }

        private void GetOperator()
        {
            //QUICK HACK: string.contains.
            //TODO: Use the tokens.
            if (_expression.Contains("+"))  Operation = Calc.Operations.Add;
            if (_expression.Contains("-")) Operation = Calc.Operations.Subtract;
            if (_expression.Contains("*")) Operation = Calc.Operations.Multipy;
            if (_expression.Contains("/")) Operation = Calc.Operations.Divide;

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
