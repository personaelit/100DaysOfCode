using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class ExpressionEvaluator
    {
        readonly string expression;
        public ExpressionEvaluator(string expression)
        {
            this.expression = expression;
            Validate();
        }

        private void Valdiate()
        {
            //todo: the validation
            throw new Exception("The input is not valid.");
        }
    }
}
