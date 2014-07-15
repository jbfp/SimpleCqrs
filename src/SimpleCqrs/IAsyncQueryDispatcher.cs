using System.Threading.Tasks;

namespace SimpleCqrs
{
    /// <summary>
    /// Represents a dispatcher for resolving query handlers and executing queries asynchronously.
    /// </summary>
    public interface IAsyncQueryDispatcher
    {
        /// <summary>
        /// Resolves a query handler for a specific command and returns the result of the query asynchronously.
        /// </summary>
        /// <typeparam name="TQuery">The type of the query.</typeparam>
        /// <typeparam name="TResult">The type of the result of the query.</typeparam>
        /// <param name="query">The query whose handler is to be resolved and queried.</param>
        /// <returns>The task object representing the asynchronous command.</returns>
        Task<TResult> QueryAsync<TQuery, TResult>(TQuery query) where TQuery : IQuery;
    }
}