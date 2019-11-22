using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIFireAlarm.Models
{
    //TODO 04: Database context maken
    public class FireAlarmContext : DbContext
    {
        public FireAlarmContext(DbContextOptions<FireAlarmContext> options): base(options)
        {
                
        }

        public DbSet<FireAlarm> FireAlarmList { get; set; }

    }
}
