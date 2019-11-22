using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIFireAlarm.Models
{
    //TODO 01: Model FireAlarm aanmaken
    //TODO 02: Installeer via NuGet: Microsoft.EntitityFrameworkCore.SqlServer (voor lokale database)
    //TODO 03: Installeer Microsoft.EntitityFrameworkCore.InMemory (voor lokale database)
    public class FireAlarm
    {
        public UInt64 Id { get; set; }
        public string Location { get; set; }
        public string Reason { get; set; }
        public bool Active { get; set; }



    }
}
