using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WatermelonProblem
{
    [TestClass]
    public class Watermelon
    {
        [TestMethod]
        public void TestPositive()
        {
            Assert.AreEqual("YES", DivideWatermelon(20));
        }
        [TestMethod]
        public void TestNegative()
        {
            Assert.AreEqual("NO", DivideWatermelon(3));
        }
        public string DivideWatermelon(int WatermelonWeight)
        {
            string result="";        

            if (WatermelonWeight % 2 == 0 && WatermelonWeight >= 4)
            {
                return result = "YES";
            }else
            {
                return result = "NO";
            }
            }                          
        }
    }
