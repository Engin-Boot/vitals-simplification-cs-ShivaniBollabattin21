using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VitalsSimplification
{
    class VitalsChecker
    {
        static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
            if(BPMChecker.checkBpm(bpm) && SPO2Checker.checkSpo2(spo2) && RespRateChecker.checkRespRate(respRate))
            {
                return true;
            }
            return false;
        }
    }
}
