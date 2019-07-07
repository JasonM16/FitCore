using System;


namespace FitCore.Model.Utilities
{
    public static class GuardExtensions
    {
        public static void Null(this IGuardClause guardClause, object input, string parameterName)
        {
            if (null == input)
                throw new ArgumentNullException(parameterName);            
        }

        public static void NullOrEmpty(this IGuardClause guardClause, string input, string parameterName)
        {
            Guard.Against.Null(input, parameterName);
            if (input == String.Empty || String.IsNullOrWhiteSpace(input))
                throw new ArgumentException($"Required input {parameterName} was empty.", parameterName);            
        }


        public static void PrecedesDate(this IGuardClause guard, DateTime start, DateTime end, string parameterName)
        {
            if (end < start)
                throw new ArgumentOutOfRangeException(parameterName);
        }
    }
    
}
