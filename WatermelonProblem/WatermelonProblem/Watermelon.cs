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
            Assert.AreEqual("DA", DivideWatermelon(50));
        }
        public string DivideWatermelon(int WatermelonWeight)
        {
            string result="";
            int WatermelonWeightAfterDivision;

            if (WatermelonWeight % 2 == 0)
            {
                WatermelonWeightAfterDivision = WatermelonWeight / 2;
                if (WatermelonWeightAfterDivision >= 4)
                {
                    return result = "DA";
                }                
                else
                {
                    return result = "NU";
                }
            }
            else
            {
                return result = "NU";
            }                   
        }
    }
}
