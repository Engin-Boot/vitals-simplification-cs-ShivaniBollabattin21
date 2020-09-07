using System;
using System.Collections.Generic;
using System.Text;

namespace VitalsSimplification
{
    class VitalsRangeChecker
    {
        public static bool rangeCheck(float upper_limit,float lower_limit,float vital_reading)
        {
            if(vital_reading>=lower_limit && vital_reading<=upper_limit)
            {
                return true;
            }
            return false;
        }
    }
}
