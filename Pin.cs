using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LogikHra
{
    class Pin
    {
        public PinState State { get; set; }

        public Pin()
        {
            State = PinState.Empty;
        }
        //vykreslování
        public void Draw(Graphics graphics, PointF location, float size)
        {
            Brush brush = new SolidBrush(GetColor());
            graphics.FillEllipse(Brushes.Yellow, location.X, location.Y, size, size);
            graphics.DrawEllipse(Pens.Black, location.X, location.Y, size, size);

        }

        private Color GetColor()
        {
            switch (State)
            {
                case PinState.Color1:
                    return Color.Red;
                case PinState.Color2:
                    return Color.Green;
                case PinState.Color3:
                    return Color.Blue;
                case PinState.Color4:
                    return Color.Cyan;
                case PinState.Color5:
                    return Color.Magenta;
                case PinState.Color6:
                    return Color.Yellow;
                default:
                    return Color.White;
            }
        }

        public enum PinState
        {
            Empty,
            Color1,
            Color2,
            Color3,
            Color4,
            Color5,
            Color6
        }
    }
}
