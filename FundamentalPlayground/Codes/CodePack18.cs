using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(18)]
    public class CodePack18 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        public string SwapArrays(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = i; // Lets populate the array with increments
            }

            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = n - 1 - i; // Lets populate the array with decrements
            }

            for (int i = 0; i < n; i++)
            {
                a[i] ^= b[i];
                b[i] ^= a[i];
                a[i] ^= b[i];
            }

            StringBuilder output = new StringBuilder("\nA:\n");
            for (int i = 0; i < n; i++)
            {
                output.Append($"{ a[i] }\n");
            }
            output.Append("\nB:\n");
            for (int i = 0; i < n; i++)
            {
                output.Append($"{ b[i] }");
                if (i != n - 1)
                {
                    output.Append("\n");
                }
            }

            return output.ToString();
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string GenerateAverageArray(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = i; // Lets populate the array with increments
            }

            StringBuilder output = new StringBuilder("\n");

            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += a[j];
                }
                b[i] = (double)sum / (i + 1);

                output.Append($"{ b[i] }");
                if (i != n - 1)
                {
                    output.Append("\n");
                }
            }
            
            return output.ToString();
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string OddIncrementArray(int n)
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

            int lastOdd = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    lastOdd = array[i];
                }
            }

            if (lastOdd != -1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        array[i] += lastOdd;
                    }
                }
            }

            StringBuilder output = new StringBuilder("\n");
            for (int i = 0; i < n; i++)
            {
                output.Append(array[i]);
                if (i != n - 1)
                {
                    output.Append("\n");
                }
            }

            return output.ToString();
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string ZeroBetweenMinAndMaxArray(int n)
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

            int min = 0;
            int max = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
                else if (array[i] > array[max])
                {
                    max = i;
                }
            }

            if (min > max)
            {
                min ^= max;
                max ^= min;
                min ^= max;
            }

            for (int i = min + 1; i < max; i++)
            {
                array[i] = 0;
            }
            
            StringBuilder output = new StringBuilder("\n");
            for (int i = 0; i < n; i++)
            {
                output.Append(array[i]);
                if (i != n - 1)
                {
                    output.Append("\n");
                }
            }

            return output.ToString();
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string SortFirstElement(int n)
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
            for (int j = 0; j < n; j++)
            {
                array[j] = j; // Lets populate the array with increments
            }
            array[0] = 4; // Lets place a rogue first element

            bool found = false;
            int i = 1;
            while (i < n)
            {
                if (array[i] >= array[0])
                {
                    found = true;
                    i--;
                    break;
                }

                i++;
            }

            if (found)
            {
                int element = array[0];
                for (int j = 1; j <= i; j++)
                {
                    array[j - 1] = array[j];
                }
                array[i] = element;
            }

            StringBuilder output = new StringBuilder("\n");
            for (int j = 0; j < n; j++)
            {
                output.Append(array[j]);
                if (j != n - 1)
                {
                    output.Append("\n");
                }
            }

            return output.ToString();
        }
        #endregion
    }
}
