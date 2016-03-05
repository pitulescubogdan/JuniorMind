using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Crosspath
{
    [TestClass]
    public class Crosspath
    {
        [TestMethod]
        public void GetFirstIntersectionPoint()
        {
            Directions[] firstIntersection = new Directions[]
           {
                Directions.up,
                Directions.up,
                Directions.right,
                Directions.down,
                Directions.left
            };
            Assert.AreEqual("1,0", ReturnFistIntersection(firstIntersection));
        }
        [TestMethod]
        public void GetFirstIntersection()
        {
            Directions[] intersection = new Directions[]
                       {
                Directions.up,
                Directions.right,
                Directions.right,
                Directions.down,
                Directions.left,
                Directions.up
                        };
            Assert.AreEqual("1,1", ReturnFistIntersection(intersection));
        }
        [Flags]
        public enum Directions
        {
            up = 0x01,
            down = 0x02,
            left = 0x04,
            right = 0x08
        }


        public string ReturnFistIntersection(Directions[] directions)
        {
            int xCoord = 0;
            int yCoord = 0;
            int[] holdCoords = new int[2];
            int[][] checkPoints = new int[0][];

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == Directions.up) xCoord++;
                if (directions[i] == Directions.down) xCoord--;
                if (directions[i] == Directions.left) yCoord--;
                if (directions[i] == Directions.right) yCoord++;
                int[] coords = { xCoord, yCoord };
                Array.Resize(ref checkPoints, i + 1);
                for (int j = 0; j < checkPoints.Length - 1; j++)
                {
                    if (checkPoints[j].SequenceEqual(coords))
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
