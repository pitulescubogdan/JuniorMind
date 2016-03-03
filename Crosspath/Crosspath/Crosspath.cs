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
            var directions = new Directions[] { new Directions(true, false, false, true), new Directions(true, false, false, true)
            ,new Directions(true,false,false,true),new Directions(false,true,true,false)};
            Assert.AreEqual("2,2", ReturnFistIntersection(directions));
        }

        public string ReturnFistIntersection(Directions[] directions)
        {
            int xCoord = 0;
            int yCoord = 0;
            int[] holdCoords = new int[2];
            int[][] checkPoints = new int[directions.Length][];

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i].up) xCoord++;
                if (directions[i].down) xCoord--;
                if (directions[i].left) yCoord--;
                if (directions[i].right) yCoord++;
                int[] coords = { xCoord, yCoord };

                for (int j = 0; j < checkPoints.Length - 1; j++)
                {
                    if (Array.Equals(checkPoints[j],coords)) 
                    {
                        return xCoord + "," + yCoord;
                    }
                }
                checkPoints[i] = coords;

            }
            return 0 + "," + 0;
        }
    }
}
