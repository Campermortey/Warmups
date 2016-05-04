using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Conditionals
{
    public class Diff21
    {
        /// <summary>
        /// Given an int n, return the absolute value of the difference between n and 21,
        /// except return double the absolute value of the difference if n is over 21. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DifferenceBetween21(int n)
        {
            if (n > 21)
                return (n - 21) * 2;
            return 21 - n;
        }
    }
}
