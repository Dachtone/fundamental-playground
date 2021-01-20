using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(10)]
    public class CodePack10 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string TwoNumbersCondition(int a, int b)
        {
            return (a > 2 && b <= 3) ? "+" : "-";
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
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string ThreeNumbersCondition(int a, int b, int c)
        {
            return (a < b && b < c) ? "+" : "-";
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter a positive number")]
        [InputMessage(0, "ru", "Введите положительное число")]
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string EvenNumberCondition(int number)
        {
            if (number <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must be positive" },
                    { "ru", "Число должно быть положительным" }
                });
            }

            return (number % 2 == 0 && number >= 10 && number <= 99) ? "+" : "-";
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter a number")]
        [InputMessage(0, "ru", "Введите число")]
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string DigitSequenceNumberCondition(int number)
        {
            if (number < 100 || number > 999)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must consist of 3 digits" },
                    { "ru", "Число должно быть трёхзначным" }
                });
            }

            int[] digits =
            {
                number / 100,
                number / 10 % 10,
                number % 10
            };

            return ((digits[0] < digits[1] && digits[1] < digits[2]) || (digits[0] > digits[1] && digits[1] > digits[2]))
                ? "+" : "-";
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter a number")]
        [InputMessage(0, "ru", "Введите число")]
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string PalindromeNumberCondition(int number)
        {
            if (number < 1000 || number > 9999)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must consist of 4 digits" },
                    { "ru", "Число должно быть четырёхзначным" }
                });
            }

            int[] digits =
            {
                number / 1000,
                number / 100 % 10,
                number / 10 % 10,
                number % 10
            };

            return (digits[0] == digits[3] && digits[1] == digits[2]) ? "+" : "-";
        }
        #endregion

        #region Code 6
        [CodeIndex(6)]
        [InputMessage(0, "en", "Enter a")]
        [InputMessage(0, "ru", "Введите a")]
        [InputMessage(1, "en", "Enter b")]
        [InputMessage(1, "ru", "Введите b")]
        [InputMessage(2, "en", "Enter c")]
        [InputMessage(2, "ru", "Введите c")]
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string RightTriangleCondition(int a, int b, int c)
        {
            if (!TriangleExists(a, b, c))
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Triangle with these sides does not exist" },
                    { "ru", "Треугольник с такими сторонами не существует" }
                });
            }

            bool right = false;
            if (a > b && a > c)
            {
                right = (a * a) == (b * b + c * c);
            }
            else if (b > a && b > c)
            {
                right = (b * b) == (a * a + c * c);
            }
            else if (c > a && c > b)
            {
                right = (c * c) == (a * a + b * b);
            }

            return right ? "+" : "-";
        }
        #endregion

        #region Code 7
        [CodeIndex(7)]
        [InputMessage(0, "en", "Enter a")]
        [InputMessage(0, "ru", "Введите a")]
        [InputMessage(1, "en", "Enter b")]
        [InputMessage(1, "ru", "Введите b")]
        [InputMessage(2, "en", "Enter c")]
        [InputMessage(2, "ru", "Введите c")]
        [OutputMessage("en", "Condition")]
        [OutputMessage("ru", "Условие")]
        public string TriangleExistsCondition(int a, int b, int c)
        {
            return TriangleExists(a, b, c) ? "+" : "-";
        }
        #endregion

        private bool TriangleExists(int a, int b, int c)
        {
            return a + b > c && b + c > a && a + c > b;
        }
    }
}
