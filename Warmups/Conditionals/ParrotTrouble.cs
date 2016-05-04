using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Conditionals
{
    public class ParrotTrouble
    {
        public bool IsParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && (hour > 20 || hour < 7))
                return true;
            return false;
        }
    }
}
