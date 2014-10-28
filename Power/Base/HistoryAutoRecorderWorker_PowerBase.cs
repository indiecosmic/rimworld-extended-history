using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace IndieSoft.RimWorld.ExtendedHistory.Power
{
    public abstract class HistoryAutoRecorderWorker_PowerBase : HistoryAutoRecorderWorker
    {
        protected List<PowerNet> AllPowerNets
        {
            get
            {
                FieldInfo allNetsField = typeof(PowerNetManager).GetField("allNets", BindingFlags.NonPublic | BindingFlags.Static);
                List<PowerNet> allPowerNets = allNetsField.GetValue(null) as List<PowerNet>;
                return allPowerNets;
            }
        }
    }
}
