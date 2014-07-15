namespace SimpleCqrs
{
    /// <summary>
    /// Represents a command that contains data necessary for performing a specific action.
    /// A command is an action that changes state without returning data.
    /// </summary>
    /// <remarks>
    /// For returning the state changing results of a command, see <see cref="IQuery"/>.
    /// </remarks>
    public interface ICommand
    {
    }
}