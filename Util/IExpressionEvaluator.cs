using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public interface IExpressionEvaluator
    {
        public string FormattedExpression { get; }

        public bool IsValidExpression { get; }

        //public void GetOperator(out Calc.Operations @enum);

    }
}
