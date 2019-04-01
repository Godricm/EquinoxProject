namespace Equinox.Domain.Core.Events
{
    public interface IHandler<in T,TKey> where T : Message
    {
        void Handle(T message);
    }
}