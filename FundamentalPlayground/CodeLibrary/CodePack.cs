using System;
using System.Collections.Generic;
using System.Reflection;

namespace CodeLibrary
{
    public abstract class CodePack
    {
        // Controls the behavior regarding the signature of the same index codes
        // True if the signatures are to be identical, false otherwise
        const bool shouldSignaturesMatch = true;

        /// <summary>
        /// Retrieves the specified codes.
        /// </summary>
        /// <param name="index">Index of the code / codes.</param>
        /// <returns>The requested code / codes.</returns>
        public CodeInfo[] GetCode(int index)
        {
            // A dynamic list to store all matching codes.
            var codesList = new List<CodeInfo>();

            // Type of a current code pack
            Type type = this.GetType();

            // If there are multiple codes, the signature must be identical
            // These will be used only if shouldSignaturesMatch == true
            Type returnType = null;
            Type[] parameterTypes = null;

            // Get an array of methods
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                // Get the code index attribute, return the method if the index matches
                var attribute = (CodeIndexAttribute)Attribute.GetCustomAttribute(method, typeof(CodeIndexAttribute));
                if (attribute == null || attribute.Index != index)
                    continue;

                var code = new CodeInfo(this, method, attribute.Order);
                if (shouldSignaturesMatch)
                {
                    // Check the signature
                    if (returnType == null || parameterTypes == null)
                    {
                        returnType = code.ReturnType;
                        parameterTypes = code.ParameterTypes;
                    }
                    else
                    {
                        if (code.ReturnType != returnType || code.ParameterCount != parameterTypes.Length)
                            throw new NonMatchingSignatureOfTheSameIndexCodesException();

                        for (int parameterIndex = 0; parameterIndex < parameterTypes.Length; parameterIndex++)
                        {
                            if (code.ParameterTypes[parameterIndex] != parameterTypes[parameterIndex])
                                throw new NonMatchingSignatureOfTheSameIndexCodesException();
                        }
                    }
                }

                codesList.Add(code);
            }

            // Throw an exception if no codes are found
            if (codesList.Count == 0)
                throw new InvalidIndexOfCodeException();

            // Sort by the order
            if (codesList.Count > 1)
            {
                // Standard Sort method hides exceptions, lets unpack an inner exception if there is one
                try
                {
                    codesList.Sort((CodeInfo firstCode, CodeInfo secondCode) =>
                    {
                        if (firstCode.Order == secondCode.Order)
                            throw new MultipleCodesWithTheSameIndexException();

                        return firstCode.Order - secondCode.Order;
                    });
                }
                catch (InvalidOperationException exception)
                {
                    if (exception.InnerException != null)
                        throw exception.InnerException;
                    else
                        throw exception;
                }
            }

            return codesList.ToArray();
        }
    }
}
