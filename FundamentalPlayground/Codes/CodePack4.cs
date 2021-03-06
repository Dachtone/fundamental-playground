﻿using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(4)]
    public class CodePack4 : CodePack
    {
        #region Code 1
        [CodeIndex(1, Order = 0)]
        [InputMessage(0, "en", "Enter the length of the first side of the rectangle")]
        [InputMessage(0, "ru", "Введите длину первой стороны прямоугольника")]
        [InputMessage(1, "en", "Enter the length of the second side of the rectangle")]
        [InputMessage(1, "ru", "Введите длину второй стороны прямоугольника")]
        [OutputMessage("en", "The area of the rectangle")]
        [OutputMessage("ru", "Площадь прямоугольника")]
        public double Area(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "The length cannot be zero or negative" },
                    { "ru", "Длина не может быть равна нулю или отрицательному числу" }
                });
            }

            return a * b;
        }

        [CodeIndex(1, Order = 1)]
        [OutputMessage("en", "The perimeter of the rectangle")]
        [OutputMessage("ru", "Периметр прямоугольника")]
        public double Perimeter(double a, double b)
        {
            return 2.0 * (a + b);
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter the diameter of a circle")]
        [InputMessage(0, "ru", "Введите диаметр окружности")]
        [OutputMessage("en", "The circumference")]
        [OutputMessage("ru", "Длина окружности")]
        public double Circumference(double d)
        {
            if (d <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "The diameter cannot be zero or negative" },
                    { "ru", "Диаметр не может быть равен нулю или отрицательному числу" }
                });
            }

            double pi = 3.14;
            return pi * d;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter the first number")]
        [InputMessage(0, "ru", "Введите первое число")]
        [InputMessage(1, "en", "Enter the second number")]
        [InputMessage(1, "ru", "Введите второе число")]
        [OutputMessage("en", "The average of two numbers")]
        [OutputMessage("ru", "Среднее арифметическое двух чисел")]
        public double Average(double a, double b)
        {
            return (a + b) / 2;
        }
        #endregion

        #region Code 4
        [CodeIndex(4, Order = 0)]
        [InputMessage(0, "en", "Enter the first number")]
        [InputMessage(0, "ru", "Введите первое число")]
        [InputMessage(1, "en", "Enter the second number")]
        [InputMessage(1, "ru", "Введите второе число")]
        [OutputMessage("en", "The sum of squares")]
        [OutputMessage("ru", "Сумма квадратов")]
        public double SquareSum(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Numbers must be non zero" },
                    { "ru", "Числа должны быть ненулевыми" }
                });
            }

            return Math.Pow(a, 2) + Math.Pow(b, 2);
        }

        [CodeIndex(4, Order = 1)]
        [OutputMessage("en", "The difference of squares")]
        [OutputMessage("ru", "Разность квадратов")]
        public double SquareDifference(double a, double b)
        {
            return Math.Pow(a, 2) - Math.Pow(b, 2);
        }

        [CodeIndex(4, Order = 2)]
        [OutputMessage("en", "The product of squares")]
        [OutputMessage("ru", "Произведение квадратов")]
        public double SquareProduct(double a, double b)
        {
            return Math.Pow(a, 2) * Math.Pow(b, 2);
        }

        [CodeIndex(4, Order = 3)]
        [OutputMessage("en", "The quotient of squares")]
        [OutputMessage("ru", "Частное квадратов")]
        public double SquareQuotient(double a, double b)
        {
            return Math.Pow(a, 2) / Math.Pow(b, 2);
        }
        #endregion

        #region Code 5
        [CodeIndex(5, Order = 0)]
        [InputMessage(0, "en", "Enter the first number")]
        [InputMessage(0, "ru", "Введите первое число")]
        [InputMessage(1, "en", "Enter the second number")]
        [InputMessage(1, "ru", "Введите второе число")]
        [OutputMessage("en", "The sum of absolute values")]
        [OutputMessage("ru", "Сумма модулей")]
        public double AbsoluteSum(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Numbers must be non zero" },
                    { "ru", "Числа должны быть ненулевыми" }
                });
            }

            return Math.Abs(a) + Math.Abs(b);
        }

        [CodeIndex(5, Order = 1)]
        [OutputMessage("en", "The difference of absolute values")]
        [OutputMessage("ru", "Разность модулей")]
        public double AbsoluteDifference(double a, double b)
        {
            return Math.Abs(a) - Math.Abs(b);
        }

        [CodeIndex(5, Order = 2)]
        [OutputMessage("en", "The product of absolute values")]
        [OutputMessage("ru", "Произведение модулей")]
        public double AbsoluteProduct(double a, double b)
        {
            return Math.Abs(a) * Math.Abs(b);
        }

        [CodeIndex(5, Order = 3)]
        [OutputMessage("en", "The quotient of absolute values")]
        [OutputMessage("ru", "Частное модулей")]
        public double AbsoluteQuotient(double a, double b)
        {
            return Math.Abs(a) / Math.Abs(b);
        }
        #endregion
    }
}
