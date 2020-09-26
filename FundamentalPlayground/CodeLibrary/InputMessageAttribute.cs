using System;

namespace CodeLibrary
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class InputMessageAttribute : Attribute
    {
        /// <summary>
        /// The index of the parameter.
        /// </summary>
        public int ParameterIndex { get; }

        /// <summary>
        /// The code of the language.
        /// </summary>
        public string LanguageCode { get; }

        /// <summary>
        /// The message.
        /// </summary>
        public string Message { get; }

        public InputMessageAttribute(int parameterIndex, string languageCode, string message)
        {
            ParameterIndex = parameterIndex;
            LanguageCode = languageCode;
            Message = message;
        }
    }
}
