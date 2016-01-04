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
            Assert.AreEqual("YES", DivideWatermelon(50));
        }
        public string DivideWatermelon(int WatermelonWeight)
        {
            string result="";        
            int WatermelonWeightAfterDivision = WatermelonWeight / 2;

            if (WatermelonWeight % 2 == 0 && WatermelonWeightAfterDivision >= 4)
            {


                return result = "YES";
            }else
            {
                return result = "YES";
            }
            }                          
        }
    }
