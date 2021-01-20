using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(8)]
    public class CodePack8 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter size in bytes")]
        [InputMessage(0, "ru", "Введите размер в байтах")]
        [OutputMessage("en", "Size in full kilobytes")]
        [OutputMessage("ru", "Размер в полных килобайтах")]
        public int BytesToKilobytes(int bytes)
        {
            return bytes / 1024;
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "Number of intervals of size B in A")]
        [OutputMessage("ru", "Количество отрезков B на отрезке A")]
        public int NumberOfSubintervals(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Numbers must be positive" },
                    { "ru", "Числа должны быть положительными" }
                });
            }

            if (a <= b)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "A must be greater than B" },
                    { "ru", "А должно быть больше B" }
                });
            }

            return a / b;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "Unfilled part")]
        [OutputMessage("ru", "Незанятая часть")]
        public int UnfilledPart(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Numbers must be positive" },
                    { "ru", "Числа должны быть положительными" }
                });
            }

            if (a <= b)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "A must be greater than B" },
                    { "ru", "А должно быть больше B" }
                });
            }

            return a % b;
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter a 2-digit number")]
        [InputMessage(0, "ru", "Введите двухзначное число")]
        [OutputMessage("en", "New number")]
        [OutputMessage("ru", "Новое число")]
        public int SwapDigits(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must consist of 2 digits" },
                    { "ru", "Число должно быть двухзначным" }
                });
            }

            return number % 10 * 10 + number / 10;
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter a 3-digit number")]
        [InputMessage(0, "ru", "Введите трёхзначное число")]
        [OutputMessage("en", "New number")]
        [OutputMessage("ru", "Новое число")]
        public int AlterNumber(int number)
        {
            if (number < 100 || number > 999)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must consist of 3 digits" },
                    { "ru", "Число должно быть трёхзначным" }
                });
            }

            return number % 100 * 10 + number / 100;
        }
        #endregion
    }
}
