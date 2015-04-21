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
            return Find.ResourceCounter.AllCountedAmounts.Where(r => r.Key.IsNutritionSource && r.Key.ingestible.preferability == AIFoodPreferability.Raw && r.Key.ingestible.IsMeat == false).Sum(f => f.Value);
        }
    }
}
