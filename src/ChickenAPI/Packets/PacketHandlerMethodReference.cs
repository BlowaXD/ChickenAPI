using System;
using System.Linq;
using ChickenAPI.Accounts;
using ChickenAPI.Session;

namespace ChickenAPI.Packets
{
    public class PacketHandlerMethodReference
    {
        #region Instantiation

        public PacketHandlerMethodReference(Action<APacket, ISession> handlerMethod, Type parentHandler, Type packetBaseParameterType)
        {
            HandlerMethod = handlerMethod;
            PacketDefinitionParameterType = packetBaseParameterType;
            PacketHeader = PacketDefinitionParameterType.GetCustomAttributes(typeof(PacketHeaderAttribute), true).FirstOrDefault() as PacketHeaderAttribute;
            Identification = PacketHeader?.Identification;
            Authority = PacketHeader?.Authority ?? AuthorityType.User;
            ParentHandler = parentHandler;
        }

        #endregion

        #region Properties

        public Action<APacket, ISession> HandlerMethod { get; }
        public PacketHeaderAttribute PacketHeader { get; set; }
        public AuthorityType Authority { get; }
        public string Identification { get; }
        public Type PacketDefinitionParameterType { get; }
        public Type ParentHandler { get; }

        #endregion
    }
}