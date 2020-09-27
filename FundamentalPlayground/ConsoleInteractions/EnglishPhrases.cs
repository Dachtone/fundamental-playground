namespace ConsoleInteractions
{
    class EnglishPhrases : LanguagePhrases
    {
        // The code of the language
        public override string LanguageCode { get => "en"; }

        /* Phrases: */

        public override string Welcome { get => "Fundamental Playground by Dachtone"; }

        public override string Error { get => "Error"; }

        public override string EnterCodePackIndex { get => "Enter the index of a code pack"; }

        public override string InvalidCodePackIndex { get => "Invalid index of a code pack"; }

        public override string EnterCodeIndex { get => "Enter the index of the code"; }

        public override string InvalidCodeIndex { get => "Invalid index of the code"; }

        public override string InputParameterOfType { get => "Input a"; }

        public override string InvalidParameter { get => "Invalid parameter"; }

        public override string ExecutionError { get => "Execution error"; }

        public override string CodeExecuted { get => "Code executed successfully"; }

        public override string ShouldRunAgain { get => "Run another program? \"Y\" or \"N\""; }
    }
}
