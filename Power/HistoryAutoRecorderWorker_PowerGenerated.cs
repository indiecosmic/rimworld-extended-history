using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Power
{
    public class HistoryAutoRecorderWorker_PowerGenerated : HistoryAutoRecorderWorker_PowerBase
    {
        public override float PullRecord()
        {
            float num = 0f;
            foreach (PowerNet powerNet in base.AllPowerNets)
            {
                foreach (CompPowerTrader powerTrader in powerNet.powerComps)
                {
                    if (powerTrader.PowerOn && powerTrader.PowerOutput > 0f)
                    {
                        num += powerTrader.PowerOutput;
                    }
                }
            }
            return num;
        }
    }
}
