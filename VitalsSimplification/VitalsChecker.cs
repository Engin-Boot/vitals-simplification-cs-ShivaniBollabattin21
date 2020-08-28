using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static VitalsSimplification.RespRateChecker;
using static VitalsSimplification.SPO2Checker;
using static VitalsSimplification.BPMCheker;

namespace VitalsSimplification
{
    class VitalsChecker
    {
        public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
            bool vitalsCheck = false;
            bool condition1 = BPMCheker.checkBpm(bpm) && SPO2Checker.checkSpo2(spo2) ;
            bool condition2 = condition1 && RespRateChecker.checkRespRate(respRate);
            if(condition2)
            {
                vitalsCheck = true;
            }
            return vitalsCheck;
        }
    }
}
