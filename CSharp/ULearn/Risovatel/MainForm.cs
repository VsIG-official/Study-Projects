// Licensed to the VsIG under one or more agreements.
// VsIG licenses this file to you under the MIT license.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace RefactorMe
{
    public class MainForm : Form
    {
        private const int Interval = 50;
        private readonly Timer timer;
        private int time;

        public MainForm(int width, int height)
        {
            ClientSize = new Size(width, height);
            timer = new Timer { Interval = Interval };
            timer.Tick += (s, a) => TimerTick();
            Resize += (sender, args) => Invalidate();
            MouseClick += OnMouseClick;
            Paint += OnPaint;
        }

        protected override void OnLoad(EventArgs e) =>
            // Включает двойную буферизацию, чтобы изображение не мерцало при перерисовке.
            // В таком режиме OnPaint рисует не сразу на окне, а сначала на невидимой картинке (shadow buffer),
            // а потом одномоментно подменяет текущее изображение дорисованной картинкой.
            // Так окно не дорисованную картинку даже не показывает, что предотвращает мерцание.
            DoubleBuffered = true;

        private void OnPaint(object sender, PaintEventArgs e)
        {
            double angularVelocity = Math.PI / 4;
            double angle = angularVelocity * (time * timer.Interval / 1000d);
            ImpossibleSquare.Draw(ClientSize.Width, ClientSize.Height, angle, e.Graphics);
        }

        private void TimerTick()
        {
            time++;
            Invalidate();
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }
    }
}
