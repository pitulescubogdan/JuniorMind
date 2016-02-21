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
            Assert.AreEqual(true, CheckAlarm(Days.Monday,6));
        }
        [TestMethod]
        public void AlarmForTuesdayAndFriday()
        {
            Assert.AreEqual(true, CheckAlarm(Days.Tuesday & Days.Friday, 6));
        }
        [TestMethod]
        public void CheckAlarmForWeekend()
        {
            Assert.AreEqual(true, CheckAlarm((Days.Saturday), 8));
        }
        [TestMethod]
        public void CheckAlarmForBothDaysOfWeekend()
        {
            Days weekend = Days.Sunday | Days.Saturday;
            Assert.AreEqual(true, CheckAlarm(weekend, 8));
        }
        [TestMethod]
        public void CheckForAnyDayAndHour()
        {
            Assert.AreEqual(false, CheckAlarm(Days.Monday, 10));
        }
        [TestMethod]
        public void CheckAnotherAlarmForAnyDays()
        {
            Days daysToCheck = Days.Monday | Days.Friday;
            Assert.AreEqual(false, CheckAlarm(daysToCheck, 12));
        }
        public bool CheckAlarm(Days weekDay,int hour)
        {
            var dayToCheck = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            var daysOfWeekend = Days.Saturday | Days.Sunday;

            if (hour == 6 && (dayToCheck & weekDay) == weekDay)
            {
                return true;
            }
            else if (hour == 8 && (daysOfWeekend & weekDay) == weekDay)
            {
                return true;
            }
            return false;
            
        }
    }
}
