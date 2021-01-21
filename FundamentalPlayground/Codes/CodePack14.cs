using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(14)]
    public class CodePack14 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        public string NumbersBetween(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Numbers must be positive" },
                    { "ru", "Числа должны быть положительными" }
                });
            }

            if (a >= b)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "A must be less than B" },
                    { "ru", "А должна быть меньше B" }
                });
            }

            StringBuilder output = new StringBuilder("\n");

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    output.Append(i);
                    if (i != b || j != i - 1)
                    {
                        output.Append("\n");
                    }
                }
            }

            return output.ToString();
        }
        #endregion

        #region Code 2
        [CodeIndex(2)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "Length")]
        [OutputMessage("ru", "Длина")]
        public double UnfilledInterval(double a, double b)
        {
            if (a <= 0.0 || b <= 0.0)
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
                    { "ru", "А должна быть больше B" }
                });
            }

            while (a - b >= 0)
            {
                a -= b;
            }

            return a;
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        public string Sum(int n)
        {
            if (n <= 1)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "N must be greater than 1" },
                    { "ru", "N должна быть больше 1" }
                });
            }

            int sum = 1;
            int k = 2;
            while (sum + k < n)
            {
                sum += k;
                k++;
            }
            sum += k;

            return $"K = { k }, S = { sum }";
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter P")]
        [InputMessage(0, "ru", "Введите P")]
        public string Investment(double p)
        {
            if (p <= 0.0 || p >= 25.0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "P must lie in (0; 25)" },
                    { "ru", "P должен принадлежать (0; 25)" }
                });
            }

            double sum = 1000;
            int k = 1;
            while (sum + sum * p / 100.0 < 1100)
            {
                sum += sum * p / 100.0;
                k++;
            }
            sum += sum * p / 100.0;

            return $"K = { k }, S = { sum }";
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "GCD")]
        [OutputMessage("ru", "НОД")]
        public int GreatestCommonDivisor(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new CodeExecutionException(new Dictionary<string, string>()
                {
                    { "en", "Numbers must be positive" },
                    { "ru", "Числа должны быть положительными" }
                });
            }

            return GCD(a, b);
        }

        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;

            return GCD(b, a % b);
        }
        #endregion

        #region Code 6
        [CodeIndex(6)]
        [InputMessage(0, "en", "Enter N")]
        [InputMessage(0, "ru", "Введите N")]
        [OutputMessage("en", "Index")]
        [OutputMessage("ru", "Порядковый номер")]
        public int Fibonacci(int n)
        {
            int k = 2;
            int last = 1;
            int f = 2;
            
            while (f < n)
            {
                int temp = f;
                f += last;
                last = temp;

                k++;
            }

            return k;
        }
        #endregion
    }
}
