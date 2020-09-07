using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitalsSimplification
{
    class VitalsChecker
    {
         public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
            bool vitalsCheck = false;
            bool condition = checkVitals(bpm,spo2,respRate);
            if(condition)
            {
                vitalsCheck = true;
            }
            return vitalsCheck;
        }

        static bool checkVitals(float bpm, float spo2, float respRate)
        {
            bool condition1 = VitalsRangeChecker.rangeCheck(150, 70, bpm) && VitalsRangeChecker.rangeCheck(100, 95, spo2);
            bool condition2 = condition1 && VitalsRangeChecker.rangeCheck(95, 30, respRate);
            return condition2;
        }
    }
}
