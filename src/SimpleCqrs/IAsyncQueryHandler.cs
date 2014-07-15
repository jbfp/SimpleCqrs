using System.Threading.Tasks;

namespace SimpleCqrs
{
    public interface IAsyncQueryHandler<in TQuery, TResult> where TQuery : IQuery
    {
        Task<TResult> QueryAsync(TQuery query);
    }
}