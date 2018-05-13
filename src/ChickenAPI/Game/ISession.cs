using System.Collections.Generic;
using System.Net;
using ChickenAPI.Data.TransferObjects;
using ChickenAPI.Enums;
using ChickenAPI.Game.Entities.Player;
using ChickenAPI.Packets;

namespace ChickenAPI.Game
{
    public interface ISession
    {
        int SessionId { get; }
        RegionType SessionRegion { get; }
        IPEndPoint Ip { get; }

        AccountDto Account { get; }

        // TODO IMPROVE THAT ONCE BASIS ARE DONE
        CharacterDto Character { get; }
        CharacterEntity Player { get; }
        AuthorityType Authority { get; }

        bool HasCurrentMapInstance { get; }
        bool IsAuthenticated { get; }
        bool HasSelectedCharacter { get; }

        void SendPacket(APacket packet);
        void SendPackets(IEnumerable<APacket> packets);

        void InitializeAccount(AccountDto account);
        void InitializeCharacter(CharacterDto character);
        void InitializeEntity(CharacterEntity entity);
        void Disconnect();
    }
}