using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class Calc
    {
        readonly decimal v1, v2;
        public Calc(decimal value1, decimal value2)
        {
            v1 = value1;
            v2 = value2;
        }

        public decimal Add()
        {
            return v1 + v2;
        }

    }
}
