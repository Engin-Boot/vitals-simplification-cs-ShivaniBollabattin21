using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitalsSimplification
{
    class BPMCheker
    {
        public static bool checkBpm(float bpm)
        {
            if (VitalsRangeChecker.rangeCheck(150, 70, bpm))
            {
                return true;
            }
            return false;
        }
    }
}
