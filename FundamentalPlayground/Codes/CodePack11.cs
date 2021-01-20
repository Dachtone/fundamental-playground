using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(11)]
    public class CodePack11 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "New numbers")]
        [OutputMessage("ru", "Новые числа")]
        public string AlterTwoNumbers(int a, int b)
        {
            if (a != b)
            {
                a = b = a > b ? a : b;
            }
            else
            {
                a = b = 0;
            }

            return $"A = { a }, B = { b }";
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [InputMessage(2, "en", "Enter C")]
        [InputMessage(2, "ru", "Введите C")]
        [OutputMessage("en", "Sum")]
        [OutputMessage("ru", "Сумма")]
        public int SumOfTwoLargestNumbers(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                return b + c;
            }
            else if (b < a && b <= c)
            {
                return a + c;
            }
            else
            {
                return a + b;
            }
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
        [OutputMessage("en", "Closest point")]
        [OutputMessage("ru", "Ближайшая точка")]
        public string ClosestPoint(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double distanceB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double distanceC = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));

            if (distanceB <= distanceC)
            {
                return $"B, d = { distanceB }";
            }
            else
            {
                return $"C, d = { distanceC }";
            }
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter x")]
        [InputMessage(0, "ru", "Введите x")]
        [InputMessage(1, "en", "Enter y")]
        [InputMessage(1, "ru", "Введите y")]
        [OutputMessage("en", "Quarter")]
        [OutputMessage("ru", "Четверть")]
        public int PointQuarter(double x, double y)
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
        [InputMessage(0, "en", "Enter a number")]
        [InputMessage(0, "ru", "Введите число")]
        [OutputMessage("en", "Description")]
        [OutputMessage("ru", "Описание")]
        public string NumberDescription(int number)
        {
            string description;

            if (number == 0)
            {
                description = "Нулевое ";
            }
            else
            {
                if (number > 0)
                    description = "Положительное";
                else
                    description = "Отрицательное";

                if (number % 2 == 0)
                    description += " чётное ";
                else
                    description += " нечётное ";

            }

            description += "число";

            return description;
        }
        #endregion

        #region Code 6
        [CodeIndex(6)]
        [InputMessage(0, "en", "Enter a number")]
        [InputMessage(0, "ru", "Введите число")]
        [OutputMessage("en", "Description")]
        [OutputMessage("ru", "Описание")]
        public string PositiveNumberDescription(int number)
        {
            if (number < 1 || number > 999)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must lie in [1; 999]" },
                    { "ru", "Число должно соответствовать отрезку [1; 999]" }
                });
            }

            string description;

            if (number % 2 == 0)
                description = "Чётное ";
            else
                description = "Нечётное ";

            int digits = 0;
            while (number > 0)
            {
                digits++;
                number /= 10;
            }

            switch (digits)
            {
                case 1:
                    description += "одно";
                    break;
                case 2:
                    description += "двух";
                    break;
                case 3:
                    description += "трёх";
                    break;
            }

            description += "значное число";

            return description;
        }
        #endregion
    }
}
