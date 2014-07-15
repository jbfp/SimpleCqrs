using System.Threading.Tasks;

namespace SimpleCqrs
{
    /// <summary>
    /// Represents an asynchronous handler for a specific <see cref="IQuery"/>.
    /// </summary>
    /// <typeparam name="TQuery">The type of the query to perform.</typeparam>
    /// <typeparam name="TResult">The type of the result of the query.</typeparam>
    public interface IAsyncQueryHandler<in TQuery, TResult> where TQuery : IQuery
    {
        /// <summary>
        /// Performs the query asynchronously and returns the result.
        /// </summary>
        /// <param name="query">The object identitying the query while also providing state necessary for performing the query.</param>
        /// <returns>The task object representing the asynchronous query.</returns>
        Task<TResult> QueryAsync(TQuery query);
    }
}