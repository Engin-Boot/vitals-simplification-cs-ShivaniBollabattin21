using System;
using System.Collections.Generic;
using System.Text;

namespace vitals_simplification
{
    class VitalsChecker
    {
        public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
            if ((bpm < 70 || bpm > 150) && spo2 < 90 && (respRate < 30 || respRate > 95))
            {
                return false;
            }
            return true;

        }
    }
}
