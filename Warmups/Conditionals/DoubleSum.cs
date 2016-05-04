using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Conditionals
{
    public class DoubleSum
    {
        public int SumDouble(int a, int b)
        {
            if (a == b)
                return (a + b) * 2;
            return a + b;
        }
    }
}
