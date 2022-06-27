using System;
using System.Drawing;

namespace CirclesInCircle
{
    class Figures
    {
        public float Diametr { get; set; }


        public class Circle : Figures
        {
            public void Draw(Graphics graphics, float x, float y)
            {
                graphics.DrawEllipse(new Pen(Color.Red), x - Diametr / 2.0f, y - Diametr / 2.0f, Diametr, Diametr);
            }
        }

        public class Hexagon : Figures
        {
            public void Draw(Graphics graphics, float x, float y, float diametr)
            {
                PointF[] points = new PointF[6];
                double angle = 2 * Math.PI / 6.0;

                int count = 0;
                for(float i = 0; i < 3.14 * 2; i += (float)angle)
                {
                    points[count] = new PointF(
                        (float)( x + Math.Cos(i) * diametr / 2.0f ),
                         (float)( y + Math.Sin(i) * diametr / 2.0f )
                        );
                    count++;
                }

                graphics.DrawPolygon(new Pen(Color.Black), points);
            }
        }
    }
}
