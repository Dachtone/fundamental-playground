using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(7)]
    public class CodePack7 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter a")]
        [InputMessage(0, "ru", "Введите a")]
        [OutputMessage("en", "a in radians")]
        [OutputMessage("ru", "a в радианах")]
        public double DegreesToRadians(double a)
        {
            if (a <= 0.0 || a >= 360.0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "The angle is out of range" },
                    { "ru", "Угол вне допустимого интервала" }
                });
            }

            return a / 180.0 * Math.PI;
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter a")]
        [InputMessage(0, "ru", "Введите a")]
        [OutputMessage("en", "a in degrees")]
        [OutputMessage("ru", "a в градусах")]
        public double RadiansToDegrees(double a)
        {
            if (a <= 0.0 || a >= 2.0 * Math.PI)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "The angle is out of range" },
                    { "ru", "Угол вне допустимого интервала" }
                });
            }

            return a / Math.PI * 180.0;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter X")]
        [InputMessage(0, "ru", "Введите X")]
        [InputMessage(1, "en", "Enter A")]
        [InputMessage(1, "ru", "Введите A")]
        [InputMessage(2, "en", "Enter Y")]
        [InputMessage(2, "ru", "Введите Y")]
        [OutputMessage("en", "1kg")]
        [OutputMessage("ru", "1кг")]
        public string SweetsPrice(double x, double a, double y)
        {
            double price = a / x;
            return $"{ price }, Y: { y * price }";
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter V1")]
        [InputMessage(0, "ru", "Введите V1")]
        [InputMessage(1, "en", "Enter V2")]
        [InputMessage(1, "ru", "Введите V2")]
        [InputMessage(2, "en", "Enter S")]
        [InputMessage(2, "ru", "Введите S")]
        [InputMessage(3, "en", "Enter T")]
        [InputMessage(3, "ru", "Введите T")]
        [OutputMessage("en", "Distance")]
        [OutputMessage("ru", "Расстояние")]
        public double CarsDistance(double v1, double v2, double s, double t)
        {
            if (v1 < 0.0 || v2 < 0.0 || s < 0.0 || t < 0.0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Invalid parameters" },
                    { "ru", "Недопустимые параметры" }
                });
            }

            return s + (v1 + v2) * t;
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "x")]
        [OutputMessage("ru", "x")]
        public double LinearEquation(double a, double b)
        {
            if (a == 0.0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "A must not be equal to 0" },
                    { "ru", "A не равен нулю" }
                });
            }

            return -b / a;
        }
        #endregion

        #region Code 6
        [CodeIndex(6)]
        [InputMessage(0, "en", "Enter A1")]
        [InputMessage(0, "ru", "Введите A1")]
        [InputMessage(1, "en", "Enter B1")]
        [InputMessage(1, "ru", "Введите B1")]
        [InputMessage(2, "en", "Enter C1")]
        [InputMessage(2, "ru", "Введите C1")]
        [InputMessage(3, "en", "Enter A2")]
        [InputMessage(3, "ru", "Введите A2")]
        [InputMessage(4, "en", "Enter B2")]
        [InputMessage(4, "ru", "Введите B2")]
        [InputMessage(5, "en", "Enter C2")]
        [InputMessage(5, "ru", "Введите C2")]
        public string SystemOfLinearEquations(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            if ((a1 == 0.0 || b2 == 0.0) && (a2 == 0.0 || b1 == 0.0))
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "No solutions" },
                    { "ru", "Нет решений" }
                });
            }

            double y = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);
            double x = (c1 - b1 * y) / a1;

            return $"x: { x }, y: { y }";
        }
        #endregion
    }
}
