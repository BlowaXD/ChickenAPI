using System;

namespace ChickenAPI.Packets.Serialization
{
    public interface IObjectFactory
    {
        T Create<T>();
        object Create(Type type);
    }
}