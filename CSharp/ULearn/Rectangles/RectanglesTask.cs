using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
        // Left = x1, top = y1, right x2, bottom = y2
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            return r2.Right >= r1.Left && r2.Left <= r2.Right
                && r2.Bottom >= r1.Top && r2.Top <= r1.Bottom;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            int x_overlap = Math.Max(0, Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left));
            int y_overlap = Math.Max(0, Math.Min(r1.Bottom, r2.Bottom) - Math.Max(r1.Top, r2.Top));
            return x_overlap * y_overlap;
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
