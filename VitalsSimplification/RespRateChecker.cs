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
            if (respRate >= 30 && respRate <= 95)
            {
                return true;
            }
            return false;
        }
    }
}
