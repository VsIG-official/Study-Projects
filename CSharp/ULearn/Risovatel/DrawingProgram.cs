using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RefactorMe
{
    internal class Drawer
    {
        private static float s_xPos;
        private static float s_yPos;
        private static Graphics s_graphics;
        public const float FirstSidePosition = 0.375f;
        public const float SecondSidePosition = 0.04f;

        public static void Initialize(Graphics newGraphics)
        {
            s_graphics = newGraphics;
            s_graphics.SmoothingMode = SmoothingMode.None;
            s_graphics.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            s_xPos = x0;
            s_yPos = y0;
        }

        public static void DrawPartOfTheSide(Pen pen, double distance, double degree)
        {
            float x1 = (float)(s_xPos + distance * Math.Cos(degree));
            float y1 = (float)(s_yPos + distance * Math.Sin(degree));
            s_graphics.DrawLine(pen, s_xPos, s_yPos, x1, y1);
            s_xPos = x1;
            s_yPos = y1;
        }

        public static void ChangePosition(double distance, double degree)
        {
            s_xPos = (float)(s_xPos + distance * Math.Cos(degree));
            s_yPos = (float)(s_yPos + distance * Math.Sin(degree));
        }

        private enum SquareSide
        {
            Zero = 0,
            One = 1,
            MinusOne = -1,
            Two = 2,
        }

        public static void DrawSide(Pen color, int distance,
            int multiplier = 1, int divider = 1)
        {
            DrawPartOfTheSide(color, distance * FirstSidePosition,
                multiplier * Math.PI / divider);
            DrawPartOfTheSide(color, distance * SecondSidePosition
                * Math.Sqrt(2),
                (multiplier * Math.PI / divider) + Math.PI / 4);
            DrawPartOfTheSide(color, distance * FirstSidePosition, (multiplier
                * Math.PI /divider) + Math.PI);
            DrawPartOfTheSide(color, distance * FirstSidePosition
                - distance * SecondSidePosition,
                (multiplier * Math.PI / divider) + Math.PI / 2);

            ChangePosition(distance * SecondSidePosition, (multiplier
                * Math.PI / divider) - Math.PI);
            ChangePosition(distance * SecondSidePosition * Math.Sqrt(2),
                (multiplier * Math.PI / divider) + 3 * Math.PI / 4);
        }

        public static void DrawSquare(Pen color, int distance)
        {
            DrawSide(color, distance, (int)SquareSide.Zero, (int)SquareSide.One);
            DrawSide(color, distance, (int)SquareSide.MinusOne, (int)SquareSide.Two);
            DrawSide(color, distance, (int)SquareSide.One, (int)SquareSide.One);
            DrawSide(color, distance, (int)SquareSide.One, (int)SquareSide.Two);
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double angle, Graphics graphic)
        {
            Drawer.Initialize(graphic);

            int distance = Math.Min(width, height);

            double diagonalLength = Math.Sqrt(2) * (distance
                * Drawer.FirstSidePosition + distance
                * Drawer.SecondSidePosition) / 2;
            float x0 = (float)(diagonalLength * Math.Cos(Math.PI
                / 4 + Math.PI)) + width / 2f;
            float y0 = (float)(diagonalLength * Math.Sin(Math.PI
                / 4 + Math.PI)) + height / 2f;

            Drawer.SetPosition(x0, y0);

            Drawer.DrawSquare(Pens.Yellow, distance);
        }
    }
}
