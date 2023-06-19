using Consumer.Messages;

namespace Consumer.Handlers;

public interface IMessageHandler
{
    public Task HandleAsync(IMessage message);
    
    public abstract Type MessageType { get; }
}
