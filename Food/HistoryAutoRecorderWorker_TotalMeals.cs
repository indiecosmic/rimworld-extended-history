using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory
{
    public class HistoryAutoRecorderWorker_TotalMeals : HistoryAutoRecorderWorker
    {
        public override float PullRecord()
        {
            float num = 0f;
            foreach (KeyValuePair<ThingDef, int> current in Find.ResourceCounter.AllCountedAmounts)
            {
                if (current.Key.IsFood)
                {
                    FoodQuality quality = current.Key.food.quality;
                    if (quality == FoodQuality.MealAwful || quality == FoodQuality.MealFine || quality == FoodQuality.MealLavish || quality == FoodQuality.MealSimple)
                    {
                        num += current.Value;
                    }
                }
            }

            return num;
        }
    }
}
