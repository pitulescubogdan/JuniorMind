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
            int[] source = { 1,2,3 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];
            CollectionAssert.AreEqual(new int[] { 1,0,0 }, MoveDisks(3,source,destination,auxiliar));
        }
        [TestMethod]
        public void MoveTwoDisks()
        {
            int[] source = { 1, 2, 3 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];
            CollectionAssert.AreEqual(new int[] { 0, 2, 0 }, MoveDisks(3, source, destination, auxiliar));
        }
        public int[] MoveDisks(int disk, int[] source, int[] destination, int[] auxiliar)
        {
            if(disk == 1)
            {
                destination[disk - 1] = source[disk - 1];
                Array.Resize(ref source, source.Length - 1);
            }
            else
            {
                MoveDisks(disk - 1, source, auxiliar, destination);
                destination[disk - 1] = source[disk - 1];
                Array.Resize(ref source, source.Length - 1);

            }
            return auxiliar;
        }
    }
}
