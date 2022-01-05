using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Tools
{
    class DS_Graphics
    {
        public static Point GetPoint(Point StartPoint, double lenPixel, double angle, double Multiplier)
        {
            Point EndPoint = new Point();

            EndPoint.X = (int)(lenPixel * Math.Cos(angle * Math.PI / 180.0) * Multiplier);
            EndPoint.Y = -(int)(lenPixel * Math.Sin(angle * Math.PI / 180.0) * Multiplier);

            EndPoint.X += StartPoint.X;
            EndPoint.Y += StartPoint.Y;

            return EndPoint;
        }
        public static Point GetPointMetering(Point StartPoint, double lenPixel, double angle, double Multiplier)
        {
            Point EndPoint = new Point();

            EndPoint.X = (int)(lenPixel * Math.Cos(angle * Math.PI / 180.0) * Multiplier);
            EndPoint.Y = (int)(lenPixel * Math.Sin(angle * Math.PI / 180.0) * Multiplier);

            EndPoint.X += StartPoint.X;
            EndPoint.Y += StartPoint.Y;

            return EndPoint;
        }
        public static void drawArrow(Pen pen, Graphics g, Point point, double angle, double lenPixel)
        {
            Point TempPoint1 = GetPoint(point, lenPixel, 180 + angle - 45, 1);
            Point TempPoint2 = GetPoint(point, lenPixel, 180 + angle + 45, 1);
            g.DrawLine(pen, point, TempPoint1);
            g.DrawLine(pen, point, TempPoint2);
        }
        public static void drawArrowMetering(Pen pen, Graphics g, Point point, double angle, double lenPixel)
        {
            Point TempPoint1 = GetPointMetering(point, lenPixel, 180 + angle - 45, 1);
            Point TempPoint2 = GetPointMetering(point, lenPixel, 180 + angle + 45, 1);
            g.DrawLine(pen, point, TempPoint1);
            g.DrawLine(pen, point, TempPoint2);
        }
    }
}
