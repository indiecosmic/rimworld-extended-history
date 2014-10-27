using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory
{
    public class HistoryAutoRecorderWorker_FineMeal : HistoryAutoRecorderWorker_MealBase
    {
        public HistoryAutoRecorderWorker_FineMeal()
            : base(FoodQuality.MealFine)
        {

        }
    }
}
