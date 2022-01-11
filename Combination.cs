using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LogikHra
{
    class Combination
    {
        public Pin[] Pins { get; set; }

        public Combination()
        {
            Pins = new Pin[]
            {
            new Pin(),
            new Pin(),
            new Pin(),
            new Pin(),
        };

        }
        public void Draw(Graphics graphics, PointF location, float size)
        {
            for (int i=0; i<Pins.Length; i++)
            {
                Pins[i].Draw(graphics, new PointF(location.X +i * size * 1.2f, location.Y), size);
            }
        }
    }
}
