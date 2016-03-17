using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class Hanoi
    {
        [TestMethod]
        public void MoveOneDisk()
        {
            int[] source = { 1, 2, 3, 4 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, MoveDisks(4, source, destination, auxiliar));
        }
        [TestMethod]
        public void MoveTwoDisks()
        {
            int[] source = { 1, 2, 3 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, MoveDisks(3, source, destination, auxiliar));
        }
        public int[] MoveDisks(int disk, int[] source, int[] destination, int[] auxiliar)
        {
            if (disk == 1)
            {
                return MoveDisk(disk, source, destination);
            }
            else
            {
                MoveDisks(disk - 1, source, auxiliar, destination);
                MoveDisk(disk, source, destination);
                MoveDisks(disk - 1, auxiliar, destination, source);
            }
            return destination;
        }

        private static int[] MoveDisk(int disk, int[] source, int[] destination)
        {
            destination[disk - 1] = source[disk - 1];
            Array.Resize(ref source, source.Length - 1);
            return source;
        }
    }
}
