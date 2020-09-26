using System;
using System.Reflection;

namespace CodeLibrary
{
    public static class CodePacks
    {
        // The name of the assembly that houses the codes
        const string CodesAssemblyName = "Codes";

        /// <summary>
        /// Retrieves an instance to the specified code pack.
        /// </summary>
        /// <param name="index">Index of a code pack.</param>
        /// <returns>The requested code pack.</returns>
        public static CodePack GetPack(int index)
        {
            // Get the assembly that houses the codes
            Assembly assembly = Assembly.Load(CodesAssemblyName);

            // Get an array of types
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                // Get the code pack index attribute, return the instance of a type if the index matches
                var attribute = (CodePackIndexAttribute)Attribute.GetCustomAttribute(type, typeof(CodePackIndexAttribute));
                if (attribute != null && attribute.Index == index)
                    return (CodePack)Activator.CreateInstance(type);
            }

            throw new InvalidIndexOfCodePackException();
        }
    }
}
