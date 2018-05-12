﻿using System.Collections.Generic;
using System.Net;
using ChickenAPI.Dtos;
using ChickenAPI.Enums;
using ChickenAPI.Packets;
using Character = ChickenAPI.Game.Entities.Player.Character;

namespace ChickenAPI.Session
{
    public interface ISession
    {
        int SessionId { get; }
        RegionType SessionRegion { get; }
        IPEndPoint Ip { get; }
        AccountDto Account { get; }
        Character Character { get; }
        AuthorityType Authority { get; }

        bool HasCurrentMapInstance { get; }
        bool IsAuthenticated { get; }
        bool HasSelectedCharacter { get; }

        void SendPacket(APacket packet);
        void SendPackets(IEnumerable<APacket> packets);

        void InitializeAccount(AccountDto account);
        void InitializeCharacter(Character character);
        void Disconnect();
    }
}