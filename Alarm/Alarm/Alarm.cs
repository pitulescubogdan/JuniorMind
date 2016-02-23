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

        public bool CheckAlarm(AlarmConfig[] alarm, Days day, int hour, int minute)
        {
            bool result = false;
            for (int i = 0; i < alarm.Length; i++)
            {
                if (CheckDays(alarm[i].day, day) && CheckHour(alarm[i].hour, hour))
                {
                    result = true;
                }
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
       
    }
       
    }



