using System.Threading.Tasks;

namespace SimpleCqrs
{
    public interface IAsyncCommandHandler<in TCommand> where TCommand : ICommand
    {
        Task ExecuteAsync(TCommand command);
    }
}