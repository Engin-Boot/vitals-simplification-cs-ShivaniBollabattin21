using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitalsSimplification
{
    class RespRateChecker
    {
        public static bool checkRespRate(float respRate)
        {
            if (VitalsRangeChecker.rangeCheck(95, 30, respRate))
            {
                return true;
            }
            return false;
        }
    }
}
