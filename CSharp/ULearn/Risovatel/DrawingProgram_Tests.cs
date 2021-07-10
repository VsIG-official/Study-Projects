// Licensed to the VsIG under one or more agreements.
// VsIG licenses this file to you under the MIT license.

using System;
using System.Drawing;
using NUnit.Framework;
using RefactorMe.Properties;

namespace RefactorMe
{
    [TestFixture]
    public class DrawingProgram_Tests
    {
        [Test]
        public void DrawExpectedImage()
        {
            const int width = 800;
            const int height = 600;
            var actual = new Bitmap(width, height);
            ImpossibleSquare.Draw(width, height, 0, Graphics.FromImage(actual));
            //actual.Save(TestContext.CurrentContext.TestDirectory + "/expected-image.bmp");
            AssertImageEquals(Resources.expected_image, actual);
        }

        public void AssertImageEquals(Bitmap expected, Bitmap actual)
        {
            double diffCount = 0.0;

            for (int x = 0; x < expected.Width; x++)
            {
                for (int y = 0; y < expected.Height; y++)
                {
                    Color expectedPixel = expected.GetPixel(x, y);
                    Color actualPixel = actual.GetPixel(x, y);
                    if (Math.Abs(expectedPixel.GetBrightness() - actualPixel.GetBrightness()) > 0.1)
                    {
                        diffCount++;
                    }
                }
            }

            // Изображение, которое рисует метод Draw, должно в точности совпадать с изображением expected-image
            Assert.Less(diffCount, 100);
        }
    }
}
