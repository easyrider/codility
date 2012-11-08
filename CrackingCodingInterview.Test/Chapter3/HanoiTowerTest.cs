using System.Globalization;
using CrackingCodingInterview.Chapter3;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter3
{
    [TestFixture]
    public class HanoiTowerTest
    {
        [Test]
        public void Test()
        {
            var towers = new HanoiTower[3];
            for (int i = 0; i < towers.Length; i++)
            {
                towers[i] = new HanoiTower(i.ToString(CultureInfo.InvariantCulture));
            }

            const int n = 5;

            for (int i = n - 1; i >= 0; i--)
            {
                towers[0].Add(i);
            }

            towers[0].MoveDisks(n, towers[2], towers[1]);

            CollectionAssert.AreEqual(new int[]{}, towers[0].ToArray());
            CollectionAssert.AreEqual(new int[]{}, towers[1].ToArray());
            CollectionAssert.AreEqual(new[]{0, 1, 2, 3, 4}, towers[2].ToArray());
            
        }
    }
}
