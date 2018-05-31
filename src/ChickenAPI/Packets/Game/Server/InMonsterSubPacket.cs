namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("in_monster_subpacket")]
    public class InMonsterSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte HpPercentage { get; set; }

        [PacketIndex(1)]
        public byte MpPercentage { get; set; }

        [PacketIndex(2)]
        public int Unknown1 { get; set; }

        [PacketIndex(3)]
        public int Unknown2 { get; set; }

        [PacketIndex(4)]
        public int Unknown3 { get; set; }

        public bool NoAggressiveIcon { get; set; }
        public int Unknown4 { get; set; }
        public int Unknown5 { get; set; }
        public string Unknown6 { get; set; }
        public int Unknown7 { get; set; }
        public int Unknown8 { get; set; }
        public int Unknown9 { get; set; }
        public int Unknown10 { get; set; }
        public int Unknown11 { get; set; }
        public int Unknown12 { get; set; }
        public int Unknown13 { get; set; }
        public int Unknown14 { get; set; }
        public int Unknown15 { get; set; }
        public int Unknown16 { get; set; }
    }
}