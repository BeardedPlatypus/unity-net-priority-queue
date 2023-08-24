namespace BeardedPlatypus.Collections.Generic
{
    /// <summary>
    /// <see cref="ErrorMessage"/> defines the error messages used within the
    /// priority queue.
    /// </summary>
    internal static class ErrorMessage
    {
        /// <summary>
        /// <see cref="Argument"/> defines the error messages related to argument 
        /// errors.
        /// </summary>
        internal static class Argument
        {
            internal const string RankMultiDimNotSupported = 
                "Only single dimensional arrays are supported for the requested action.";
            internal const string NonZeroLowerBound = 
                "The lower bound of target array must be zero.";
            internal const string InvalidOffLen = 
                "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.";
            internal const string IncompatibleArrayType = 
                "Target array type is not compatible with the type of items in the collection.";
        }
        
        /// <summary>
        /// <see cref="ArgumentOutOfRange"/> defines the error messages related to 
        /// argument out of range errors.
        /// </summary>
        internal static class ArgumentOutOfRange
        {
            internal const string IndexMustBeLessOrEqual = 
                "Index was out of range. Must be non-negative and less than or equal to the size of the collection.";
            internal const string Generic_MustBeNonNegative =
                "{0} ('{1}') must be a non-negative value.";
        }

        /// <summary>
        /// <see cref="InvalidOperation"/> defines the error messages related to
        /// invalid operation exceptions.
        /// </summary>
        internal static class InvalidOperation
        {
             internal const string EnumFailedVersion = 
                "Collection was modified after the enumerator was instantiated.";
             internal const string EmptyQueue = 
                "Queue empty.";
        }
    }
}
