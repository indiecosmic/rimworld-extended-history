using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace IndieSoft.RimWorld.ExtendedHistory.Alerts
{
    public class Alert_PlantReadyForHarvest : Alert
    {
        private IEnumerable<Plant> PlantsReadyForHarvest
        {
            get
            {
                var growingZones = Find.ZoneManager.ZonesOfType<Zone_Growing>();

                foreach (Zone_Growing growingZone in growingZones)
                {
                    foreach (Thing thing in growingZone.AllContainedThings)
                    {
                        if (thing.def.plant != null)
                        {
                            Plant plant = thing as Plant;
                            if (plant.LifeStage == PlantLifeStage.Mature && plant.def.plant.Harvestable)
                                yield return plant;
                        }
                    }
                }

                var plantGrowers = Find.ListerBuildings.AllBuildingsColonistOfClass<Building_PlantGrower>();
                foreach (Building_PlantGrower plantGrower in plantGrowers)
                {
                    foreach (Plant plant in plantGrower.PlantsOnMe)
                    {
                        if (plant.LifeStage == PlantLifeStage.Mature && plant.def.plant.Harvestable) {
                            yield return plant;
                        }
                    }
                }
            }  
        }

        public Alert_PlantReadyForHarvest()
        {
            this.priority = AlertPriority.Medium;
            this.baseLabel = "{0} plants ready for harvest";
        }

        public override AlertReport Report
        {
            get
            {
                return this.PlantsReadyForHarvest.FirstOrDefault();
            }
        }

        public override string FullLabel
        {
            get
            {
                return string.Format(baseLabel, PlantsReadyForHarvest.Count());
            }
        }

        public override string FullExplanation
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                int num = 0;
                foreach (Plant current in this.PlantsReadyForHarvest)
                {
                    if (num >= 5)
                    {
                        stringBuilder.AppendLine("    (" + "AndMore".Translate() + ")");
                        break;
                    }
                    stringBuilder.Append("    " + current.LabelCap);
                    num++;
                    stringBuilder.AppendLine();
                }
                return stringBuilder.ToString();
            }
        }


    }
}
