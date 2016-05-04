using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Conditionals
{
    public class SleepingIn
    {
        /// <summary>
        /// The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation.
        /// We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in. 
        /// </summary>
        /// <param name="isWeekday"></param>
        /// <param name="isVacation"></param>
        /// <returns></returns>
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday || isVacation)
                return true;

            return false;
        }
    }
}
