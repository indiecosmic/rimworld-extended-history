using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_SimpleMeal : HistoryAutoRecorderWorker_MealBase
    {
        public HistoryAutoRecorderWorker_SimpleMeal()
            : base(ThingDef.Named("MealSimple"))
        {
        }
    }
}
