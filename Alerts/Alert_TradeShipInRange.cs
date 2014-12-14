using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Alerts
{
    public class Alert_TradeShipInRange : Alert
    {

        public Alert_TradeShipInRange()
        {
            this.priority = AlertPriority.Medium;
            this.baseLabel = "AlertTradeShipInRange".Translate();

        }

        public override AlertReport Report
        {
            get
            {
                if (Find.ListerBuildings.ColonistsHaveBuilding(ThingDefOf.CommsConsole))
                {
                    return Find.PassingShipManager.passingShips.Count > 0;
                }
                return false;
            }
        }

        public override string FullExplanation
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (PassingShip ship in Find.PassingShipManager.passingShips)
                {
                    stringBuilder.Append("    " + ship.FullTitle);
                    stringBuilder.Append(" Leaves in " + ship.ticksUntilDeparture.TickstoDaysString());
                    stringBuilder.AppendLine();
                }
                return stringBuilder.ToString();
            }
        }
    }
}
