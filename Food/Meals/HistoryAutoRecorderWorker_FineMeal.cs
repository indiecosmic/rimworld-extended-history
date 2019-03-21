using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Food
{
    public class HistoryAutoRecorderWorker_FineMeal : HistoryAutoRecorderWorker_MealBase
    {
        public HistoryAutoRecorderWorker_FineMeal()
            : base(ThingDef.Named("MealFine"))
        {
        }
    }
}
