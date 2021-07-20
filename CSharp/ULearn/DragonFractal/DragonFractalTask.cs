// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
        private static readonly double s_firstDegree = Math.PI * 45 / 180;
        private static readonly double s_secondDegree = Math.PI * 135 / 180;

        private static double s_x = 1.0;
        private static double s_y = 0.0;

        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
            var randGenerator = new Random(seed);

            for (var i = 0; i < iterationsCount; i++)
            {
                if (randGenerator.Next() % 2 == 1)
                {
                    (s_x, s_y) = GetPoints(s_firstDegree);
                }
                else
                {
                    (s_x, s_y) = GetPoints(s_secondDegree, 1);
                }

                pixels.SetPixel(s_x, s_y);
            }
		}

        private static (double xNew, double yNew) GetPoints(double angle, int adder = 0)
        {
            double xNew = (s_x * Math.Cos(angle) - s_y
                * Math.Sin(angle)) / Math.Sqrt(2) + adder;
            double yNew = (s_x * Math.Sin(angle) + s_y
                * Math.Cos(angle)) / Math.Sqrt(2);

            return (xNew, yNew);
        }
    }
}
