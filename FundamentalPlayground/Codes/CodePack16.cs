using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(16)]
    public class CodePack16 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string GenerateArray(int n)
        {
            if (n <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be positive" },
                    { "ru", "N должна быть положительная" }
                });
            }

            StringBuilder output = new StringBuilder("\n");

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = 2 * (i + 1) - 1;
                output.Append(array[i]);
                if (i != n - 1)
                {
                    output.Append($"\n");
                }
            }

            return output.ToString();
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [InputMessage(1, "en", "Enter A")]
        [InputMessage(1, "ru", "Введите A")]
        [InputMessage(2, "en", "Enter D")]
        [InputMessage(2, "ru", "Введите D")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string GenerateArray(int n, double a, double d)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            StringBuilder output = new StringBuilder("\n");

            double[] array = new double[n];
            array[0] = a;
            output.Append($"{ array[0] }\n");

            double exponentBase = d;
            for (int i = 1; i < n; i++)
            {
                array[i] = a * exponentBase;
                output.Append(array[i]);
                if (i != n - 1)
                {
                    output.Append($"\n");
                }

                exponentBase *= d;
            }

            return output.ToString();
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [InputMessage(1, "en", "Enter A")]
        [InputMessage(1, "ru", "Введите A")]
        [InputMessage(2, "en", "Enter B")]
        [InputMessage(2, "ru", "Введите B")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string GenerateArrayOfSums(int n, int a, int b)
        {
            if (n <= 2)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 2" },
                    { "ru", "N должна быть больше 2" }
                });
            }

            StringBuilder output = new StringBuilder("\n");

            int[] array = new int[n];

            array[0] = a;
            output.Append($"{ array[0] }\n");

            array[1] = b;
            output.Append($"{ array[1] }\n");

            int sum = a + b;
            for (int i = 2; i < n; i++)
            {
                array[i] = sum;
                output.Append(array[i]);
                if (i != n - 1)
                {
                    output.Append($"\n");
                }

                sum += array[i];
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
        public string JumpPrintArray(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            StringBuilder output = new StringBuilder("\n");

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            for (int i = 0; i <= n / 2; i++)
            {
                if (i == n / 2 && n % 2 == 0)
                {
                    break;
                }    

                output.Append($"{ array[i] }\n");
                if (i != n / 2)
                {
                    output.Append($"{ array[n - 1 - i] }\n");
                }
            }
            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string ParityJumpPrintArray(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            StringBuilder output = new StringBuilder("\n");

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            for (int i = 0; i < n; i += 2)
            {
                output.Append($"{ array[i] }\n");
            }
            for (int i = n % 2 == 0 ? n - 1 : n - 2; i >= 0; i -= 2)
            {
                output.Append($"{ array[i] }\n");
            }
            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        #endregion
    }
}
