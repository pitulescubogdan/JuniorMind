using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crosspath
{
    [TestClass]
    public class Crosspath
    {
        public struct Directions
        {
            public bool up;
            public bool down;
            public bool left;
            public bool right;

            public Directions(bool up, bool down, bool left, bool right)
            {
                this.up = up;
                this.down = down;
                this.left = left;
                this.right = right;
            }
        }
        [TestMethod]
        public void GetFirstIntersectionPoint()
        {
            var directions = new Directions[] { new Directions(true, false, false, true) };
            Assert.AreEqual(0, ReturnFistIntersection(directions));
        }

        public int ReturnFistIntersection(Directions[] directions)
        {
            
            return 0;
        }
    }
}
