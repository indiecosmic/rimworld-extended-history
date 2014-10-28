using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public abstract class HistoryAutoRecorderWorker_MealBase : HistoryAutoRecorderWorker
    {
        private FoodQuality foodQuality;

        public HistoryAutoRecorderWorker_MealBase(FoodQuality foodQuality)
        {
            this.foodQuality = foodQuality;
        }

        public override float PullRecord()
        {
            float num = 0f;
            foreach (KeyValuePair<ThingDef, int> current in Find.ResourceCounter.AllCountedAmounts)
            {
                if (current.Key.IsFood)
                {
                    FoodQuality quality = current.Key.food.quality;
                    if (quality == this.foodQuality)
                    {
                        num += current.Value;
                    }
                }
            }

            return num;
        }
    }
}
