using System;
using System.Collections.Generic;

namespace CodeLibrary
{
    public class CodeException : Exception
    {
        protected const string defaultLanguageCode = "en";

        public static Dictionary<string, string> TranslatedMessage { get; set; }

        public CodeException(string message, Dictionary<string, string> translation)
            : base(message)
        {
            TranslatedMessage = translation;
        }

        public CodeException(string message, Dictionary<string, string> translation, Exception inner)
            : base(message, inner)
        {
            TranslatedMessage = translation;
        }

        /// <summary>
        /// Get a translated message.
        /// </summary>
        /// <param name="languageCode">Code of the language.</param>
        /// <returns>The message.</returns>
        public string GetMessage(string languageCode)
        {
            if (!TranslatedMessage.ContainsKey(languageCode))
            {
                if (TranslatedMessage.ContainsKey(defaultLanguageCode))
                    return TranslatedMessage[defaultLanguageCode];
                else
                    return string.Empty;
            }

            return TranslatedMessage[languageCode];
        }
    }

    public class InvalidIndexOfCodePackException : CodeException
    {
        public static new Dictionary<string, string> TranslatedMessage = new Dictionary<string, string>()
        {
            { "en", "The specified code pack index is out of range." },
            { "ru", "Программная группа с предоставленным номером не найдена." }
        };

        public InvalidIndexOfCodePackException()
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage)
        {
        }

        public InvalidIndexOfCodePackException(Exception inner)
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage, inner)
        {
        }
    }

    public class InvalidIndexOfCodeException : CodeException
    {
        public static new Dictionary<string, string> TranslatedMessage = new Dictionary<string, string>()
        {
            { "en", "The specified code index is out of range." },
            { "ru", "Подпрограмма с предоставленным номером не найдена." }
        };

        public InvalidIndexOfCodeException()
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage)
        {
        }

        public InvalidIndexOfCodeException(Exception inner)
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage, inner)
        {
        }
    }

    public class MultipleCodesWithTheSameIndexException : CodeException
    {
        public static new Dictionary<string, string> TranslatedMessage = new Dictionary<string, string>()
        {
            { "en", "Order must be unique if codes are to share the same index." },
            { "ru", "Порядок подпрограммы должен быть уникальным, если несколько подпрограмм имеют одинаковый номер." }
        };

        public MultipleCodesWithTheSameIndexException()
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage)
        {
        }

        public MultipleCodesWithTheSameIndexException(Exception inner)
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage, inner)
        {
        }
    }

    public class NonMatchingSignatureOfTheSameIndexCodesException : CodeException
    {
        public static new Dictionary<string, string> TranslatedMessage = new Dictionary<string, string>()
        {
            { "en", "The codes that share the same index must be of the same signature." },
            { "ru", "Параметры и возвращаемый тип подпрограмм с одинаковым номером должны быть одни и те же." }
        };

        public NonMatchingSignatureOfTheSameIndexCodesException()
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage)
        {
        }

        public NonMatchingSignatureOfTheSameIndexCodesException(Exception inner)
            : base(TranslatedMessage[defaultLanguageCode], TranslatedMessage, inner)
        {
        }
    }
}
