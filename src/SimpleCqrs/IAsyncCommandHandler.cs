using System.Threading.Tasks;

namespace SimpleCqrs
{
    /// <summary>
    /// Represents an asynchronous handler for an <see cref="ICommand"/>.
    /// </summary>
    /// <typeparam name="TCommand">The type of the command to execute.</typeparam>
    public interface IAsyncCommandHandler<in TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// Executes the command asynchronously.
        /// </summary>
        /// <param name="command">An object identitying the command while also providing state necessary for executing the command.</param>
        /// <returns>The task object representing the asynchronous command.</returns>
        Task ExecuteAsync(TCommand command);
    }
}