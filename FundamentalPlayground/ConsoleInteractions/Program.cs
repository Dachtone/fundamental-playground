using System;
using System.Text;
using CodeLibrary;

namespace ConsoleInteractions
{
    enum ProgramState
    {
        Run,
        Stop
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LanguagePhrases phrases = new EnglishPhrases();
            // LanguagePhrases phrases = new RussianPhrases();

            Console.WriteLine(phrases.Welcome);

            ProgramState state = ProgramState.Run;
            do
            {
                Console.WriteLine();

                string input;

                Console.Write($"{ phrases.EnterCodePackIndex }: ");
                input = Console.ReadLine();

                int packIndex;
                if (!int.TryParse(input, out packIndex))
                {
                    Console.Write($"{ phrases.InvalidCodePackIndex }.");
                    continue;
                }

                CodePack pack;
                try
                {
                    pack = CodePacks.GetPack(packIndex);
                }
                catch (CodeException exception)
                {
                    Console.WriteLine($"{ phrases.Error }! { exception.GetMessage(phrases.LanguageCode) }");
                    continue;
                }

                // Initialize to an empty array to avoid potential unassigned variable problems
                CodeInfo[] codes = new CodeInfo[0];
                ProgramState innerState = ProgramState.Run;
                do
                {
                    Console.Write($"{ phrases.EnterCodeIndex }: ");
                    input = Console.ReadLine();

                    int codeIndex;
                    if (!int.TryParse(input, out codeIndex))
                    {
                        Console.Write($"{ phrases.InvalidCodeIndex }.");
                        Console.WriteLine();
                        continue;
                    }
                    
                    try
                    {
                        codes = pack.GetCode(codeIndex);
                    }
                    catch (CodeException exception)
                    {
                        Console.WriteLine($"{ phrases.Error }! { exception.GetMessage(phrases.LanguageCode) }");
                        Console.WriteLine();
                        continue;
                    }

                    // Successfully retrieved the code
                    innerState = ProgramState.Stop;
                }
                while (innerState == ProgramState.Run);

                // Since many codes with the same index are supported, we have an array,
                // however, their inputs are identical and should be entered once.
                // We take the first code as the "main code" and pull messages and parameter information from there
                var mainCode = codes[0];
                var parameterTypes = mainCode.ParameterTypes;

                object[] parameters = new object[mainCode.ParameterCount];
                for (int parameterIndex = 0; parameterIndex < mainCode.ParameterCount; parameterIndex++)
                {
                    object parameter;
                    ProgramState inputState = ProgramState.Run;
                    do
                    {
                        string parameterMessage = mainCode.GetParameterMessage(parameterIndex, phrases.LanguageCode);
                        if (parameterMessage.Length == 0)
                        {
                            parameterMessage =
                                $"{ phrases.InputParameterOfType } { parameterTypes[parameterIndex].ToString() }";
                        }
                        Console.Write($"{ parameterMessage }: ");

                        string parameterInput = Console.ReadLine();
                        try
                        {
                            parameter = Convert.ChangeType(parameterInput, parameterTypes[parameterIndex]);
                            parameters[parameterIndex] = parameter;
                            inputState = ProgramState.Stop;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"{ phrases.Error }! { phrases.InvalidParameter }.");
                            continue;
                        }
                    }
                    while (inputState == ProgramState.Run);
                }

                foreach (var code in codes)
                {
                    object returnValue = null;
                    if (parameters.Length == 0)
                        returnValue = code.Invoke();
                    else
                        returnValue = code.Invoke(parameters);

                    string returnMessage = code.GetReturnMessage(phrases.LanguageCode);
                    bool hasMessage = returnMessage.Length != 0;
                    if (!hasMessage)
                        returnMessage = phrases.CodeExecuted;

                    Console.Write(returnMessage);

                    if (code.ReturnType != typeof(void))
                        Console.Write($": { returnValue }");
                    else
                        Console.Write(".");
                    
                    Console.WriteLine();
                }

                innerState = ProgramState.Run;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine(phrases.ShouldRunAgain);

                    input = Console.ReadLine();
                    input = input.ToLower();

                    if (input.ToLower() == "n")
                    {
                        state = ProgramState.Stop;
                        innerState = ProgramState.Stop;
                    }
                    else if (input == "y")
                    {
                        innerState = ProgramState.Stop;
                    }
                }
                while (innerState == ProgramState.Run);
            }
            while (state == ProgramState.Run);
        }
    }
}
