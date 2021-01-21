using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(19)]
    public class CodePack19 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Array")]
        [OutputMessage("ru", "Массив")]
        public string RemoveRepeatedElements(int n)
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

            // Set test rogue elements
            array[3] = 2;
            array[4] = 2;
            array[6] = 5;

            int deleted = 0;
            for (int i = 1; i < n - deleted; i++)
            {
                if (array[i] == array[i - 1])
                {
                    for (int j = i; j < n - deleted - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    deleted++;
                    i--;
                }
            }

            StringBuilder output = new StringBuilder("\n");
            for (int i = 0; i < n - deleted; i++)
            {
                output.Append(array[i]);
                if (i != n - deleted - 1)
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
        public string RemoveRepeatedTwiceElements(int n)
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

            // Set test rogue elements
            array[3] = 2;
            array[4] = 2;
            array[6] = 5;

            int deleted = 0;
            int previous = array[0];
            int count = 1;
            for (int i = 1; i < n - deleted; i++)
            {
                bool deleting = false;
                if (array[i] == previous)
                {
                    count++;
                    if (i == n - deleted - 1 && count == 2)
                    {
                        deleting = true;
                    }
                }
                else
                {
                    previous = array[i];

                    if (count == 2)
                    {
                        deleting = true;
                        i--;
                    }
                    count = 1;
                }

                if (deleting)
                {
                    i--;
                    for (int j = i; j < n - deleted - 2; j++)
                    {
                        array[j] = array[j + 2];
                    }
                    deleted += 2;
                }
            }

            StringBuilder output = new StringBuilder($"\nA ({ n - deleted }):\n");
            for (int i = 0; i < n - deleted; i++)
            {
                output.Append(array[i]);
                if (i != n - deleted - 1)
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
        public string InsertZeroElement(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            n += 2;
            int[] array = new int[n];
            for (int i = 0; i < n - 2; i++)
            {
                array[i] = i; // Lets populate the array with increments
            }

            int min = 0;
            int max = 0;
            for (int i = 1; i < n - 2; i++)
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

            for (int i = n - 2; i > min; i--)
            {
                array[i] = array[i - 1];
                if (max == i - 1)
                {
                    max = i;
                }
            }
            array[min] = 0;

            if (max != min - 1)
            {
                for (int i = n - 1; i > max + 1; i--)
                {
                    array[i] = array[i - 1];
                }
                array[max + 1] = 0;
            }

            StringBuilder output = new StringBuilder("\n");
            for (int i = 0; i < (max == min - 1 ? n - 1 : n); i++)
            {
                output.Append($"{ array[i] }\n");
            }
            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        public string ZeroAfterNegativeElements(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] array = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i - 5; // Lets populate the array with increments
            }

            int inserted = 0;
            for (int i = 0; i < n + inserted; i++)
            {
                if (array[i] < 0)
                {
                    i++;
                    for (int j = n + inserted; j > i; j--)
                    {
                        array[j] = array[j - 1];
                    }

                    array[i] = 0;
                    inserted++;
                }
            }

            StringBuilder output = new StringBuilder("\n");
            for (int i = 0; i < n + inserted; i++)
            {
                output.Append(array[i]);
                if (i != n + inserted - 1)
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
        public string ZeroBeforePositiveElements(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int[] array = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i - 5; // Lets populate the array with increments
            }

            int inserted = 0;
            for (int i = 0; i < n + inserted; i++)
            {
                if (array[i] > 0)
                {
                    for (int j = n + inserted; j > i; j--)
                    {
                        array[j] = array[j - 1];
                    }

                    array[i] = 0;
                    inserted++;
                    i++;
                }
            }

            StringBuilder output = new StringBuilder("\n");
            for (int i = 0; i < n + inserted; i++)
            {
                output.Append(array[i]);
                if (i != n + inserted - 1)
                {
                    output.Append("\n");
                }
            }

            return output.ToString();
        }
        #endregion
    }
}
