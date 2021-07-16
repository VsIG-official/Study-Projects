using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
        // Left = x1, top = y1, right x2, bottom = y2
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            return r2.Right >= r1.Left && r2.Left <= r1.Right
                && r2.Bottom >= r1.Top && r2.Top <= r1.Bottom;
        }

		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            if (!AreIntersected(r1, r2))
            {
                return 0;
            }

            int xOverlay = Math.Max(0, Math.Min(r1.Right, r2.Right)
                - Math.Max(r1.Left, r2.Left));
            int yOverlay = Math.Max(0, Math.Min(r1.Bottom, r2.Bottom)
                - Math.Max(r1.Top, r2.Top));
            return xOverlay * yOverlay;
        }

		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            if (!AreIntersected(r1, r2))
            {
                return -1;
            }
            return GetIDOfInnerRectangle(r1, r2);
        }

        private static int GetIDOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Right >= r2.Right && r1.Bottom >= r2.Bottom
                     && r1.Left <= r2.Left && r1.Top <= r2.Top)
            {
                return 1;
            }
            return 0;
        }
	}
}
