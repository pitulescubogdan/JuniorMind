using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class Alarm
    {

        [Flags]
        public enum Days
        {
            Monday = 0x1,
            Tuesday = 0x2,
            Wednesday = 0x4,
            Thursday = 0x8,
            Friday = 0x10,
            Saturday = 0x20,
            Sunday = 0x40
        }
        public struct AlarmConfig
        {
            public Days day;
            public int hour;
            public int minute;
            public AlarmConfig(Days weekDays, int hour, int minute)
            {
                this.day = weekDays;
                this.hour = hour;
                this.minute = minute;
            }

        }
        [TestMethod]
        public void AlarmForMOnday()
        {
            AlarmConfig[] monday = new AlarmConfig[] { new AlarmConfig(Days.Monday, 8, 0) };
            Assert.IsTrue(CheckAlarm(monday, Days.Monday, 8, 0));
        }
        [TestMethod]
        public void AlarmForMondayAndWednesday()
        {
            const Days Days1 = Days.Monday | Days.Wednesday;
            AlarmConfig[] mondayAndWednesday = new AlarmConfig[] { new AlarmConfig(Days1, 8, 0) };
            Assert.IsTrue(CheckAlarm(mondayAndWednesday, Days.Monday | Days.Wednesday, 8, 0));
        }
        [TestMethod]
        public void AlarmForWeekend()
        {
            const Days Days1 = Days.Monday | Days.Wednesday | Days.Friday | Days.Tuesday | Days.Thursday;
            AlarmConfig[] mondayAndWednesday = new AlarmConfig[] { new AlarmConfig(Days1, 8, 0) };
            Assert.IsFalse(CheckAlarm(mondayAndWednesday, Days.Sunday | Days.Saturday, 8, 0));
        }

        public bool CheckAlarm(AlarmConfig[] alarm, Days day, int hour, int minute)
        {
            bool result = false;
            for (int i = 0; i < alarm.Length; i++)
            {
                result = (CheckDays(alarm[i].day, day, alarm[i].hour, hour, alarm[i].minute, minute));
            }
            return result;
        }

        private bool CheckDays(Days dayConfig, Days dayAlarm, int hourConfig, int hourAlarm, int minuteConfig, int minuteAlarm)
        {
            return (((dayConfig & dayAlarm) != 0) &&
                (hourConfig == hourAlarm) &&
                (minuteConfig == minuteAlarm));
        }

    }

}



