namespace ConsoleInteractions
{
    public abstract class LanguagePhrases
    {
        // The code of the language
        public abstract string LanguageCode { get; }

        /* Phrases: */

        public abstract string Welcome { get; }

        public abstract string Error { get; }

        public abstract string EnterCodePackIndex { get; }

        public abstract string InvalidCodePackIndex { get; }

        public abstract string EnterCodeIndex { get; }

        public abstract string InvalidCodeIndex { get; }

        public abstract string InputParameterOfType { get; }

        public abstract string InvalidParameter { get; }

        public abstract string CodeExecuted { get; }

        public abstract string ShouldRunAgain { get; }
    }
}
