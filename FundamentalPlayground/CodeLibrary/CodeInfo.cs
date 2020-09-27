using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace CodeLibrary
{
    public class CodeInfo
    {
        const string defaultLanguageCode = "en";

        // public int MethodIndex { get; }

        CodePack pack;
        MethodInfo method;

        /// <summary>
        /// The order of the code if there are more than one.
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// Returns the return type of the method.
        /// </summary>
        public Type ReturnType
        {
            get { return method.ReturnType; }
        }

        /// <summary>
        /// Returns the number of parameters.
        /// </summary>
        public int ParameterCount
        {
            get { return method.GetParameters().Length; }
        }

        /// <summary>
        /// Returns an array of types of parametes.
        /// </summary>
        public Type[] ParameterTypes
        {
            get
            {
                var parameters = method.GetParameters();

                var typesList = new List<Type>();
                foreach (var parameter in parameters)
                {
                    typesList.Add(parameter.ParameterType);
                }

                return typesList.ToArray();
            }
        }

        public CodeInfo(CodePack pack, MethodInfo method, int order = 0)
        {
            this.pack = pack;
            this.method = method;
            this.Order = order;
        }

        /// <summary>
        /// Get the message that is associated with a parameter.
        /// </summary>
        /// <param name="parameterIndex">Index of the parameter.</param>
        /// <param name="languageCode">Code of the language.</param>
        /// <returns>The message.</returns>
        public string GetParameterMessage(int parameterIndex, string languageCode)
        {
            // Get the input message attributes, indicies should match
            var attributes = (InputMessageAttribute[])Attribute.GetCustomAttributes(method, typeof(InputMessageAttribute));
            if (attributes.Length == 0)
                return string.Empty;

            string message = string.Empty;
            foreach (var attribute in attributes)
            {
                if (attribute.ParameterIndex != parameterIndex || attribute.LanguageCode != languageCode)
                    continue;

                message = attribute.Message;
                break;
            }

            return message;
        }

        /// <summary>
        /// Get the message that is associated with the return value.
        /// </summary>
        /// <param name="languageCode">Code of the language.</param>
        /// <returns>The message.</returns>
        public string GetReturnMessage(string languageCode)
        {
            // Get the output message attributes
            var attributes = (OutputMessageAttribute[])Attribute.GetCustomAttributes(method, typeof(OutputMessageAttribute));
            if (attributes.Length == 0)
                return string.Empty;

            string message = string.Empty;
            foreach (var attribute in attributes)
            {
                if (attribute.LanguageCode != languageCode)
                    continue;

                message = attribute.Message;
                break;
            }

            return message;
        }

        /// <summary>
        /// Call the method without parameters.
        /// </summary>
        public object Invoke()
        {
            return Invoke(null);
        }
        
        /// <summary>
        /// Call the method.
        /// </summary>
        public object Invoke(object[] parameters)
        {
            try
            {
                return method.Invoke(pack, parameters);
            }
            catch (TargetInvocationException exception)
            {
                if (exception.InnerException != null)
                    throw exception.InnerException;
                else
                    throw exception;
            }
        }
    }
}
