using System.Collections.Generic;
using System.Net;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.ECS.Entities;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Packets;

namespace ChickenAPI.Game.Network
{
    public interface ISession
    {
        int SessionId { get; }

        long CharacterId { get; }

        bool IsAuthenticated { get; }

        IPEndPoint Ip { get; }

        AccountDto Account { get; }
        IPlayerEntity Player { get; }

        void InitializeAccount(AccountDto dto);
        void InitializeCharacterId(long id);
        void InitializeEntity(IPlayerEntity ett);

        void SendPacket(IPacket packetBase);
        void SendPackets(IEnumerable<IPacket> packets);
        void Disconnect();
    }
}