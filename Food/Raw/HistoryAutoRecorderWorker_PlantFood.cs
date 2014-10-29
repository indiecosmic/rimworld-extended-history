using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_PlantFood : HistoryAutoRecorderWorker
    {
        public override float PullRecord()
        {
            return Find.ResourceCounter.AllCountedAmounts.Where(r => r.Key.IsFood && r.Key.food.quality == FoodQuality.Raw && r.Key.food.isMeat == false).Sum(f => f.Value);
        }
    }
}
