using System;

namespace CodeLibrary
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class CodeIndexAttribute : Attribute
    {
        /// <summary>
        /// The index of the code within a code pack.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// The order of the code if there are more than one.
        /// </summary>
        public int Order { get; set; }

        public CodeIndexAttribute(int index)
        {
            Index = index;
        }
    }
}
