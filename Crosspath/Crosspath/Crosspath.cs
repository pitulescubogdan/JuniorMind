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
                Directions.down,
                Directions.left
            };
            Assert.AreEqual(new Point(0, 0), ReturnFistIntersection(firstIntersection));
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
            Assert.AreEqual(new Point(1, 1), ReturnFistIntersection(intersection));
        }
        public enum Directions
        {
            up,
            down,
            left,
            right,
        }
        public struct Point
        {
            public int xCoord;
            public int yCoord;

            public Point(int xCoord, int yCoord)
            {
                this.xCoord = xCoord;
                this.yCoord = yCoord;
            }
        }

        public Point ReturnFistIntersection(Directions[] directions)
        {
            int xCoord = 0;
            int yCoord = 0;
            Point[] checkPoints = new Point[directions.Length];

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == Directions.up) xCoord++;
                if (directions[i] == Directions.down) xCoord--;
                if (directions[i] == Directions.left) yCoord--;
                if (directions[i] == Directions.right) yCoord++;

                for (int j = 0; j < checkPoints.Length; j++)
                {
                    if (SearchIntersectPoint(xCoord, yCoord, checkPoints, j)) return checkPoints[j];
                }


                checkPoints[i].xCoord = xCoord;
                checkPoints[i].yCoord = yCoord;

            }
            return checkPoints[0];
        }

        private static bool SearchIntersectPoint(int xCoord, int yCoord, Point[] checkPoints, int j)
        {
            return (checkPoints[j].xCoord == xCoord && checkPoints[j].yCoord == yCoord);
        }
    }
}
