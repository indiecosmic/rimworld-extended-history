﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory
{
    public class HistoryAutoRecorderWorker_TotalRawFood : HistoryAutoRecorderWorker
    {
        public override float PullRecord()
        {
            float num = 0f;
            foreach (KeyValuePair<ThingDef, int> current in Find.ResourceCounter.AllCountedAmounts)
            {
                if (current.Key.IsFood)
                {
                    FoodQuality quality = current.Key.food.quality;
                    if (quality == FoodQuality.Plant || quality == FoodQuality.Raw)
                    {
                        num += current.Value;
                    }
                }
            }

            return num;
        }
    }
}
