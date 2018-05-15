using System;
using System.Linq;
using ChickenAPI.Enums;
using ChickenAPI.Game.Network;

namespace ChickenAPI.Packets
{
    public class PacketHandlerMethodReference
    {
        #region Instantiation

        public PacketHandlerMethodReference(Action<IPacket, ISession> handlerMethod, Type packetBaseParameterType)
        {
            HandlerMethod = handlerMethod;
            PacketType = packetBaseParameterType;
            PacketHeader = PacketType.GetCustomAttributes(typeof(PacketHeaderAttribute), true).FirstOrDefault() as PacketHeaderAttribute;
            Identification = PacketHeader?.Identification;
            Authority = PacketHeader?.Authority ?? AuthorityType.User;
            if (PacketHeader != null)
            {
                NeedCharacter = PacketHeader.NeedCharacter;
            }
        }

        #endregion

        #region Properties

        public Action<IPacket, ISession> HandlerMethod { get; }
        public PacketHeaderAttribute PacketHeader { get; set; }
        public AuthorityType Authority { get; }
        public string Identification { get; }
        public Type PacketType { get; }
        public bool NeedCharacter { get; }

        #endregion
    }
}