using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(13)]
    public class CodePack13 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter the price")]
        [InputMessage(0, "ru", "Введите цену")]
        public string SweetsPrice(decimal price)
        {
            StringBuilder output = new StringBuilder("\n");

            for (decimal weight = 0.1m; weight <= 1.0m; weight += 0.1m)
            {
                output.Append($"{ weight }: { weight * price }");
                if (weight != 1.0m)
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
        [OutputMessage("en", "Product")]
        [OutputMessage("ru", "Произведение")]
        public decimal SequenceProduct(int n)
        {
            if (n <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be positive" },
                    { "ru", "N должно быть положительным" }
                });
            }

            decimal product = 1.0m;
            for (decimal i = 1.1m; i <= 1.1m + 0.1m * (n - 1); i += 0.1m)
            {
                product *= i;
            }

            return product;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        public string Square(int n)
        {
            if (n <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be positive" },
                    { "ru", "N должно быть положительным" }
                });
            }

            StringBuilder output = new StringBuilder();

            int square = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                square += i;
                output.Append(i);
                if (i != 2 * n - 1)
                {
                    output.Append(" + ");
                }
            }

            output.Append($"\nN^2 = { square }");

            return output.ToString();
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter N")]
        [InputMessage(1, "ru", "Введите N")]
        [OutputMessage("en", "Sum")]
        [OutputMessage("ru", "Сумма")]
        public double SequenceSum(double a, int n)
        {
            if (n <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be positive" },
                    { "ru", "N должно быть положительным" }
                });
            }

            double sum = 1.0 + a;
            double exponentBase = a;
            for (int i = 2; i <= n; i++)
            {
                exponentBase *= a;
                sum += exponentBase;
            }

            return sum;
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter N")]
        [InputMessage(1, "ru", "Введите N")]
        [OutputMessage("en", "Sum")]
        [OutputMessage("ru", "Сумма")]
        public double AlternatingSequenceSum(double a, int n)
        {
            if (n <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be positive" },
                    { "ru", "N должно быть положительным" }
                });
            }

            double sum = 1.0 - a;
            double exponentBase = -a;
            for (int i = 2; i <= n; i++)
            {
                exponentBase *= -a;
                sum += exponentBase;
            }

            return sum;
        }
        #endregion
    }
}
