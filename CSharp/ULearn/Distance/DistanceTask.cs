using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		public static double GetDistanceToSegment(double ax, double ay,
            double bx, double by, double x, double y)
		{
            double axAltitude  = bx - ax;
            double bxLeftHorizont = by - ay;

            double dot = (x - ax) * axAltitude + (y - ay) * bxLeftHorizont;
            double lengthOfSquare = axAltitude  * axAltitude
                + bxLeftHorizont * bxLeftHorizont;
            double param = -1;

            if (lengthOfSquare != 0)
            {
                param = dot / lengthOfSquare;
            }

            double xx, yy;

            if (param < 0)
            {
                xx = ax;
                yy = ay;
            }
            else if (param > 1)
            {
                xx = bx;
                yy = by;
            }
            else
            {
                xx = ax + param * axAltitude ;
                yy = ay + param * bxLeftHorizont;
            }

            double dx = x - xx;
            double dy = y - yy;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private static void SetParametrs()
        {

        }
    }
}
