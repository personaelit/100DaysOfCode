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

        public decimal Left { get; private set; }

        public decimal Right { get; private set; }

        public Operations Operation => getOperator();

        public ExpressionEvaluator(string expression)
        { 
            _expression = expression;
            //WARNING: Straightline code.
            format();
            validate();
            setOperands();
        }

        private Operations getOperator()
        {
            //QUICK HACK: string.contains.
            if (_expression.Contains("+"))  return Operations.Add;
            if (_expression.Contains("-")) return Operations.Subtract;
            if (_expression.Contains("*")) return Operations.Multipy;
            //if (_expression.Contains("/")) return Operations.Divide;
            return Operations.Divide;
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

        private void setOperands()
        {
            char[] operators = new char[] { '+', '-', '*', '/' };
            foreach (var @operator in operators)
            {
                if (_expression.IndexOf(@operator) > -1)
                {
                    Left = decimal.Parse(_expression.Split(@operator)[0]);
                    Right = decimal.Parse(_expression.Split(@operator)[1]);
                }
            }
        }
    }
}
