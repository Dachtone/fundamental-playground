using System;
using System.Collections.Generic;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(17)]
    public class CodePack17 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [InputMessage(1, "en", "Enter K")]
        [InputMessage(1, "ru", "Введите K")]
        [InputMessage(2, "en", "Enter L")]
        [InputMessage(2, "ru", "Введите L")]
        [OutputMessage("en", "Result")]
        [OutputMessage("ru", "Результат")]
        public double AverageOnInterval(int n, int k, int l)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            if (k <= 1 || l < k || l > n)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Parameters must satisfy 1 <= K <= L <= N" },
                    { "ru", "Параметры должны удовлетворять 1 <= K <= L <= N" }
                });
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            int count = l - k + 1;
            double average = 0.0;
            for (int i = k; i <= l; i++)
            {
                average += (double)array[i] / count;
            }

            return average;
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Result")]
        [OutputMessage("ru", "Результат")]
        public int ArrayProgression(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            bool isProgression = true;
            int difference = array[1] - array[0];
            for (int i = 2; i < n; i++)
            {
                if (array[i] - array[i - 1] != difference)
                {
                    isProgression = false;
                    break;
                }
            }

            return isProgression ? difference : 0;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Min")]
        [OutputMessage("ru", "Минимальное значение")]
        public int MinEven(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            int min = array[1];
            for (int i = 3; i < n; i += 2)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Index")]
        [OutputMessage("ru", "Индекс")]
        public int LocalMaxIndex(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            int max = -1;
            for (int i = 2; i < n - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    max = i;
                }
            }

            return max;
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Elements")]
        [OutputMessage("ru", "Элементы")]
        public string TwinElements(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (array[i] == array[j])
                    {
                        if (i <= j)
                            return $"{ i } { j }";
                        else
                            return $"{ j } { i }";
                    }
                }
            }

            return "-";
        }
        #endregion
    }
}
