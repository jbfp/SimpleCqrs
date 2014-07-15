namespace SimpleCqrs
{
    /// <summary>
    /// Represents a query that contains data necessary for performing a query.
    /// A query is an action that returns data without changing state.
    /// </summary>
    /// <remarks>
    /// For changing state, see <see cref="ICommand"/>.
    /// </remarks>
    public interface IQuery
    {
    }
}