﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_FineMeal : HistoryAutoRecorderWorker_MealBase
    {
        public HistoryAutoRecorderWorker_FineMeal()
            : base(AIFoodPreferability.Fine)
        {

        }

        public override float PullRecord()
        {
            float num = 0f;
            foreach (KeyValuePair<ThingDef, int> current in Find.ResourceCounter.AllCountedAmounts)
            {
                if (current.Key.IsNutritionSource)
                {
                    AIFoodPreferability taste = current.Key.ingestible.preferability;
                    if (taste == base.foodTaste && current.Key.defName != "MealSurvivalPack")
                    {
                        num += current.Value;
                    }
                }
            }

            return num;
        }
    }
}
