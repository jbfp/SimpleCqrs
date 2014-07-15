namespace SimpleCqrs
{
    /// <summary>
    /// Represents a dispatcher for resolving query handlers and executing queries.
    /// </summary>
    public interface IQueryDispatcher
    {
        /// <summary>
        /// Resolves a query handler for a specific command and returns the result of the query.
        /// </summary>
        /// <typeparam name="TQuery">The type of the query.</typeparam>
        /// <typeparam name="TResult">The type of the result of the query.</typeparam>
        /// <param name="query">The query whose handler is to be resolved and queried.</param>
        TResult Query<TQuery, TResult>(TQuery query) where TQuery : IQuery;
    }
}