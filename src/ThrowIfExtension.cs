namespace OnionCrafter.Utils.Exception
{
    /// <summary>
    /// Provides extension methods for throwing exceptions based on conditions.
    /// </summary>
    public static class ThrowIfExtension
    {
        /// <summary>
        /// Throws an exception of type <typeparamref name="TException"/> if the specified condition is met.
        /// </summary>
        /// <typeparam name="T">The type of the property.</typeparam>
        /// <typeparam name="TException">The type of the exception to throw.</typeparam>
        /// <param name="prop">The property to check.</param>
        /// <param name="condition">The condition to evaluate.</param>
        /// <returns>The value of the property.</returns>
        /// <exception cref="System.Exception">Thrown when the <paramref name="condition"/> is met.</exception>
        public static T? ThrowIf<T, TException>(this T? prop, bool condition)
            where TException : System.Exception
        {
            if (condition)
            {
                throw Activator.CreateInstance(typeof(TException), nameof(prop)) as TException ?? throw new ApplicationException();
            }
            return prop;
        }

        /// <summary>
        /// Throws an exception of type <typeparamref name="TException"/> if the specified condition is met.
        /// </summary>
        /// <typeparam name="T">The type of the property.</typeparam>
        /// <typeparam name="TException">The type of the exception to throw.</typeparam>
        /// <param name="prop">The property to check.</param>
        /// <param name="condition">The condition to evaluate.</param>
        /// <param name="args">Additional arguments to pass to the exception constructor.</param>
        /// <returns>The value of the property.</returns>
        /// <exception cref="System.Exception">Thrown when the <paramref name="condition"/> is met.</exception>
        public static T? ThrowIf<T, TException>(this T? prop, bool condition, params object?[] args)
            where TException : System.Exception
        {
            if (condition)
            {
                throw Activator.CreateInstance(typeof(TException), args) as TException ?? throw new ApplicationException();
            }
            return prop;
        }
    }
}