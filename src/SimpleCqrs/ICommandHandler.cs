namespace SimpleCqrs
{
    /// <summary>
    /// Represents a handler for executing a command.
    /// </summary>
    /// <typeparam name="TCommand">The type of the command to execute.</typeparam>
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="command">An object identitying the command while also providing state necessary for executing the command.</param>
        void Execute(TCommand command);
    }
}