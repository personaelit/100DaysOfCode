using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class Calc
    {
        IExpressionEvaluator _expressionEvaluator;
        public Calc(IExpressionEvaluator expressionEvaluator)
        {
            _expressionEvaluator = expressionEvaluator;
        }

        public decimal PerformCalulation()
        {
            switch (_expressionEvaluator.Operation)
            {
                case ExpressionEvaluator.Operations.Add:
                    return _expressionEvaluator.Left + _expressionEvaluator.Right;
                case ExpressionEvaluator.Operations.Subtract:
                    return _expressionEvaluator.Left - _expressionEvaluator.Right;
                case ExpressionEvaluator.Operations.Multipy:
                    return _expressionEvaluator.Left * _expressionEvaluator.Right;
                case ExpressionEvaluator.Operations.Divide:
                    if (_expressionEvaluator.Right == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return _expressionEvaluator.Left / _expressionEvaluator.Right;
                default:
                    throw new InvalidOperationException("Unsupported operation.");
            }
        }
    }
}
