using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiFireAlarmTester
{
    class FireAlarm : IComparable
    {
        public UInt64 Id { get; set; }
        public string Location { get; set; }
        public string Reason { get; set; }
        public bool Active { get; set; }

        public int CompareTo(object obj)
        {
            if(obj == null || obj.GetType() != typeof(FireAlarm))
            {
                return 0;
            }

            FireAlarm fireAlarm = obj as FireAlarm;

            return this.Id.CompareTo(fireAlarm.Id);
        }
    }
}
