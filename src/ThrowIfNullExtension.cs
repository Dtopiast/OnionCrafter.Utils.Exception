namespace OnionCrafter.Utils.Exception
{
    /// <summary>
    /// Provides extension methods for handling exceptions.
    /// </summary>
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo

    public static class ThrowIfNullExtension
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the specified object is null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="prop">The object to check for null.</param>
        /// <returns>The object if it is not null.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the object is null.</exception>
        public static T ThrowIfNull<T>(this T? prop)
        {
            prop.ThrowIf<T, ArgumentNullException>(prop == null);
            return prop;
        }

        /// <summary>
        /// Throws a specified exception if the specified object is null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <typeparam name="TException">The type of exception to be thrown.</typeparam>
        /// <param name="prop">The object to check for null.</param>
        /// <returns>The object if it is not null.</returns>
        /// <exception>Thrown when the object is null.</exception>
        public static T ThrowIfNull<T, TException>(this T? prop)
            where TException : System.Exception
        {
            prop.ThrowIf<T, TException>(prop == null);
            return prop;
        }

        /// <summary>
        /// Throws a specified exception with params if the specified object is null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <typeparam name="TException">The type of exception to be thrown.</typeparam>
        /// <param name="prop">The object to check for null.</param>
        /// <param name="args">The params for create the exception</param>
        /// <returns>The object if it is not null.</returns>
        /// <exception>Thrown when the object is null.</exception>
        public static T ThrowIfNull<T, TException>(this T? prop, params object?[] args)
                where TException : System.Exception
        {
            prop.ThrowIf<T, TException>(prop == null, args);
            return prop;
        }
    }

#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
}