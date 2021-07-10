// Licensed to the VsIG under one or more agreements.
// VsIG licenses this file to you under the MIT license.

using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    internal class Risovatel
    {
        private static float s_xPos;
        private static float s_yPos;
        private static Graphics s_graphics;

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
            //Делает шаг длиной distance в направлении degree и рисует пройденную траекторию
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

        public static void DrawSide(Pen color, int distance)
        {
            DrawPartOfTheSide(color, distance * 0.375f, 0);
            DrawPartOfTheSide(color, distance * 0.04f * Math.Sqrt(2), Math.PI / 4);
            DrawPartOfTheSide(color, distance * 0.375f, Math.PI);
            DrawPartOfTheSide(color, distance * 0.375f - distance * 0.04f, Math.PI / 2);

            ChangePosition(distance * 0.04f, -Math.PI);
            ChangePosition(distance * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int heigth, double angle, Graphics graphic)
        {
            Risovatel.Initialize(graphic);

            int distance = Math.Min(width, heigth);

            double diagonalLength = Math.Sqrt(2) * (distance * 0.375f + distance * 0.04f) / 2;
            float x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            float y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + heigth / 2f;

            Risovatel.SetPosition(x0, y0);

            //Рисуем 1-ую сторону

            Risovatel.DrawSide(Pens.Yellow, distance);

            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, 0);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.04f * Math.Sqrt(2), Math.PI / 4);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, Math.PI);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f - distance * 0.04f, Math.PI / 2);

            Risovatel.ChangePosition(distance * 0.04f, -Math.PI);
            Risovatel.ChangePosition(distance * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);

            //Рисуем 2-ую сторону
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, -Math.PI / 2);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, -Math.PI / 2 + Math.PI);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f - distance * 0.04f, -Math.PI / 2 + Math.PI / 2);

            Risovatel.ChangePosition(distance * 0.04f, -Math.PI / 2 - Math.PI);
            Risovatel.ChangePosition(distance * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);

            //Рисуем 3-ю сторону
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, Math.PI);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, Math.PI + Math.PI);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f - distance * 0.04f, Math.PI + Math.PI / 2);

            Risovatel.ChangePosition(distance * 0.04f, Math.PI - Math.PI);
            Risovatel.ChangePosition(distance * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);

            //Рисуем 4-ую сторону
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, Math.PI / 2);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f, Math.PI / 2 + Math.PI);
            Risovatel.DrawPartOfTheSide(Pens.Yellow, distance * 0.375f - distance * 0.04f, Math.PI / 2 + Math.PI / 2);

            Risovatel.ChangePosition(distance * 0.04f, Math.PI / 2 - Math.PI);
            Risovatel.ChangePosition(distance * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}
