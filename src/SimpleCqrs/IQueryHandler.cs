namespace SimpleCqrs
{
    /// <summary>
    /// Represents a handler for a specific <see cref="IQuery"/>.
    /// </summary>
    /// <typeparam name="TQuery">The type of the query to perform.</typeparam>
    /// <typeparam name="TResult">The type of the result of the query.</typeparam>
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery
    {
        /// <summary>
        /// Performs the query and returns the result.
        /// </summary>
        /// <param name="query">An object identitying the query while also providing state necessary for performing the query.</param>
        /// <returns>The result of the query.</returns>
        TResult Query(TQuery query);
    }
}