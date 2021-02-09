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

        public void PerformCalulation()
        {

        }
    }
}
