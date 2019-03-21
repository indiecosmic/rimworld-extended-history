using System.Collections.Generic;
using RimWorld;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public abstract class HistoryAutoRecorderWorker_MealBase : HistoryAutoRecorderWorker
    {
        private readonly ThingDef mealDef;

        public HistoryAutoRecorderWorker_MealBase(ThingDef mealDef)
        {
            this.mealDef = mealDef;
        }

        public override float PullRecord()
        {
            float num = 0f;
            List<Map> maps = Find.Maps;
            for (int i = 0; i < maps.Count; i++)
            {
                if (maps[i].IsPlayerHome)
                {
                    num += maps[i].resourceCounter.GetCount(mealDef);
                }
            }           

            return num;
        }
    }
}
