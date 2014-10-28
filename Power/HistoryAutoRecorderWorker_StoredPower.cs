using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndieSoft.RimWorld.ExtendedHistory.Power
{
    public class HistoryAutoRecorderWorker_StoredPower : HistoryAutoRecorderWorker_PowerBase
    {
        public override float PullRecord()
        {
            float num = 0f;
            foreach (PowerNet powerNet in base.AllPowerNets)
            {
                num += powerNet.CurrentStoredEnergy();
            }

            return num;
        }
    }
}
