using ChickenAPI.Enums.Packets;
using ChickenAPI.Packets.Game.Server.Battle;
using ChickenAPI.Packets.Serializers.World.Server.Battle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChickenAPI.Packets.Test
{
    [TestClass]
    public class Battle_Packets_Serialization_Tests
    {
        [TestMethod]
        public void Test_Serializer_CancelPacket()
        {
            // cancel {cancelPacketType} {targetId}
            const string stringPacket = "cancel 2 0";
            IPacketSerializer packetSerializer = new CancelPacketSerializer();
            var packet = new CancelPacket
            {
                TargetId = 0,
                Type = CancelPacketType.InCombatMode
            };

            Assert.AreEqual(stringPacket, packetSerializer.Serialize(packet));
            // todo deserialization
        }
    }
}