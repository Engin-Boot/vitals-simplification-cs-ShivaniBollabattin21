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
            if (bpm >= 70 && bpm <= 150)
            {
                return true;
            }
            return false;
        }
    }
}
