using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public interface IExpressionEvaluator
    {
        public string FormattedExpression { get; }

        public bool IsValidExpression { get; }

        public ExpressionEvaluator.Operations Operation { get; }

        public decimal Left { get; }

        public decimal Right { get; }

    }
}
