using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(5)]
    public class CodePack5 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter x1")]
        [InputMessage(0, "ru", "Введите x1")]
        [InputMessage(1, "en", "Enter y1")]
        [InputMessage(1, "ru", "Введите y1")]
        [InputMessage(2, "en", "Enter x2")]
        [InputMessage(2, "ru", "Введите x2")]
        [InputMessage(3, "en", "Enter y2")]
        [InputMessage(3, "ru", "Введите y2")]
        [OutputMessage("en", "Length between points")]
        [OutputMessage("ru", "Расстояние между точками")]
        public double LengthBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        #endregion

        #region Code 2
        [CodeIndex(2, Order = 0)]
        [InputMessage(0, "en", "Enter Ax")]
        [InputMessage(0, "ru", "Введите Ax")]
        [InputMessage(1, "en", "Enter Ay")]
        [InputMessage(1, "ru", "Введите Ay")]
        [InputMessage(2, "en", "Enter Bx")]
        [InputMessage(2, "ru", "Введите Bx")]
        [InputMessage(3, "en", "Enter By")]
        [InputMessage(3, "ru", "Введите By")]
        [InputMessage(4, "en", "Enter Cx")]
        [InputMessage(4, "ru", "Введите Cx")]
        [InputMessage(5, "en", "Enter Cy")]
        [InputMessage(5, "ru", "Введите Cy")]
        [OutputMessage("en", "AC length")]
        [OutputMessage("ru", "Длина AC")]
        public double LengthOfFirstLine(double ax, double ay, double bx, double by, double cx, double cy)
        {
            return Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
        }

        [CodeIndex(2, Order = 1)]
        [OutputMessage("en", "BC length")]
        [OutputMessage("ru", "Длина BC")]
        public double LengthOfSecondLine(double ax, double ay, double bx, double by, double cx, double cy)
        {
            return Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
        }

        [CodeIndex(2, Order = 2)]
        [OutputMessage("en", "Sum of lengths")]
        [OutputMessage("ru", "Сумма длин")]
        public double SumOfLengths(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double ac = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));

            return ac + bc;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter Ax")]
        [InputMessage(0, "ru", "Введите Ax")]
        [InputMessage(1, "en", "Enter Ay")]
        [InputMessage(1, "ru", "Введите Ay")]
        [InputMessage(2, "en", "Enter Bx")]
        [InputMessage(2, "ru", "Введите Bx")]
        [InputMessage(3, "en", "Enter By")]
        [InputMessage(3, "ru", "Введите By")]
        [InputMessage(4, "en", "Enter Cx")]
        [InputMessage(4, "ru", "Введите Cx")]
        [InputMessage(5, "en", "Enter Cy")]
        [InputMessage(5, "ru", "Введите Cy")]
        [OutputMessage("en", "Product of AC and BC lengths")]
        [OutputMessage("ru", "Произведение длин AC и BC")]
        public double ProductOfLengths(double ax, double ay, double bx, double by, double cx, double cy)
        {
            // A and B are in the same place
            if (ax == bx && ay == by)
            {
                /*
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Points must have seperate coordinates in order for the third point to be in between" },
                    { "ru", "У точек должны быть разные координаты, чтобы между ними могла находиться другая точка" }
                });
                */

                return 0;
            }

            bool inBetween = true;

            // Handle vertical lines separately
            if (ax == bx)
            {
                if (cx != ax) // C is not on the vertical line
                {
                    inBetween = false;
                }
                else if (ay < by) // A is below B
                {
                    if (cy < ay || cy > by)
                        inBetween = false;
                }
                else // B is below A
                {
                    if (cy < by || cy > ay)
                        inBetween = false;
                }
            }
            else
            {
                // Line in form y = kx + b
                double k = (by - ay) / (bx - ax); // (y2 - y1) / (x2 - x1)
                double b = ay - k * ax; // (y1 - kx1)

                if (cy != (k * cx + b)) // Not on the line
                {
                    inBetween = false;
                }
                else
                {
                    if (ax < bx) // A is to the left of B
                    {
                        if (cx < ax || cx > bx)
                            inBetween = false;
                    }
                    else // B is to the left of A
                    {
                        if (cx < bx || cx > ax)
                            inBetween = false;
                    }
                }
            }

            if (!inBetween)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "The last point is not between the first two" },
                    { "ru", "Последняя точка находится не между первыми двумя" }
                });
            }

            double ac = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));

            return ac * bc;
        }
        #endregion

        #region Code 4
        [CodeIndex(4, Order = 0)]
        [InputMessage(0, "en", "Enter x1")]
        [InputMessage(0, "ru", "Введите x1")]
        [InputMessage(1, "en", "Enter y1")]
        [InputMessage(1, "ru", "Введите y1")]
        [InputMessage(2, "en", "Enter x2")]
        [InputMessage(2, "ru", "Введите x2")]
        [InputMessage(3, "en", "Enter y2")]
        [InputMessage(3, "ru", "Введите y2")]
        [OutputMessage("en", "Rectangle perimeter")]
        [OutputMessage("ru", "Периметр прямоугольника")]
        public double PerimeterOfRectangle(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);

            return 2.0 * (a + b);
        }

        [CodeIndex(4, Order = 1)]
        [OutputMessage("en", "Rectangle area")]
        [OutputMessage("ru", "Площадь прямоугольника")]
        public double AreaOfRectangle(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);

            return a * b;
        }
        #endregion

        #region Code 5
        [CodeIndex(5, Order = 0)]
        [InputMessage(0, "en", "Enter x1")]
        [InputMessage(0, "ru", "Введите x1")]
        [InputMessage(1, "en", "Enter y1")]
        [InputMessage(1, "ru", "Введите y1")]
        [InputMessage(2, "en", "Enter x2")]
        [InputMessage(2, "ru", "Введите x2")]
        [InputMessage(3, "en", "Enter y2")]
        [InputMessage(3, "ru", "Введите y2")]
        [InputMessage(4, "en", "Enter x3")]
        [InputMessage(4, "ru", "Введите x3")]
        [InputMessage(5, "en", "Enter y3")]
        [InputMessage(5, "ru", "Введите y3")]
        [OutputMessage("en", "Triangle perimeter")]
        [OutputMessage("ru", "Периметр треугольника")]
        public double PerimeterOfTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // At least 2 points are the same
            if ((x1 == x2 && y1 == y2) || (x1 == x3 && y1 == y3) || (x2 == x3 && y2 == y3))
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "All points must have unique coordinates to form a triangle" },
                    { "ru", "У всех вершин треугольника должны быть разные коориданаты" }
                });
            }

            bool onTheSameLine = false;

            // Handle vertical lines separately
            if (x1 == x2)
            {
                if (x3 == x1)
                    onTheSameLine = true;
            }
            else
            {
                // Line in form y = kx + b
                double k = (y2 - y1) / (x2 - x1);
                double b = y1 - k * x1;

                if (y3 == (k * x3 + b))
                    onTheSameLine = true;
            }

            if (onTheSameLine)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "All three points of a triangle cannot be on the same line" },
                    { "ru", "Все вершины треугольника не могут находиться на одной линии" }
                });
            }

            double ab = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double bc = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double ca = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            return ab + bc + ca;
        }

        [CodeIndex(5, Order = 1)]
        [OutputMessage("en", "Triangle area")]
        [OutputMessage("ru", "Площадь треугольника")]
        public double AreaOfTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double ab = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double bc = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double ca = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            // Half perimeter
            double p = (ab + bc + ca) / 2.0;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }
        #endregion
    }
}
