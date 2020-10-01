using System;
using CodeLibrary;

namespace Codes
{
    [CodePackIndex(6)]
    public class CodePack6 : CodePack
    {
        #region Code 1
        [CodeIndex(1)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [OutputMessage("en", "Swapped variables")]
        [OutputMessage("ru", "Переменные после перестановки")]
        public string Swap(int a, int b)
        {
            // XOR Swap
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            return $"A = { a }, B = { b }";
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
        [OutputMessage("en", "Swapped variables")]
        [OutputMessage("ru", "Переменные после перестановки")]
        public string SwapThreeVariant1(int a, int b, int c)
        {
            // A -> B
            // B -> C
            // C -> A

            int temp = b;
            b = a;
            a = c;
            c = temp;

            return $"A = { a }, B = { b }, C = { c }";
        }
        #endregion

        #region Code 3
        [CodeIndex(3)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [InputMessage(1, "en", "Enter B")]
        [InputMessage(1, "ru", "Введите B")]
        [InputMessage(2, "en", "Enter C")]
        [InputMessage(2, "ru", "Введите C")]
        [OutputMessage("en", "Swapped variables")]
        [OutputMessage("ru", "Переменные после перестановки")]
        public string SwapThreeVariant2(int a, int b, int c)
        {
            // A -> C
            // C -> B
            // B -> A

            int temp = c;
            c = a;
            a = b;
            b = temp;

            return $"A = { a }, B = { b }, C = { c }";
        }
        #endregion

        #region Code 4
        [CodeIndex(4)]
        [InputMessage(0, "en", "Enter x")]
        [InputMessage(0, "ru", "Введите x")]
        [OutputMessage("en", "y")]
        [OutputMessage("ru", "y")]
        public double EvaluateExpressionVariant1(int x)
        {
            // y = 3x^6 - 6x^2 - 7
            return 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
        }
        #endregion

        #region Code 5
        [CodeIndex(5)]
        [InputMessage(0, "en", "Enter x")]
        [InputMessage(0, "ru", "Введите x")]
        [OutputMessage("en", "y")]
        [OutputMessage("ru", "y")]
        public double EvaluateExpressionVariant2(int x)
        {
            // y = 4(x - 3)^6 - 7(x - 3)^3 + 2
            return 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
        }
        #endregion

        #region Code 6
        [CodeIndex(6)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [OutputMessage("en", "A to the power of 8")]
        [OutputMessage("ru", "A в степени 8")]
        public double RaiseToThePower8(int a)
        {
            int temp = a * a;
            temp = temp * temp;

            return temp * temp;
        }
        #endregion

        #region Code 7
        [CodeIndex(7)]
        [InputMessage(0, "en", "Enter A")]
        [InputMessage(0, "ru", "Введите A")]
        [OutputMessage("en", "A to the power of 15")]
        [OutputMessage("ru", "A в степени 15")]
        public double RaiseToThePower15(int a)
        {
            int temp1 = a * a;
            int temp2 = temp1 * a;
            temp1 = temp2 * temp2;

            return temp1 * temp1 * temp2;
        }
        #endregion
    }
}
