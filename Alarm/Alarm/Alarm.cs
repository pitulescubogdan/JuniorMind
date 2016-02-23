using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class Alarm
    {

        [Flags]
        public enum Days {
            Monday = 0x1,
            Tuesday = 0x2,
            Wednesday = 0x4,
            Thursday = 0x8,
            Friday = 0x10,
            Saturday = 0x20,
            Sunday = 0x40 }
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
              result = (CheckDays(alarm[i].day, day) && CheckHour(alarm[i].hour, hour) && CheckMinute(alarm[i].minute, minute));           
            }
            return result;
        }

        private bool CheckDays(Days day1, Days day2)
        {
            return ((day1 & day2) != 0) ? true : false;
        }
        private bool CheckHour(int hour1,int hour2)
        {
            return (hour1 == hour2) ? true : false;
        }
        private bool CheckMinute(int minutes1,int minutes2)
        {
            return (minutes1 == minutes2) ? true : false;
        }
       
    }
       
    }



