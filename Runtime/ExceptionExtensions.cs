using System;

namespace BeardedPlatypus.Collections.Generic
{
    /// <summary>
    /// <see cref="ExceptionExtensions"/> replaces some of the internal throw
    /// methods defined in .NET library.
    /// </summary>
    internal static class ExceptionExtensions
    {
        internal static void ThrowIfNull<T>(this T argument, string paramName)
        {
            if (argument == null) 
                new ArgumentNullException(paramName);
        }

        internal static void ThrowIfNegative(this int value, string paramName)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(
                    paramName, 
                    value,
                    string.Format(ErrorMessage.ArgumentOutOfRange.Generic_MustBeNonNegative, 
                                  paramName, 
                                  value));
        }
    }
}
