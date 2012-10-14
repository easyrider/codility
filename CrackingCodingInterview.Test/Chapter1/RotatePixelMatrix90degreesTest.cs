using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class RotatePixelMatrix90degreesTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public PixelMatrix Test(PixelMatrix image)
        {
            var cut = new RotatePixelMatrix90degrees();
            return RunTest(image, cut);
        }

        public static IEnumerable TestCases
        {
            get
            {
                var inputMatrix = new PixelMatrix(0);
                yield return new TestCaseData(inputMatrix).Returns(inputMatrix).SetName("empty matrix");
                
                inputMatrix = new PixelMatrix(1);
                inputMatrix.SetPixel(0, 0, new Pixel(0));
                yield return new TestCaseData(inputMatrix).Returns(inputMatrix).SetName("1 element matrix");
                
                inputMatrix = new PixelMatrix(2);
                inputMatrix.SetPixel(0, 0, new Pixel(0));
                inputMatrix.SetPixel(0, 1, new Pixel(1));
                inputMatrix.SetPixel(1, 0, new Pixel(2));
                inputMatrix.SetPixel(1, 1, new Pixel(3));
                var resultMatrix = new PixelMatrix(2);
                resultMatrix.SetPixel(0, 0, new Pixel(2));
                resultMatrix.SetPixel(0, 1, new Pixel(0));
                resultMatrix.SetPixel(1, 0, new Pixel(3));
                resultMatrix.SetPixel(1, 1, new Pixel(1));
                yield return new TestCaseData(inputMatrix).Returns(resultMatrix).SetName("2 element matrix");

                inputMatrix = new PixelMatrix(3);
                inputMatrix.SetPixel(0, 0, new Pixel(0));
                inputMatrix.SetPixel(0, 1, new Pixel(1));
                inputMatrix.SetPixel(0, 2, new Pixel(2));
                inputMatrix.SetPixel(1, 0, new Pixel(3));
                inputMatrix.SetPixel(1, 1, new Pixel(4));
                inputMatrix.SetPixel(1, 2, new Pixel(5));
                inputMatrix.SetPixel(2, 0, new Pixel(6));
                inputMatrix.SetPixel(2, 1, new Pixel(7));
                inputMatrix.SetPixel(2, 2, new Pixel(8));

                resultMatrix = new PixelMatrix(3);
               resultMatrix.SetPixel(0, 0, new Pixel(6));
               resultMatrix.SetPixel(0, 1, new Pixel(3));
               resultMatrix.SetPixel(0, 2, new Pixel(0));
               resultMatrix.SetPixel(1, 0, new Pixel(7));
               resultMatrix.SetPixel(1, 1, new Pixel(4));
               resultMatrix.SetPixel(1, 2, new Pixel(1));
               resultMatrix.SetPixel(2, 0, new Pixel(8));
               resultMatrix.SetPixel(2, 1, new Pixel(5));
               resultMatrix.SetPixel(2, 2, new Pixel(2));
                yield return new TestCaseData(inputMatrix).Returns(resultMatrix).SetName("3 element matrix");
            
            }
        }
    }


}