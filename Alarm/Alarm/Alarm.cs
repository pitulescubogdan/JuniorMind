using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class Alarm
    {
        [Flags]
        public enum Days { Monday=0x1,Tuesday =0x2,Wednesday = 0x4,Thursday = 0x8,Friday = 0x10,Saturday = 0x20,Sunday = 0x40}
        [TestMethod]
        public void AlarmForMonday()
        {
            Assert.AreEqual(true, CheckAlarmForWeekDays(Days.Monday,6,0));
        }
        [TestMethod]
        public void AlarmForTuesdayAndFriday()
        {
            Assert.AreEqual(true, CheckAlarmForWeekDays(Days.Tuesday & Days.Friday, 6, 0));
        }
        [TestMethod]
        public void CheckAlarmForWeekend()
        {
            Assert.AreEqual(false, CheckAlarmForWeekDays((Days.Saturday), 8, 0));
        }
        [TestMethod]
        public void CheckAlarmForBothDaysOfWeekend()
        {
            Days weekend = Days.Sunday | Days.Saturday;
            Assert.AreEqual(true,CheckAlarmForWeekend(weekend, 8, 0));

        }
        public bool CheckAlarmForWeekDays(Days weekDay,int hour, int minutes)
        {
            if (hour == 6)
            {
                var dayToCheck = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
                bool testDay = (dayToCheck & weekDay) == weekDay;
                return testDay;
            }
            else return false;
            
        }
        public bool CheckAlarmForWeekend(Days weekendDays, int hour, int minutes)
        {
            if(hour == 8)
            {
                return !(CheckAlarmForWeekDays(weekendDays, 8, 0));
            }
            return false;
        }
    }
}
