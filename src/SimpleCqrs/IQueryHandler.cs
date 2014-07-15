namespace SimpleCqrs
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery
    {
        TResult Query(TQuery query);
    }
}