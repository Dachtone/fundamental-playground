using CodeLibrary;

namespace Codes
{
    [CodePackIndex(0)]
    public class CodePackTest : CodePack
    {
        [CodeIndex(1, Order = 0)]
        [InputMessage(0, "en", "Test")]
        [InputMessage(0, "ru", "Тест")]
        [OutputMessage("en", "Output")]
        [OutputMessage("ru", "Вывод")]
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        [CodeIndex(1, Order = 1)]
        public double Test(double number1, double number2)
        {
            return 0.01;
        }

        [CodeIndex(5)]
        public double Constant()
        {
            return 42.0;
        }
    }
}
