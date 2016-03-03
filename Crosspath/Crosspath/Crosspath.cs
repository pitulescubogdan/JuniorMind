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
            var directions = new Directions[] { new Directions(true, false, false, true), new Directions(true,false,false,true) };
            Assert.AreEqual("", ReturnFistIntersection(directions));
        }

        public string ReturnFistIntersection(Directions[] directions)
        {
            int xCoord = 0;
            int yCoord = 0;

                for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i].up) xCoord++;
                if (directions[i].down) xCoord--;
                if (directions[i].left) yCoord--;
                if (directions[i].right) yCoord++; 

            }
            return "(" + xCoord + ", " + yCoord + ")";
        }
    }
}
