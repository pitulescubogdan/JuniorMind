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
            var weekDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday | Days.Saturday | Days.Sunday;
            Assert.AreEqual(true, SetAlarmForWeekDays(weekDays,6,0));
        }
        public bool SetAlarmForWeekDays(Days weekDays,int hour, int minutes)
        {
            return true;
        }
    }
}
