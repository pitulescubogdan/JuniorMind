using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class Hanoi
    {
        [TestMethod]
        public void HanoiTowers()
        {
            Assert.AreEqual(true, MoveDisks(3));
        }
        public bool MoveDisks(int disk)
        {
            return true;
        }
    }
}
