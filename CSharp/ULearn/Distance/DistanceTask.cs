using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		public static double GetDistanceToSegment(double ax, double ay,
            double bx, double by, double x, double y)
		{
            double fromAXtoX = x - ax;
            double fromBXtoX = y - ay;
            double axAltitude  = bx - ax;
            double bxLeftHorizont = by - ay;

            double dot = fromAXtoX * axAltitude + fromBXtoX * bxLeftHorizont;
            double len_sq = axAltitude  * axAltitude  + bxLeftHorizont * bxLeftHorizont;
            double param = -1;

            if (len_sq != 0)
            {
                param = dot / len_sq;
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
    }
}
