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
        protected AIFoodPreferability foodTaste;

        public HistoryAutoRecorderWorker_MealBase(AIFoodPreferability foodTaste)
        {
            this.foodTaste = foodTaste;
        }

        public override float PullRecord()
        {
            float num = 0f;
            foreach (KeyValuePair<ThingDef, int> current in Find.ResourceCounter.AllCountedAmounts)
            {
                if (current.Key.IsNutritionSource)
                {
                    AIFoodPreferability taste = current.Key.ingestible.preferability;
                    if (taste == this.foodTaste)
                    {
                        num += current.Value;
                    }
                }
            }

            return num;
        }
    }
}
