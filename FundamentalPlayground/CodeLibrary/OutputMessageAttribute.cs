using System;

namespace CodeLibrary
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class OutputMessageAttribute : Attribute
    {
        /// <summary>
        /// The code of the language.
        /// </summary>
        public string LanguageCode { get; }

        /// <summary>
        /// The message.
        /// </summary>
        public string Message { get; }

        public OutputMessageAttribute(string languageCode, string message)
        {
            LanguageCode = languageCode;
            Message = message;
        }
    }
}
