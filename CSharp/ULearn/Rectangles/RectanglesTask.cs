using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
        // Left = x1, top = y1, right x2, bottom = y2
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            return (r2.Right >= r1.Left && r2.Left <= r2.Right)
                && (r2.Bottom >= r1.Top && r2.Top <= r1.Bottom);
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			return -1;
		}
	}
}
