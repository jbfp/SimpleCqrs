using System.Threading.Tasks;

namespace SimpleCqrs
{
    /// <summary>
    /// Represents a dispatcher for resolving command handlers and executing commands asynchronously.
    /// </summary>
    public interface IAsyncCommandDispatcher
    {
        /// <summary>
        /// Resolves a command handler for a specific command and executes it asynchronously.
        /// </summary>
        /// <typeparam name="TCommand">The type of the command-</typeparam>
        /// <param name="command">The command whose handler is to be resolved and executed.</param>
        /// <returns>The task object representing the asynchronous command.</returns>
        Task ExecuteAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}