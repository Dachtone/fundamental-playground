using System;

namespace CodeLibrary
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class CodePackIndexAttribute : Attribute
    {
        /// <summary>
        /// The index of the code pack.
        /// </summary>
        public int Index { get; }

        public CodePackIndexAttribute(int index)
        {
            Index = index;
        }
    }
}
