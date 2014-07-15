namespace SimpleCqrs
{
    /// <summary>
    /// Represents a dispatcher for resolving command handlers and executing commands.
    /// </summary>
    public interface ICommandDispatcher
    {
        /// <summary>
        /// Resolves a command handler for a specific command and executes it.
        /// </summary>
        /// <typeparam name="TCommand">The type of the command-</typeparam>
        /// <param name="command">The command whose handler is to be resolved and executed.</param>
        void Execute<TCommand>(TCommand command) where TCommand : ICommand;
    }
}