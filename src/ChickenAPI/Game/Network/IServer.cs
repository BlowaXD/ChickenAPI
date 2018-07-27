using System.Collections.Generic;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Packets;

namespace ChickenAPI.Game.Network
{
    public interface IServer : IBroadcastable
    {
        IPlayerEntity GetPlayerBySessionId(long sessionId);
        IPlayerEntity GetPlayerByAccountId(long accountId);
        IPlayerEntity GetPlayerByCharacterId(long characterId);

        void Register(IPlayerEntity entity);
        void Unregister(IPlayerEntity entity);

        void UnregisterBySessionId(long sessionId);
        void UnregisterByAccountId(long accontId);
        void UnregisterByCharacterId(long characterId);

        IEnumerable<IPlayerEntity> Players { get; }
    }
}