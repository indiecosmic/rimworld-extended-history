﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_SimpleMeal : HistoryAutoRecorderWorker_MealBase
    {
        public HistoryAutoRecorderWorker_SimpleMeal()
            : base(FoodTaste.Simple)
        {
        }

    }
}
