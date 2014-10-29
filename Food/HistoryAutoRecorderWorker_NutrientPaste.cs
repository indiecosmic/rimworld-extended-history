using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_NutrientPaste : HistoryAutoRecorderWorker
    {
        public override float PullRecord()
        {
            return Find.ResourceCounter.AllCountedAmounts.Where(r => r.Key.IsFood && r.Key.food.quality == FoodQuality.MealAwful).Sum(f => f.Value);
        }
    }
}
