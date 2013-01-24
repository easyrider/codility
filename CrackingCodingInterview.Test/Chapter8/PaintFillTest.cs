using System;
using CrackingCodingInterview.Chapter8;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter8
{
    [TestFixture]
    public class PaintFillTest : TestBase
    {
        [Test]
        public void Test()
        {
            PaintFill paintFill = new PaintFill();
            Color[,] picture = new Color[3,3];

            picture[0, 0] = Color.Red;
            picture[0, 1] = Color.Green;
            picture[0, 2] = Color.Red;

            picture[1, 0] = Color.Green;
            picture[1, 1] = Color.Green;
            picture[1, 2] = Color.Blue;

            picture[2, 0] = Color.Blue;
            picture[2, 1] = Color.Red;
            picture[2, 2] = Color.Green;
            
            paintFill.Execute(Tuple.Create(picture, 1, 1, Color.Red));

            Assert.AreEqual(Color.Red, picture[0, 0]);
            Assert.AreEqual(Color.Red, picture[0, 1]);
            Assert.AreEqual(Color.Red, picture[0, 2]);

            Assert.AreEqual(Color.Red, picture[1, 0]);
            Assert.AreEqual(Color.Red, picture[1, 1]);
            Assert.AreEqual(Color.Blue, picture[1, 2]);

            Assert.AreEqual(Color.Blue, picture[2, 0]);
            Assert.AreEqual(Color.Red, picture[2, 1]);
            Assert.AreEqual(Color.Green, picture[2, 2]);
        }
    }
}
