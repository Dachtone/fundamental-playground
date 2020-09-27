namespace ConsoleInteractions
{
    class RussianPhrases : LanguagePhrases
    {
        // The code of the language
        public override string LanguageCode { get => "ru"; }

        /* Phrases: */

        public override string Welcome { get => "Программа фундаментальных вычислений"; }

        public override string Error { get => "Ошибка"; }

        public override string EnterCodePackIndex { get => "Введите номер программной группы"; }

        public override string InvalidCodePackIndex { get => "Неверный номер программной группы"; }

        public override string EnterCodeIndex { get => "Введите номер подпрограммы"; }

        public override string InvalidCodeIndex { get => "Неверный номер подпрограммы"; }

        public override string InputParameterOfType { get => "Введите параметр типа"; }

        public override string InvalidParameter { get => "Неверный параметр"; }

        public override string ExecutionError { get => "Ошибка исполнения"; }

        public override string CodeExecuted { get => "Код выполнен"; }

        public override string ShouldRunAgain { get => "Выполнить другую программу? \"Y\" или \"N\""; }
    }
}
