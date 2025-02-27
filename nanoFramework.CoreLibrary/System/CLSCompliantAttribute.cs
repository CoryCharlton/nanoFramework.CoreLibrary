// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System
{
    /// <summary>
    /// Indicates whether a program element is compliant with the Common Language Specification (CLS). This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    [ExcludeType]
    [Serializable]
    public sealed class CLSCompliantAttribute : Attribute
    {
        private bool _compliant;

        /// <summary>
        /// Initializes an instance of the CLSCompliantAttribute class with a Boolean value indicating whether the indicated program element is CLS-compliant.
        /// </summary>
        /// <param name="isCompliant">true if CLS-compliant; otherwise, false.</param>
        public CLSCompliantAttribute(bool isCompliant)
        {
            _compliant = isCompliant;
        }

        /// <summary>
        /// GGets the Boolean value indicating whether the indicated program element is CLS-compliant.
        /// </summary>
        /// <value>true if the program element is CLS-compliant; otherwise, false.</value>
        public bool IsCompliant
        {
            get { return _compliant; }
        }
    }
}
