using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(15)]
    public class CodePack15 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter N1")]
        [InputMessage(0, "ru", "Введите N1")]
        [InputMessage(1, "en", "Enter N2")]
        [InputMessage(1, "ru", "Введите N2")]
        [InputMessage(2, "en", "Enter N3")]
        [InputMessage(2, "ru", "Введите N3")]
        [InputMessage(3, "en", "Enter N4")]
        [InputMessage(3, "ru", "Введите N4")]
        [InputMessage(4, "en", "Enter N5")]
        [InputMessage(4, "ru", "Введите N5")]
        public string RaiseToFifthPower(double n1, double n2, double n3, double n4, double n5)
        {
            StringBuilder output = new StringBuilder("\n");

            double result;
            PowerA3(n1, out result);
            output.Append($"{ result }\n");
            PowerA3(n2, out result);
            output.Append($"{ result }\n");
            PowerA3(n3, out result);
            output.Append($"{ result }\n");
            PowerA3(n4, out result);
            output.Append($"{ result }\n");
            PowerA3(n5, out result);
            output.Append($"{ result }");

            return output.ToString();
        }

        private void PowerA3(double a, out double b)
        {
            b = a * a * a;
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "Result")]
        [OutputMessage("ru", "Результат")]
        public int SignArithmetic(double a, double b)
        {
            return Sign(a) + Sign(b);
        }

        private int Sign(double x)
        {
            if (x == 0.0)
                return 0;

            return x > 0.0 ? 1 : -1;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter AR1")]
        [InputMessage(0, "ru", "Введите AR1")]
        [InputMessage(1, "en", "Enter AR2")]
        [InputMessage(1, "ru", "Введите AR2")]
        [InputMessage(2, "en", "Enter BR1")]
        [InputMessage(2, "ru", "Введите BR1")]
        [InputMessage(3, "en", "Enter BR2")]
        [InputMessage(3, "ru", "Введите BR2")]
        [InputMessage(4, "en", "Enter CR1")]
        [InputMessage(4, "ru", "Введите CR1")]
        [InputMessage(5, "en", "Enter CR2")]
        [InputMessage(5, "ru", "Введите CR2")]
        public string RingsArea(double ar1, double ar2, double br1, double br2, double cr1, double cr2)
        {
            StringBuilder output = new StringBuilder("\n");

            output.Append($"{ RingS(ar1, ar2) }\n");
            output.Append($"{ RingS(br1, br2) }\n");
            output.Append($"{ RingS(cr1, cr2) }");

            return output.ToString();
        }

        private double RingS(double r1, double r2)
        {
            if (r1 <= r2)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "R1 must be greater than R2" },
                    { "ru", "R1 должен быть больше R2" }
                });
            }

            return Math.PI * Math.Pow(r1 - r2, 2);
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
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
        public string PointsQuarter(double ax, double ay, double bx, double by, double cx, double cy)
        {
            StringBuilder output = new StringBuilder("\n");

            output.Append($"{ Quarter(ax, ay) }\n");
            output.Append($"{ Quarter(bx, by) }\n");
            output.Append($"{ Quarter(cx, cy) }");

            return output.ToString();
        }

        private int Quarter(double x, double y)
        {
            if (x == 0.0 || y == 0.0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "The point must not lie on Ox or Oy" },
                    { "ru", "Точка должна не лежать на Ox или Oy" }
                });
            }

            if (x > 0.0)
            {
                if (y > 0.0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (y > 0.0)
                    return 2;
                else
                    return 3;
            }
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Result")]
        [OutputMessage("ru", "Результат")]
        public double Fact2Test(int n)
        {
            if (n <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be positive" },
                    { "ru", "N должна быть положительная" }
                });
            }

            return Fact2(n);
        }

        private double Fact2(int n)
        {
            double factorial = 1.0;
            for (int i = (n % 2 == 0 ? 2 : 3); i <= n; i += 2)
            {
                factorial *= i;
            }

            return factorial;
        }
        #endregion
    }
}
