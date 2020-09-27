using System;
using System.Collections.Generic;

namespace CodeLibrary
{
    public class CodeExecutionException : CodeException
    {
        public CodeExecutionException()
            : base(string.Empty, new Dictionary<string, string>())
        {
        }

        public CodeExecutionException(string message)
            : base(message, new Dictionary<string, string>() { { defaultLanguageCode, message } })
        {
        }

        public CodeExecutionException(string message, Exception inner)
            : base(message, new Dictionary<string, string>() { { defaultLanguageCode, message } }, inner)
        {
        }

        public CodeExecutionException(Dictionary<string, string> translation)
            : base(translation[defaultLanguageCode], translation)
        {
        }
        
        public CodeExecutionException(Dictionary<string, string> translation, Exception inner)
            : base(translation[defaultLanguageCode], translation, inner)
        {
        }
    }
}
