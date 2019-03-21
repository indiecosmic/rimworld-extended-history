using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_SurvivalMeal : HistoryAutoRecorderWorker_MealBase
    {
        public HistoryAutoRecorderWorker_SurvivalMeal()
            : base(ThingDef.Named("MealSurvivalPack"))
        {
        }
    }
}
