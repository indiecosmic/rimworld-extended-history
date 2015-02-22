using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_RawFood : HistoryAutoRecorderWorker
    {
        public override float PullRecord()
        {
            float num = 0f;
            foreach (KeyValuePair<ThingDef, int> current in Find.ResourceCounter.AllCountedAmounts)
            {
                if (current.Key.IsFood)
                {
                    if (current.Key.ingestible.isMeat && current.Key.ingestible.taste == FoodTaste.Raw)
                    {
                        num += current.Value;
                    }
                }
            }

            return num;
        }
    }
}
