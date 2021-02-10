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
                    break;
                case ExpressionEvaluator.Operations.Subtract:
                    break;
                case ExpressionEvaluator.Operations.Multipy:
                    break;
                case ExpressionEvaluator.Operations.Divide:
                    break;
                default:
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
