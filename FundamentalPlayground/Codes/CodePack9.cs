using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(9)]
    public class CodePack9 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Seconds after the last minute")]
        [OutputMessage("ru", "Секунды после последней минуты")]
        public int SecondsAfterLastMinute(int n)
        {
            if (n < 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be non-negative" },
                    { "ru", "N должна быть неотрицательной" }
                });
            }

            return n % 60;
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter K")]
        [InputMessage(0, "ru", "Введите K")]
        [OutputMessage("en", "Day of week")]
        [OutputMessage("ru", "День недели")]
        public int DayOfWeek(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "K must lie in [1; 365]" },
                    { "ru", "K должен соответствовать отрезку [1; 365]" }
                });
            }

            return k % 7;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter K")]
        [InputMessage(0, "ru", "Введите K")]
        [InputMessage(1, "en", "Enter N")]
        [InputMessage(1, "ru", "Введите N")]
        [OutputMessage("en", "Day of week")]
        [OutputMessage("ru", "День недели")]
        public int DayOfWeek(int k, int n)
        {
            if (k < 1 || k > 365)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "K must lie in [1; 365]" },
                    { "ru", "K должен соответствовать отрезку [1; 365]" }
                });
            }

            if (n < 1 || n > 7)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must lie in [1; 7]" },
                    { "ru", "N должен соответствовать отрезку [1; 7]" }
                });
            }

            return (k + n - 2) % 7 + 1;
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [InputMessage(2, "en", "Enter C")]
        [InputMessage(2, "ru", "Введите C")]
        public string SquaresInArea(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Number must be positive" },
                    { "ru", "Числа должны быть положительными" }
                });
            }

            return $"N = { (a * b) / (c * c) }, S = { (a * b) % (c * c) }";
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter a year")]
        [InputMessage(0, "ru", "Введите год")]
        [OutputMessage("en", "Century")]
        [OutputMessage("ru", "Век")]
        public int YearToCentury(int year)
        {
            if (year <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Year must be positive" },
                    { "ru", "Год должен быть положительным числом" }
                });
            }

            return (year - 1) / 100 + 1;
        }
        #endregion
    }
}